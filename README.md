# C# İleri Seviye Eğitim Projesi

Bu repository, C# programlama dilinin ileri seviye konularını kapsayan örnek projeleri içermektedir.

## 📚 İçindekiler

### 1. TypesDetails (Veri Tipi Detayları)

Bu klasör, C#'ta veri tipleriyle ilgili detaylı çalışmaları içerir.

#### 1.1 EnumTypes (Enum Tipleri)
Enum (Numaralandırma) türlerinin kullanımını ve özelliklerini gösteren örnekler içerir.

**Proje İçeriği:**
- **StudentState.cs**: Öğrenci durumlarını temsil eden bir enum (`Graduate`, `Failed`, `Unknown`, `Canceled`)
- **Student.cs**: Öğrenci sınıfı - Name, Score ve State özelliklerine sahiptir
- **ErkekAkrabalikTipleri.cs**: Bayılar için akrabalık türlerini temsil eden flags enum yapısı
  - `Flags` attribute kullanılarak birden fazla değer kombinasyonuna izin verir
  - Değerler: Ogul (1), Baba (2), Abi (4), Amca (8), Dayi (16), Dede (32), Eniste (64)
  - Bitwise operatörlerle kombinasyon oluşturma örneği
- **Program.cs**: 
  - Enum ile switch-case kullanımı
  - Flags enum ile bitwise OR (|) operatörü kullanarak birden fazla değeri birleştirme örneği

**Öğrenilen Konular:**
- Enum tanımlama ve kullanımı
- Flags attribute ile bitwise operasyonlar
- Enum değerlerini birleştirme (|) operatörü
- Switch-case yapısı ile enum kontrolü

#### 1.2 Overview (Genel Bakış)
Temel veri tipi kavramlarını ve aritmetik overflow kontrolünü gösteren örnekler içerir.

**Proje İçeriği:**
- **Program.cs**:
  - `checked` anahtar kelimesi kullanımı
  - Integer overflow kontrolü ve exception handling
  - `OverflowException` yakalama
  - Custom exception fırlatma (`ArgumentException`)

**Öğrenilen Konular:**
- Checked context (taşma kontrolü) kullanımı
- Integer overflow durumlarını yakalama
- Try-catch-throw exception handling pattern'i
- Number literal formatı (2_147_483_647 gibi okunabilir sayı formatı)

---

### 2. OperatorOverloading (Operatör Aşırı Yükleme)

C#'ta özel sınıflar için operatör aşırı yükleme (operator overloading) konusunu ele alan proje.

**Proje İçeriği:**
- **CartItem.cs**: Alışveriş sepeti ürün sınıfı
  - ProductId, Quantity ve Price özellikleri
  - **+ operatörü aşırı yükleme**: İki CartItem'ın toplam fiyatını hesaplar
    ```csharp
    public static decimal operator +(CartItem left, CartItem right)
    ```
  - **- operatörü aşırı yükleme**: İki CartItem arasındaki fiyat farkını hesaplar
  - **Karışık tip operatör**: decimal + CartItem işlemi için overload
    ```csharp
    public static decimal operator +(decimal left, CartItem right)
    ```

- **Program.cs**:
  - CartItem örnekleri oluşturma
  - Operatör aşırı yükleme ile iki ürünün toplam fiyatını hesaplama
  - Döngü içinde implicit conversion kullanarak toplam hesaplama
  - Foreach döngüsü ile liste elemanlarını işleme

**Öğrenilen Konular:**
- Operator overloading (operatör aşırı yükleme) kavramı
- `+` ve `-` operatörlerini override etme
- Static operatör metodu tanımlama
- İki farklı tip için operatör tanımlama (decimal + CartItem)
- Implicit type conversion kullanımı
- Business logic'i operatörlere entegre etme (fiyat * miktar hesaplama)

---

### 3. usingRecordTypes (Record Types - Kayıt Tipleri)

Bu klasör, C# 9.0 ile gelen record (kayıt) tiplerinin kullanımını ve class'larla karşılaştırmasını içerir.

