# eventMechanism

C# dilinde **event (olay) mekanizmasının** nasıl çalıştığını gösteren bir Windows Forms uygulamasıdır.

## Proje Bilgileri

| Özellik | Değer |
|---|---|
| Platform | .NET 10 (Windows Forms) |
| Dil | C# 14 |
| IDE | Visual Studio 2026 |

## Ele Alınan Konular

### 1. Event (Olay) Kavramı
- Bir nesne üzerinde gerçekleşen bir durumun, ilgili diğer nesnelere bildirilmesi mekanizması.
- **Publisher–Subscriber** (yayıncı–abone) tasarım kalıbının C# event altyapısıyla uygulanması.

### 2. Delegate Tabanlı Event Tanımlama (Eski Yöntem)
- Özel bir `delegate` türü tanımlayarak event oluşturma yaklaşımı (`ProductCreatedEventHandler`).
- Bu yöntemin neden artık tercih edilmediğinin açıklanması.

### 3. Generic EventHandler\<T\> Kullanımı (Modern Yöntem)
- `EventHandler<TEventArgs>` jenerik yapısının kullanılması.
- Özel delegate tanımlamaya gerek kalmadan event bildirimi yapılması.

### 4. Özel EventArgs Sınıfı Oluşturma
- `EventArgs` sınıfından türetilen `ProductCreatedEventArgs` ile olaya özel veri taşınması.
- Event tetiklendiğinde abone metotlara bağlamsal bilgi (ürün adı, oluşturan kişi, tarih) aktarılması.

### 5. Event Yayınlama (Publish / Raise)
- Bir servis sınıfı (`ProductService`) içinde event tanımlama ve tetikleme.
- Event'in `null` kontrolü yapılarak güvenli şekilde çağrılması.

### 6. Event'e Abone Olma (Subscribe)
- `+=` operatörü ile bir event'e handler metot bağlama.
- Form tarafında event handler yazarak kullanıcıya bildirim gösterme.

### 7. Sender Kavramı ve Tür Dönüşümü
- Event handler'daki `sender` parametresinin event'i tetikleyen nesneye referans olması.
- `as` operatörü ile `sender` üzerinden güvenli tür dönüşümü yapılması (örneğin buton renginin değiştirilmesi).

### 8. Birden Fazla Kontrolü Tek Handler'a Bağlama
- Çok sayıda butonun aynı `Click` event handler'ını paylaşması.
- `sender` ile hangi kontrolün olayı tetiklediğinin belirlenmesi.

### 9. Farklı Event Türleri
- `Click` (fare tıklaması) ve `KeyDown` (klavye tuşu basılması) gibi yerleşik Windows Forms event'lerinin kullanımı.

## Öğrenme Çıktıları

Bu projeyi tamamladığınızda:

- C# dilinde **event** ve **delegate** arasındaki ilişkiyi açıklayabilirsiniz.
- **Eski delegate tabanlı** yöntem ile **modern `EventHandler<T>`** yöntemi arasındaki farkı anlarsınız.
- Özel bir `EventArgs` sınıfı oluşturarak event'ler aracılığıyla veri taşıyabilirsiniz.
- Bir sınıf içinde event **tanımlayabilir**, **tetikleyebilir** ve dışarıdan bu event'e **abone olabilirsiniz**.
- `sender` parametresini kullanarak event'i tetikleyen nesneye erişebilir ve üzerinde işlem yapabilirsiniz.
- **Publisher–Subscriber** desenini kendi projelerinizde uygulayabilirsiniz.
- Windows Forms uygulamalarında yerleşik event'lerin (`Click`, `KeyDown`) nasıl çalıştığını kavrayabilirsiniz.
