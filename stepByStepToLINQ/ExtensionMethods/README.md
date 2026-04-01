# Extension Methods

Uzantı metotları (extension methods) kavramını farklı veri tipleri üzerinde uygulayarak gösteren bir .NET 10 konsol uygulamasıdır.

## 🎯 Öğrenme Çıktıları

Bu projeyi tamamladığınızda aşağıdaki konularda bilgi ve beceri kazanmış olacaksınız:

### Uzantı Metotları (Extension Methods)
- `this` anahtar kelimesi ile mevcut tiplere yeni metotlar ekleyebilme
- Uzantı metotlarının statik sınıf içinde tanımlanması gerektiğini kavrama
- Kaynak koduna erişim olmadan bir tipe davranış kazandırabilme

### Farklı Tipler Üzerinde Uzantı Metotları
- Değer tipleri (`int`) üzerinde uzantı metot yazabilme
- Referans tipleri (`string`) üzerinde uzantı metot yazabilme
- Framework sınıfları (`Random`) üzerinde uzantı metot yazabilme

### Opsiyonel Parametreler
- Uzantı metotlarında varsayılan değer alan parametreler tanımlayabilme
- Opsiyonel parametrelerin metot çağrısındaki davranışını anlama

### String Doğrulama Mantığı
- Bir string değeri belirli kurallara göre doğrulayabilme
- `Contains` ve `Split` metotlarıyla metin analizi yapabilme

### ASCII Karakter İşlemleri
- ASCII tablosunu kullanarak karakter üretebilme
- Tür dönüşümü (`char` cast) ile sayısal değerden karakter elde edebilme

### LINQ ile Uzantı Metotlarının İlişkisi
- `Where`, `ToList`, `ForEach` gibi LINQ metotlarının birer uzantı metot olduğunu kavrama
- Lambda ifadelerini uzantı metotlarla birlikte kullanabilme

### Ternary (Koşul) Operatörü
- `? :` operatörü ile satır içi koşullu ifadeler yazabilme

## 🛠️ Teknolojiler

| Teknoloji | Sürüm |
|-----------|-------|
| .NET | 10.0 |
| C# | 14.0 |

## 🚀 Çalıştırma

```bash
dotnet run --project ExtensionMethods
```
