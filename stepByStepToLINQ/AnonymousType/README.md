# Step by Step to LINQ

LINQ (Language Integrated Query) konusuna adım adım ilerlemek için hazırlanmış bir .NET 10 konsol uygulamasıdır.

## 🎯 Öğrenme Çıktıları

Bu projeyi tamamladığınızda aşağıdaki konularda bilgi ve beceri kazanmış olacaksınız:

### Anonim Tipler (Anonymous Types)
- Sınıf tanımlamadan, anlık olarak yeni tipler oluşturabilme
- Anonim tiplerin hangi senaryolarda tercih edilmesi gerektiğini anlama
- Anonim tiplerin salt okunur (immutable) yapısını kavrama

### `dynamic` Anahtar Kelimesi
- `dynamic` tipinin derleme zamanı ile çalışma zamanı arasındaki farkını anlama
- `dynamic` kullanımının avantajlarını ve risklerini değerlendirebilme
- `dynamic` ile anonim tipler arasındaki farkı ayırt edebilme

### Örtük Tipleme (`var`)
- `var` anahtar kelimesinin tür çıkarımı (type inference) mekanizmasını kavrama
- `var` kullanımının kodun okunabilirliğine etkisini değerlendirebilme

### Koleksiyon ve Nesne Başlatıcılar
- Nesne başlatıcı (object initializer) söz dizimini kullanabilme
- Koleksiyon başlatıcı (collection initializer) ile veri listeleri oluşturabilme
- Hedef tipli `new` ifadelerini (target-typed new) kullanabilme

### LINQ Sorgu Söz Dizimi (Query Syntax)
- `from`, `where`, `select` anahtar kelimelerini kullanarak sorgu yazabilme
- LINQ sorgularıyla veri filtreleme işlemleri gerçekleştirebilme
- Sorgu sonucunda anonim tipler ile projeksiyon (projection) yapabilme
- LINQ'in SQL benzeri doğal dil yaklaşımını kavrama

### Yerel Fonksiyonlar (Local Functions)
- Bir metot içinde yerel fonksiyon tanımlayabilme
- Yerel fonksiyonların kullanım alanlarını ve kapsamını anlama

### String İnterpolasyon
- `$""` söz dizimi ile biçimlendirilmiş metin çıktıları oluşturabilme

## 🛠️ Teknolojiler

| Teknoloji | Sürüm |
|-----------|-------|
| .NET | 10.0 |
| C# | 14.0 |
| Proje Stili | SDK-style |

## 📁 Proje Yapısı

- **AnonymousType** — Anonim tipler, `dynamic`, LINQ sorgu söz dizimi ve yerel fonksiyonları kapsayan konsol uygulaması

## 🚀 Çalıştırma

```bash
dotnet run --project AnonymousType
```
