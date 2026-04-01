# Delegates

Delegate kavramından Lambda ifadelerine ve LINQ'e uzanan süreci adım adım gösteren bir .NET 10 konsol uygulamasıdır.

## 🎯 Öğrenme Çıktıları

Bu projeyi tamamladığınızda aşağıdaki konularda bilgi ve beceri kazanmış olacaksınız:

### Delegate Kavramı
- Delegate'lerin metot referansı olarak nasıl çalıştığını kavrama
- Özel delegate tanımı ile `Func<T, TResult>` arasındaki farkı anlama
- Delegate parametresi alan metotlar tasarlayabilme

### Anonim Metotlar (Anonymous Methods)
- `delegate` anahtar kelimesi ile satır içi (inline) metot tanımlayabilme
- Anonim metotların delegate'lere nasıl atandığını anlama

### Lambda İfadeleri (Lambda Expressions)
- `=>` söz dizimi ile kısa ve okunabilir ifadeler yazabilme
- Lambda ifadelerinin anonim metotlara göre avantajlarını kavrama
- Lambda ifadelerini delegate parametresi olarak kullanabilme

### Yerel Fonksiyonlar (Local Functions)
- Expression-bodied yerel fonksiyon tanımlayabilme
- Yerel fonksiyonları delegate parametresi olarak geçirebilme

### Func\<T, TResult\> Temsilcisi
- Genel amaçlı `Func` temsilcisini kullanabilme
- Özel delegate tanımlamak yerine `Func` tercih etmenin avantajlarını anlama

### Filtreleme Mantığının Soyutlanması
- Filtreleme kriterini bir davranış (behavior) olarak parametre haline getirebilme
- Strateji desenine (Strategy Pattern) giriş niteliğinde tasarım yapabilme
- Aynı metodu farklı kriterlerle yeniden kullanabilme

### LINQ'e Geçiş
- `Where` extension metodunun delegate tabanlı filtrelemeyle ilişkisini kavrama
- `ForEach` ile koleksiyon üzerinde eylem gerçekleştirebilme
- Delegate → Anonim Metot → Lambda → LINQ evrimini anlama

## 🛠️ Teknolojiler

| Teknoloji | Sürüm |
|-----------|-------|
| .NET | 10.0 |
| C# | 14.0 |

## 🚀 Çalıştırma

```bash
dotnet run --project Delegates
```
