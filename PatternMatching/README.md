# Pattern Matching (C# İleri)

Bu proje, C# dilindeki **Pattern Matching** (desen eşleme) özelliklerini uygulamalı olarak ele almaktadır. .NET 10 ve C# 14 hedeflenerek hazırlanmıştır.

## Öğrenme Hedefleri

- Geleneksel `if` yapıları yerine pattern matching kullanarak daha okunabilir ve kısa kod yazmayı kavramak
- Farklı pattern matching türlerini ve kullanım senaryolarını öğrenmek
- `switch` ifadesi yerine **switch expression** kullanımını benimsemek
- `record` türlerinin pattern matching ile birlikte nasıl kullanıldığını anlamak

## Aktarılan Konular

### 1. Property Pattern (Özellik Deseni)
Bir nesnenin birden fazla özelliğini tek bir `is` ifadesiyle kontrol etme yöntemi. İç içe geçmiş `if` bloklarının yerine `{ Property: value }` söz dizimi ile daha sade bir alternatif sunulması.

### 2. Tuple Pattern (Demet Deseni)
Birden fazla değerin aynı anda bir `switch` expression içinde eşleştirilmesi. Örneğin iki eksen değerine göre yön belirleme gibi çok boyutlu karar senaryolarında kullanımı.

### 3. Relational Pattern (İlişkisel Desen)
Karşılaştırma operatörlerinin (`<`, `>`, `>=`, `<=`) doğrudan desen içinde kullanılması. Sayısal aralıklara göre farklı sonuçlar üretme.

### 4. Switch Expression
Geleneksel `switch` bloğu yerine ifade tabanlı (`=>`) switch kullanımı. Daha kısa ve fonksiyonel bir yazım biçimi.

### 5. Variable Pattern ve `when` Guard Clause
Desen içinde bir değeri değişkene atayıp (`var c`), ardından `when` anahtar kelimesiyle ek koşullar tanımlama. Karmaşık aralık kontrolleri için kullanımı.

### 6. Record Türleri
`record` anahtar kelimesiyle değer odaklı, değiştirilemez (immutable) veri modelleri oluşturma. Pattern matching ile doğal uyumu.

## Proje Yapısı

```
PatternMatching/
├── README.md
└── PatternMatching/
    ├── PatternMatching.csproj
    └── Program.cs
```
