# LINQShowcase

Bu proje, C# dilinde **LINQ (Language Integrated Query)** temel ve orta düzey kullanımlarını öğretmeye yönelik hazırlanmış bir konsol uygulamasıdır.

## Öğrenme Hedefleri

Bu projeyi tamamladığınızda aşağıdaki konularda pratik kazanmış olacaksınız:

- LINQ sorgularını method syntax ile yazabilme
- Koleksiyonlar üzerinde projeksiyon, filtreleme ve sıralama işlemleri uygulayabilme
- Tekil eleman sorgulama yöntemlerini ve farklarını anlayabilme
- Aggregation (toplama) metotlarını kullanarak veri analizi yapabilme
- Koleksiyonları gruplama, parçalama ve benzersiz elemanları elde etme

## Ele Alınan LINQ Metotları

### Projeksiyon

| Metot | Açıklama |
|-------|----------|
| `Select` | Koleksiyondaki her elemanı yeni bir forma dönüştürür. Anonim tipler ile yalnızca istenen alanları seçmeye olanak tanır. |
| `ToList` | Sorgu sonucunu somut bir `List<T>` koleksiyonuna dönüştürerek sorgunun anında çalıştırılmasını sağlar. |

### Filtreleme

| Metot | Açıklama |
|-------|----------|
| `Where` | Belirli bir koşula uyan elemanları süzer. Birden fazla koşul birleştirilebilir. |

### Sıralama

| Metot | Açıklama |
|-------|----------|
| `OrderByDescending` | Koleksiyonu belirtilen alana göre büyükten küçüğe sıralar. |

### Eleman Seçimi

| Metot | Açıklama |
|-------|----------|
| `Take` | Koleksiyonun başından belirtilen sayıda eleman alır. Sayfalama senaryolarında sıkça kullanılır. |
| `FirstOrDefault` | Koşula uyan ilk elemanı döndürür; bulunamazsa varsayılan bir değer döndürür. İkinci parametresi ile özel varsayılan nesne belirlenebilir. |
| `SingleOrDefault` | Koşula uyan tek bir eleman döndürür. Birden fazla eleman eşleşirse istisna fırlatır. Benzersizlik garantisi gereken durumlarda tercih edilir. |

### Aggregation (Toplama)

| Metot | Açıklama |
|-------|----------|
| `Average` | Belirtilen sayısal alanın aritmetik ortalamasını hesaplar. |
| `Max` | Belirtilen sayısal alanın en büyük değerini döndürür. |
| `MinBy` | Belirtilen alana göre en küçük değere sahip olan elemanın kendisini döndürür. `Min` metodu yalnızca değeri döndürürken, `MinBy` nesnenin tamamını verir. |
| `Count` | Koleksiyondaki eleman sayısını döndürür. |

### Küme ve Gruplama İşlemleri

| Metot | Açıklama |
|-------|----------|
| `DistinctBy` | Belirtilen bir alana göre tekrar eden elemanları kaldırarak benzersiz sonuçlar üretir. |
| `GroupBy` | Elemanları belirli bir anahtara göre gruplar. Her grup için toplam, ortalama gibi hesaplamalar yapılabilir. |

### Bölümleme

| Metot | Açıklama |
|-------|----------|
| `Chunk` | Koleksiyonu belirtilen boyutta alt dizilere böler. Toplu işlem (batch processing) senaryolarında kullanışlıdır. |

### Koleksiyon Üretimi ve Sayım

| Metot | Açıklama |
|-------|----------|
| `Enumerable.Range` | Belirtilen başlangıç değerinden itibaren ardışık tamsayılardan oluşan bir dizi üretir. |
| `TryGetNonEnumeratedCount` | Koleksiyonu dolaşmadan (enumerate etmeden) eleman sayısını almaya çalışır. Performans açısından `Count` metoduna göre avantajlıdır. |

## Proje Yapısı

- **Product**: Ürün bilgilerini tutan veri modeli sınıfı (`Id`, `Name`, `Price`, `Description`, `Category`, `IsActive`, `AddToStockDate`, `CreatedDate`).
- **ProductService**: Örnek ürün verilerini sağlayan servis sınıfı. Elektronik, Giyim ve Aksesuar kategorilerinde gerçekçi fiyatlara sahip ürünler içerir.
- **Program.cs**: Tüm LINQ sorgularının çalıştırıldığı ve sonuçların konsola yazdırıldığı giriş noktası.

## Hedef Platform

- **.NET 10**
- **C# 14**
