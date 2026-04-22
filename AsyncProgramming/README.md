# Asenkron Programlama — C# İleri Seviye

> **Platform:** .NET 10 · **UI:** Windows Forms  
> **Repo:** [pupilica-ileri-csharp-2026](https://github.com/turkayurkmez/pupilica-ileri-csharp-2026)

---

## Öğrenme Çıktıları

Bu modülü tamamlayan katılımcı:

1. Senkron kodun UI yi neden kilitlediğini açıklayabilir.
2. `Thread` sınıfı ile arka planda iş parçacığı oluşturabilir.
3. `ThreadStart` ve `ParameterizedThreadStart` delegeleri arasındaki farkı ayırt edebilir.
4. `thread.Join()` metodunun ne zaman kullanılacağını açıklayabilir.
5. Worker thread den UI kontrollerine erişimde `CheckForIllegalCrossThreadCalls` ayarının ne anlama geldiğini bilir.
6. `Task.Run()` ile ThreadPool üzerinde arka plan işi başlatabilir.
7. `async` / `await` anahtar kelimeleriyle UI thread ini bloklamadan asenkron iş akışı kurabilir.
8. `await Task.Delay()` ile UI thread ine nefes aldırmanın ne anlama geldiğini açıklayabilir.
9. `CancellationTokenSource` ve `CancellationToken` ile çalışan bir görevi iptal edebilir.
10. `ThrowIfCancellationRequested()` ve `IsCancellationRequested` arasındaki farkı bilir.

---

## Kavramlar

### 1. Senkron (Blocking) Kod

Uzun süren bir işlem UI thread inde çalıştırıldığında pencere donar; kullanıcı arayüzü yanıt vermez.

```csharp
// Form1.cs — buttonSync_Click
private void buttonSync_Click(object sender, EventArgs e)
{
    for (int i = 0; i <= 100_000; i++)
    {
        labelSync.Text = i.ToString();
        progressBarSync.Value = i / 1000;
    }
    MessageBox.Show("Döngü bitti");
}
```

**Sorun:** `for` döngüsü bitmeden Windows mesaj kuyruğu işlenemez. Butona tıklandığı anda pencere kilitlenir; `MessageBox` ancak döngü bitince görünür.

---

### 2. `Thread` Sınıfı

`System.Threading.Thread`, işletim sistemi seviyesinde yeni bir iş parçacığı oluşturur. Uzun süren iş UI thread inden ayrı bir thread e taşınır; pencere yanıt vermeye devam eder.

```csharp
// Form1.cs — buttonThread_Click
Thread thread = null;

private void buttonThread_Click(object sender, EventArgs e)
{
    thread = new Thread(new ParameterizedThreadStart(loopWithThread));
    thread.Start(10_000);

    thread.Join();                        // thread bitene kadar UI thread i bekler
    MessageBox.Show("Thread Döngüsü bitti");
}

void loopWithThread(object number)
{
    int x = (int)number;
    for (int i = 0; i < x; i++)
    {
        labelThread.Text = i.ToString();   // cross-thread erişim (demo)
        progressBarThread.Value = i / 100;
    }
}
```

#### Thread Delegate Türleri

| Delegate | İmza | Parametre |
|---|---|---|
| `ThreadStart` | `void Method()` | Yok |
| `ParameterizedThreadStart` | `void Method(object obj)` | `object` (tek) |

#### `thread.Join()`

`Join()` çağıran thread i, ilgili thread tamamlanana kadar **bloklar**. `Join()` kaldırıldığında `MessageBox` hemen görünür; thread arka planda çalışmaya devam eder.

---

### 3. `CheckForIllegalCrossThreadCalls = false`

```csharp
public Form1()
{
    CheckForIllegalCrossThreadCalls = false;  // demo kolaylığı için
    InitializeComponent();
}
```

Worker thread UI kontrolüne doğrudan eriştiğinde normalde `InvalidOperationException: Cross-thread operation not valid` hatası fırlatılır. Bu satır o kontrolü devre dışı bırakır.

> Yalnızca öğrenme/demo amaçlıdır. Üretim kodunda `Invoke` / `BeginInvoke` kullanılmalıdır.

---

### 4. `Task.Run()` — ThreadPool Üzerinde Çalışma

`Task`, işletim sistemi thread i yerine .NET **ThreadPool** unu kullanır; daha hafif ve yönetilebilirdir.

```csharp
// Form1.cs — buttonTask_Click
// .NET in ThreadPool üzerinde çalışan, yönetilen bir iş birimidir.
private void buttonTask_Click(object sender, EventArgs e)
{
    var task = Task.Run(() => loopWithTask(10_000));

    if (task.IsCompleted)
    {
        MessageBox.Show("task bitti");
    }
}

void loopWithTask(int number)
{
    for (int i = 0; i <= number; i++)
    {
        labelTask.Text = i.ToString();
        progressBarTask.Value = i / 100;
    }
}
```

**Dikkat:** `task.IsCompleted` kontrolü `Task.Run()` hemen ardından yapılır; görev henüz bitmemiş olduğundan `MessageBox` çoğunlukla **görünmez**. Tamamlanmayı beklemek için `await` kullanılmalıdır.

---

### 5. `async` / `await` — Asenkron Akış Kontrolü

`async` bir metodu asenkron yapar; `await` ise belirtilen görevi beklerken UI thread ini **serbest bırakır**.

```csharp
// Aman dikkat! Sadece Event Handler lar async void olabilir.
private async void buttonAsyncTask_Click(object sender, EventArgs e)
{
    buttonAsyncTask.Enabled = false;
    await loopWithAsync(10000);
    MessageBox.Show("async çağrı tamamlandı");
    buttonAsyncTask.Enabled = true;
}

// Normal metodlar async olması için mutlaka Task döndürmeli.
async Task loopWithAsync(int number)
{
    for (int i = 0; i <= number; i++)
    {
        labelAsyncAwait.Text = i.ToString();
        progressBarAsyncAwait.Value = i / 100;

        // UI thread den bağımsız çalış ve ona nefes aldır
        await Task.Delay(10);
    }
}
```

#### Kurallar

| Kural | Açıklama |
|---|---|
| Event handler → `async void` | Kabul edilebilir tek `async void` durumu |
| Diğer metodlar → `async Task` | İstisna yönetimi ve `await` desteği için |
| `await Task.Delay(ms)` | Thread i bloklamadan bekler; UI ya nefes verir |
| `async` tek başına | Paralel çalıştırmaz; sadece `await` noktasında UI yi serbest bırakır |

---

### 6. `CancellationToken` — İptal Mekanizması

İptal sinyali `CancellationTokenSource` tarafından yönetilir. **Start** butonu her seferinde yeni token oluşturur; **Stop** butonu mevcut token ı iptal eder. Her iki buton da aynı `cancellationTokenSource` alanına erişmek zorundadır.

```csharp
CancellationTokenSource cancellationTokenSource;

private async void buttonStart_Click(object sender, EventArgs e)
{
    cancellationTokenSource = new CancellationTokenSource();
    try
    {
        await loopWithCancellableAsync(100_000, cancellationTokenSource.Token);
    }
    catch (OperationCanceledException)
    {
        MessageBox.Show("task iptal edildi");
    }
    finally
    {
        cancellationTokenSource.Dispose();
    }
}

private void buttonStop_Click(object sender, EventArgs e)
{
    cancellationTokenSource.Cancel();   // iptal sinyali gönder
}

async Task loopWithCancellableAsync(int number, CancellationToken cancellationToken)
{
    for (int i = 0; i <= number; i++)
    {
        // İptal sinyali geldiyse OperationCanceledException fırlatır
        cancellationToken.ThrowIfCancellationRequested();

        labelCalncellable.Text = i.ToString();
        progressBarCancelable.Value = i / 1000;

        await Task.Delay(10);
    }
}
```

#### İptal Yöntemleri Karşılaştırması

| Yöntem | Davranış |
|---|---|
| `ThrowIfCancellationRequested()` | İptal sinyalinde `OperationCanceledException` fırlatır; `catch` ile yakalanır |
| `IsCancellationRequested` | `bool` döndürür; kod akışını elle yönetmek gerekir |

---

## Yaklaşımlar Karşılaştırması

| | Senkron | `Thread` | `Task.Run` | `async/await` + `CancellationToken` |
|---|---|---|---|---|
| UI yanıt verir mi? | Hayır | Evet | Evet | Evet |
| ThreadPool kullanır | Hayır | Hayır | Evet | Evet |
| İptal desteği | Yok | Manuel | Token parametresi | `CancellationToken` |
| UI güncellemesi | Doğrudan | `Invoke` gerekir | `Invoke` gerekir | Doğrudan (`await` sonrası) |
| Kullanım zorluğu | En kolay | Orta | Orta | Kolay (okunabilir) |

---

## Proje Yapısı

```
AsyncProgramming/
├── AsyncProgramming.csproj   # .NET 10 Windows Forms projesi
├── Program.cs                # Uygulama giriş noktası
├── Form1.cs                  # Tüm demo senaryoları
└── Form1.Designer.cs         # Tasarımcı tarafından üretilen UI kodu
```

### Form Bileşenleri

| Demo | Buton(lar) | Label | ProgressBar |
|---|---|---|---|
| Senkron | `buttonSync` | `labelSync` | `progressBarSync` |
| Thread | `buttonThread` | `labelThread` | `progressBarThread` |
| Task.Run | `buttonTask` | `labelTask` | `progressBarTask` |
| async/await | `buttonAsyncTask` | `labelAsyncAwait` | `progressBarAsyncAwait` |
| CancellationToken | `buttonStart` / `buttonStop` | `labelCalncellable` | `progressBarCancelable` |

---

## Projeyi Çalıştırma

```powershell
cd AsyncProgramming
dotnet run
```

Veya Visual Studio da **F5** tuşuyla çalıştırabilirsiniz.

---

## Ek Kaynaklar

- [Thread sınıfı — Microsoft Docs](https://learn.microsoft.com/dotnet/api/system.threading.thread)
- [Task.Run — Microsoft Docs](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task.run)
- [async / await — Microsoft Docs](https://learn.microsoft.com/dotnet/csharp/asynchronous-programming/)
- [CancellationToken — Microsoft Docs](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)
- [Managed Threading Best Practices](https://learn.microsoft.com/dotnet/standard/threading/managed-threading-best-practices)
