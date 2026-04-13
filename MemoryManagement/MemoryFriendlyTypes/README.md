# MemoryFriendlyTypes – Bellek Dostu Tipler

## Proje Hakkında

Bu proje, .NET 10 üzerinde **bellek dostu (memory-friendly)** tiplerin kullanımını uygulamalı olarak göstermektedir. `Span<T>`, `ReadOnlySpan<T>`, `Memory<T>` ve `stackalloc` gibi yapıların klasik `string` işlemlerine kıyasla sağladığı performans ve bellek avantajları ele alınmaktadır.

## Ele Alınan Konular

### 1. Klasik String İşlemleri ile Substring Kullanımı

- `string.Substring` ile bir e-posta adresinden kullanıcı adı ve alan adı çıkarma
- `string.IndexOf` ile karakter konumu bulma
- Her `Substring` çağrısının heap üzerinde **yeni bir string nesnesi** oluşturduğunun vurgulanması

### 2. `ReadOnlySpan<char>` ile Sıfır Tahsisli (Zero-Allocation) String İşlemleri

- `string.AsSpan()` ile mevcut stringin `ReadOnlySpan<char>` olarak temsil edilmesi
- `Span.IndexOf` ile karakter arama
- `Span.Slice` ile heap tahsisi yapmadan alt dizi elde etme
- Orijinal string belleği üzerinde doğrudan çalışarak kopya oluşturmama avantajı

### 3. Performans Karşılaştırması: `Substring` vs `Span<T>`

- 1.000.000 adet e-posta adresi üzerinde toplu işlem senaryosu (`generateMillionEmails`)
- `Stopwatch` ile her iki yaklaşımın çalışma süresinin ölçülmesi
- `Substring` döngüsü: Her iterasyonda heap üzerinde yeni string tahsisi
- `Span` döngüsü: Sıfır tahsis ile aynı işlemin gerçekleştirilmesi
- İki yaklaşım arasındaki süre farkının gözlemlenmesi

### 4. `stackalloc` ile Stack Tabanlı Bellek Tahsisi

- `stackalloc int[]` ile 100.000 elemanlık bir dizinin stack üzerinde tahsis edilmesi
- `Span<int>` ile stack belleğine güvenli erişim sağlanması
- Stack tahsisinin heap tahsisine kıyasla hız avantajının `Stopwatch` ile ölçülmesi
- Stack boyut sınırlarının (`StackOverflowException` riski) farkında olunması

### 5. `Memory<T>` ile Asenkron Uyumlu Bellek Temsili

- `string.AsMemory()` ile `ReadOnlyMemory<char>` elde etme
- `Span<T>`'nin yalnızca senkron / stack-bound senaryolarda kullanılabilmesi kısıtı
- `Memory<T>`'nin `async/await` senaryolarında ve sınıf alanlarında saklanabilir olması

## Karşılaştırma Özeti

| Özellik | `string.Substring` | `Span<T>` / `ReadOnlySpan<T>` | `Memory<T>` |
|---|---|---|---|
| Heap tahsisi | ✅ Her çağrıda yeni nesne | ❌ Sıfır tahsis | ❌ Sıfır tahsis |
| Stack kullanımı | ❌ | ✅ (`stackalloc` ile) | ❌ |
| Async desteği | ✅ | ❌ | ✅ |
| Sınıf alanı olarak saklanabilir | ✅ | ❌ (yalnızca `ref struct`) | ✅ |
| GC baskısı | Yüksek | Düşük | Düşük |

## Öğrenme Çıktıları

Bu projeyi tamamladığınızda aşağıdaki kazanımlara sahip olursunuz:

1. `Span<T>` ve `ReadOnlySpan<T>` tiplerinin ne olduğunu ve neden `ref struct` olduklarını anlama
2. `AsSpan()` ve `Slice()` ile sıfır tahsisli string/dizi işlemleri gerçekleştirebilme
3. `stackalloc` ile stack üzerinde bellek tahsis edebilme ve bunun avantaj/risklerini bilme
4. `Memory<T>` ile `Span<T>` arasındaki farkı ve kullanım senaryolarını kavrama
5. `Stopwatch` ile farklı yaklaşımların performansını ölçebilme
6. Yüksek hacimli veri işlemlerinde GC baskısını azaltacak bellek dostu teknikler uygulayabilme

## Kullanılan Teknolojiler

- **Platform:** .NET 10
- **Dil:** C# 14.0