**Proje İçeriği:**
- **Product.cs**: Klasik class yapısı
  - `Equals()` metodu override edilmiş
  - `GetHashCode()` metodu override edilmiş
  - `==` ve `!=` operatörleri aşırı yüklenmiş (operator overloading)
  - Değer karşılaştırması için manuel implementasyon

- **Person.cs**: Record type örneği
  - Basit record tanımı (id, name, address özellikleri)
  - Otomatik değer bazlı eşitlik (value-based equality)
  - Compile-time'da otomatik Equals, GetHashCode ve ToString implementasyonu

- **RegisterUserRequestClass.cs**: Class ile immutable yapı
  - Constructor ile değer atama
  - `init` accessor kullanımı (sadece initialization sırasında atama)
  - Android app kullanıcı kayıt isteği senaryosu

- **RegisterUserRequestRecord.cs**: Record ile immutable yapı
  - Tek satırda positional record tanımı
  - Otomatik primary constructor
  - Daha temiz ve okunabilir syntax

- **Program.cs**:
  - Product class nesnelerinin karşılaştırılması (`==` operatörü)
  - Record nesnelerinin otomatik değer karşılaştırması
  - Class vs Record eşitlik kontrolü farklılıkları
  - Immutable nesne oluşturma örnekleri

**Öğrenilen Konular:**
- Record type tanımlama ve kullanımı (C# 9.0+)
- Positional records (tek satır record tanımı)
- Value-based equality (değer bazlı eşitlik) kavramı
- Class vs Record farklılıkları
- `init` accessor ile immutability (değiştirilemezlik)
- Otomatik Equals, GetHashCode implementasyonu
- Primary constructor kullanımı
- DTO (Data Transfer Object) senaryolarında record kullanımı

**Record Avantajları:**
- Daha az kod (boilerplate code azalması)
- Otomatik değer bazlı eşitlik
- Immutable (değiştirilemez) yapı
- With-expressions desteği (yeni kopyalar oluşturma)
- Deconstruction desteği

---

### 4. usingTuples (Tuple Types - Çoklu Değer Döndürme)

Bu klasör, fonksiyonlardan birden fazla değer döndürme yöntemlerini ve Tuple kullanımını içerir.

**Proje İçeriği:**
- **DivisionOutput.cs**: Özel çıktı sınıfı
  - Bölme işlemi sonucu için Result ve Modulo özellikleri
  - Klasik yaklaşım (class ile birden fazla değer döndürme)

- **Program.cs**: Farklı döndürme yöntemleri karşılaştırması
  - **Yöntem 1 - Out parametresi**: `bolme1(int, int, out int)`
    - Klasik C# yaklaşımı
    - Out parametresi ile kalan değer
    - Return ile bölüm değeri

  - **Yöntem 2 - Özel sınıf**: `DivisionOutput bolme2(int, int)`
    - Custom class ile wrapper
    - Tip güvenli yaklaşım
    - Property isimlendirme avantajı

  - **Yöntem 3 - Tuple<T1,T2>**: `Tuple<int,int> bolme3(int, int)`
    - .NET Framework'den gelen Tuple sınıfı
    - `Tuple.Create()` factory metodu
    - Item1, Item2 ile erişim (isimsiz)

  - **Yöntem 4 - ValueTuple**: `(int, int) bolme4(int, int)`
    - C# 7.0+ özelliği
    - Named tuple elements (isimlendirilmiş elemanlar)
    - Deconstruction (açma) desteği
    - Lightweight (hafif) struct tabanlı

  - **Tuple deconstruction örnekleri**:
    - `(int sonBolum, int sonKalan) = bolme4(13, 2);`
    - `(string name, int age) = ("Türkay", 46);`

**Öğrenilen Konular:**
- Out parametresi kullanımı
- Custom class ile birden fazla değer döndürme
- Tuple<T1, T2> sınıfı (referans tipi)
- ValueTuple (değer tipi) - C# 7.0+
- Named tuple elements (isimlendirilmiş tuple elemanları)
- Tuple deconstruction (tuple açma)
- Farklı yaklaşımların performans ve okunabilirlik karşılaştırması

**ValueTuple Avantajları:**
- Value type (struct) - daha performanslı
- Named members (isimlendirilmiş elemanlar)
- Deconstruction syntax desteği
- Daha okunabilir kod
- Geçici veri transfer işlemleri için ideal

---

### 5. GenericDetails (Generic Types - Jenerik Tipler)

Bu klasör, C#'ta generic (jenerik) tip kullanımı, ko-varyans/kontra-varyans kavramları ve generic kısıtlamaları içeren örnekleri barındırır.

**Proje İçeriği:**
- **Point.cs**: Generic tip ihtiyacının ortaya çıkışını gösteren evrimsel yaklaşım
  - `Point` → `PointDouble` → `PointObject` → `PointGeneric<T>` sıralamasıyla tip güvenliği problemi ve çözümü
  - `where T: struct, INumber<T>` constraint ile generic aritmetik işlemler

- **Musician.cs**: Kalıtım hiyerarşisi ile polimorfizm ve varyans kavramına giriş
  - `Guitar` (base) → `ElectricGuitar` (derived) ilişkisi
  - Derived tipin base tip parametresine geçirilebilmesi (polimorfik davranış)

- **Product.cs**: Generic varyans ve karşılaştırma arayüzleri
  - `IComparable<Product>` implementasyonu ile nesneler arası sıralama
  - `ICoVariance<out T>`: Ko-varyans — generic tipin yalnızca çıkış (return) pozisyonunda kullanımı
  - `IContraVariance<in T>`: Kontra-varyans — generic tipin yalnızca giriş (parametre) pozisyonunda kullanımı
  - `GuitarImplementation<T>`: Ko-varyant interface'in somut implementasyonu

- **Program.cs**: Tüm kavramların pratikte birleştirilmesi
  - Boxing/unboxing sorunu ve generic çözüm karşılaştırması
  - Ko-varyans örneği: `IEnumerable<Guitar> = List<ElectricGuitar>` (derived → base koleksiyon ataması)
  - Kontra-varyans kavramsal açıklama ve kısıtlamaları

**Öğrenilen Konular:**
- Generic type tanımlama ve type constraint'ler (`struct`, `class, new()`, `INumber<T>`)
- Boxing/unboxing performans etkisi ve generic ile çözümü
- **Covariance (Ko-varyans)**: `out` keyword'ü — derived koleksiyonları base koleksiyonlara atama
- **Contravariance (Kontra-varyans)**: `in` keyword'ü — base tipleri derived parametre pozisyonlarında kullanma
- `IComparable<T>` ile özel sıralama mantığı
- Kalıtım ve polimorfizm ile generic varyans ilişkisi

---

### 6. Collections (Koleksiyonlar)

Bu klasör, C#'taki temel koleksiyon yapılarını, özel iterable sınıf oluşturmayı, gözlemlenebilir koleksiyonları ve modern index/range söz dizimini kapsayan örnekler içerir.

**Proje İçeriği:**
- **Student.cs**: Özel iterable sınıf tasarımı
  - `Student` veri sınıfı (Id, Name)
  - `ClassRoom` sınıfı: `IEnumerable<Student>` implementasyonu
  - `yield return` ile lazy evaluation destekli iterator

- **Program.cs**: Farklı koleksiyon türlerinin kullanım senaryoları
  - **List<T>**: Temel generic liste kullanımı ve collection initializer
  - **Queue<T>**: FIFO (First-In-First-Out) yapısı — mail gönderim kuyruğu senaryosu
  - **Stack<T>**: LIFO (Last-In-First-Out) yapısı
  - **ObservableCollection<T>**: Koleksiyon değişikliklerini dinleme
    - `CollectionChanged` event'i ile Add, Remove, Replace, Move, Reset aksiyonlarını yakalama
  - **Index ve Range operatörleri**: `^` (sondan erişim) ve `..` (aralık) kullanımı
  - **LINQ ile sayfalama (pagination)**: `Take(Range)` kullanarak veri sayfalama

**Öğrenilen Konular:**
- `IEnumerable<T>` interface implementasyonu ve `yield return` ile custom iterator yazma
- Queue (kuyruk) ve Stack (yığın) veri yapıları ve kullanım farkları
- `ObservableCollection<T>` ile değişiklik izleme (observer pattern)
- `NotifyCollectionChangedAction` enum değerleri ve event handler yazımı
- C# Index (`^`) ve Range (`..`) operatörleri ile dizi/liste dilimleme
- LINQ `Take(Range)` ile sayfalama (pagination) implementasyonu

---

## 🎯 Eğitimin Amaçları

Bu projeler aşağıdaki ileri seviye C# konularını kapsamaktadır:

1. **Enum Tipleri ve Flags**: Numaralandırma türleri ve birden fazla değer taşıma
2. **Operator Overloading**: Özel tiplerde operatör davranışlarını özelleştirme
3. **Record Types**: Değer bazlı eşitlik ve immutable veri yapıları (C# 9.0+)
4. **Tuple Types**: Birden fazla değer döndürme ve deconstruction
5. **Generic Types**: Tip güvenli kod yazma, covariance/contravariance ve IComparable
6. **Collections**: Koleksiyon yapıları, custom iterator, ObservableCollection ve Index/Range
7. **Exception Handling**: Hata yönetimi ve özel exception'lar
8. **Checked Context**: Aritmetik taşma kontrolü
9. **Type Safety**: Tip güvenliği ve implicit/explicit conversions

## 🛠️ Teknik Detaylar

- **Framework**: .NET 10.0
- **C# Versiyonu**: 14.0
- **IDE**: Microsoft Visual Studio Community 2026 (18.4.1)
- **Nullable**: Enable
- **Implicit Usings**: Enable

## 📖 Kullanım

Her proje bağımsız olarak çalıştırılabilir. İlgili proje klasörüne gidin ve aşağıdaki komutu çalıştırın:

```bash
dotnet run
```

## 🎓 Hedef Kitle

Bu projeler, C# programlama dilinde temel bilgiye sahip ve ileri seviye konuları öğrenmek isteyen geliştiriciler için tasarlanmıştır.

## 📝 Notlar

- Her proje, ilgili konuyu pratik örneklerle açıklamaktadır
- Kod örnekleri Türkçe açıklamalar ve değişken isimleri içermektedir
- Projeler, gerçek dünya senaryolarına yakın örnekler kullanmaktadır (Örn: Alışveriş sepeti, Öğrenci yönetimi)

---

**Geliştirici Notları:**
- OperatorOverloading projesinde, implicit conversion sayesinde `total += item` gibi kullanımlar mümkündür
- EnumTypes projesinde, Flags enum kullanımında toplam değerlere (örn: 6) sahip elemanlar tanımlanmamalıdır çünkü bu kombinasyonlara karşılık gelir
- Overview projesinde, int maksimum değeri (2,147,483,647) örnek olarak kullanılmıştır
- GenericDetails projesinde, `out` keyword'ü ko-varyans (sadece return), `in` keyword'ü kontra-varyans (sadece parametre) pozisyonunda kullanılır
- GenericDetails projesinde, INumber<T> constraint kullanımı sayesinde generic tip üzerinde doğrudan aritmetik işlemler (+, -, *, / vb.) yapılabilir
- Collections projesinde, `IEnumerable<T>` implementasyonu ve `yield return` ile lazy evaluation sağlanmaktadır
- Collections projesinde, `ObservableCollection<T>` ile koleksiyon değişiklikleri event-driven olarak izlenebilir
- Collections projesinde, C# Index (`^`) ve Range (`..`) operatörleri ile `Take(Range)` sayfalama için kullanılmıştır
- usingRecordTypes projesinde, record'lar otomatik olarak değer bazlı eşitlik kontrolü yapar; class'larda manuel implementasyon gerekir
- usingTuples projesinde, ValueTuple (C# 7.0+) kullanımı Tuple<T1,T2>'ye göre daha performanslıdır çünkü value type'dır ve stack'te saklanır

## 📞 İletişim

GitHub Repository: [https://github.com/turkayurkmez/pupilica-ileri-csharp-2026](https://github.com/turkayurkmez/pupilica-ileri-csharp-2026)
