# Asenkron Programlama — C# İleri Seviye

> **Platform:** .NET 10 · **UI:** Windows Forms  
> **Repo:** [pupilica-ileri-csharp-2026](https://github.com/turkayurkmez/pupilica-ileri-csharp-2026)

---

## 🎯 Öğrenme Çıktıları

Bu modülü tamamlayan katılımcı:

1. Senkron kodun UI'ı neden kilitlediğini açıklayabilir.
2. `Thread` sınıfı ile arka planda iş parçacığı oluşturabilir.
3. `ThreadStart` ve `ParameterizedThreadStart` delegeleri arasındaki farkı ayırt edebilir.
4. `thread.Join()` metodunun ne zaman kullanılacağını açıklayabilir.
5. Worker thread'den UI kontrollerine erişimde `CheckForIllegalCrossThreadCalls` ayarının ne anlama geldiğini bilir.


---

## 📚 Kavramlar

### 1. Senkron (Blocking) Kod

Uzun süren bir işlem UI thread'inde çalıştırıldığında pencere donar; kullanıcı arayüzü yanıt vermez.

```csharp
// Form1.cs — buttonSync_Click
private void buttonSync_Click(object sender, EventArgs e)
{
    for (int i = 0; i <= 100000; i++)
    {
        labelSync.Text = i.ToString();
        progressBarSync.Value = i / 1000;
    }

    MessageBox.Show("Döngü bitti");
}
```

**Sorun:** `for` döngüsü bitmeden Windows mesaj kuyruğu işlenemez.  
Butona tıklandığı anda pencere kilitlenir; `MessageBox` ancak döngü bitince görünür.

---

### 2. `Thread` Sınıfı

`System.Threading.Thread`, işletim sistemi seviyesinde yeni bir iş parçacığı oluşturur.  
Uzun süren iş UI thread'inden ayrı bir thread'e taşınır ve pencere yanıt vermeye devam eder.

```csharp
// Form1.cs — buttonThread_Click
Thread thread = null;

private void buttonThread_Click(object sender, EventArgs e)
{
    thread = new Thread(new ParameterizedThreadStart(loopWithThread));
    thread.Start(10000);   // metoda parametre geçirilir

    //thread.Join();
    //MessageBox.Show("Thread Döngüsü bitti");
}

void loopWithThread(object number)
{
    int x = (int)number;
    for (int i = 0; i < x; i++)
    {
        labelThread.Text = i.ToString();     // ⚠️ başka thread'den UI erişimi
        progressBarThread.Value = i / 100;
    }
}
```

---

### 3. Thread Delegate Türleri

`Thread` constructor'ı iki farklı delegate kabul eder:

| Delegate | İmza | Parametre |
|---|---|---|
| `ThreadStart` | `void Method()` | Yok |
| `ParameterizedThreadStart` | `void Method(object obj)` | `object` (tek) |

```csharp
// Parametresiz
var t1 = new Thread(new ThreadStart(Metod));
t1.Start();

// Parametreli
var t2 = new Thread(new ParameterizedThreadStart(MetodParametreli));
t2.Start(10000);   // parametre burada geçirilir
```

---

### 4. `thread.Join()`

`Join()`, çağıran thread'i ilgili thread tamamlanana kadar **bloklar**.

```csharp
thread.Start(10000);
thread.Join();                        // burası bitmeden devam etmez
MessageBox.Show("Thread bitti");      // yalnızca thread bitince çalışır
```

Projede `Join()` **yorum satırında** bırakılmıştır; bu sayede butona tıklandıktan hemen sonra UI serbest kalır ve thread arka planda çalışmaya devam eder.

---

### 5. `CheckForIllegalCrossThreadCalls = false`

```csharp
// Form1.cs — constructor
public Form1()
{
    CheckForIllegalCrossThreadCalls = false;
    InitializeComponent();
}
```

Normalde bir worker thread, UI kontrolüne doğrudan erişmeye çalıştığında  
`InvalidOperationException: Cross-thread operation not valid` hatası fırlatılır.

`CheckForIllegalCrossThreadCalls = false` bu kontrolü **devre dışı bırakır** ve hatanın görünmesini engeller.

> ⚠️ Bu ayar yalnızca öğrenme/demo amaçlıdır.  
> Üretim kodunda UI kontrollerine her zaman `Invoke` / `BeginInvoke` ile erişilmelidir.

---

### 6. Cross-Thread Erişim — Doğru Yöntem

```csharp
void loopWithThread(object number)
{
    int x = (int)number;
    for (int i = 0; i < x; i++)
    {
        // UI güncellemesini UI thread'ine taşı
        labelThread.Invoke(() => labelThread.Text = i.ToString());
        progressBarThread.Invoke(() => progressBarThread.Value = i / 100);
    }
}
```

`Invoke`, verilen Action'ı UI thread'i üzerinde çalıştırır ve işlem bitene kadar bekler.  
`BeginInvoke` ise beklemeden (fire-and-forget) gönderir.

---

## 🔄 Senkron vs Thread Karşılaştırması

| | Senkron | Thread |
|---|---|---|
| Pencere yanıt verir mi? | ❌ Hayır (kilitlenir) | ✅ Evet |
| UI güncellemesi | Doğrudan | `Invoke` gerekir |
| `MessageBox` zamanı | Döngü bitince | Hemen (Join yoksa) |
| Kullanım zorluğu | Kolay | Orta |

---

## 📁 Proje Yapısı

```
AsyncProgramming/
├── AsyncProgramming.csproj   # .NET 10 Windows Forms projesi
├── Program.cs                # Uygulama giriş noktası
├── Form1.cs                  # Senkron ve Thread demo ekranı
└── Form1.Designer.cs         # Tasarımcı tarafından üretilen UI kodu
```

### Form Bileşenleri

| Grup Kutusu | Buton | Label | ProgressBar |
|---|---|---|---|
| **Senkron** | `buttonSync` | `labelSync` | `progressBarSync` |
| **Asenkron - Thread** | `buttonThread` | `labelThread` | `progressBarThread` |

---

## 🚀 Projeyi Çalıştırma

```powershell
cd AsyncProgramming
dotnet run
```

Veya Visual Studio'da **F5** tuşuyla çalıştırabilirsiniz.

---

## 📖 Ek Kaynaklar

- [Thread sınıfı — Microsoft Docs](https://learn.microsoft.com/dotnet/api/system.threading.thread)
- [ParameterizedThreadStart — Microsoft Docs](https://learn.microsoft.com/dotnet/api/system.threading.parameterizedthreadstart)
- [Control.Invoke — Microsoft Docs](https://learn.microsoft.com/dotnet/api/system.windows.forms.control.invoke)
- [Managed Threading Best Practices](https://learn.microsoft.com/dotnet/standard/threading/managed-threading-best-practices)
