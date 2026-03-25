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

Bu klasör, C#'ta generic (jenerik) tip kullanımı ve detaylarını içeren örnekleri barındırır.

**Proje İçeriği:**
- **Point.cs**: Farklı yaklaşımlarla koordinat sistemi sınıfları
  - **Point**: int tipinde X ve Y koordinatları
  - **PointDouble**: double tipinde X ve Y koordinatları  
  - **PointObject**: object tipinde X ve Y koordinatları (boxing/unboxing)
  - **PointGeneric<T>**: Generic tip ile esnek koordinat sınıfı
    - Generic type constraint: `where T: struct, INumber<T>`
    - **Metodlar**:
      - `Reset()`: Koordinatları default değerine sıfırlar
      - `GetTotal()`: X + Y toplamını döndürür (generic tip üzerinde aritmetik işlem)

**Öğrenilen Konular:**
- Generic type (jenerik tip) tanımlama ve kullanımı
- Generic type constraints (kısıtlamalar):
  - `struct` constraint: Value type zorunluluğu
  - `INumber<T>` interface constraint: Sayısal işlemler için .NET 7+ özelliği
- Generic metodlarda aritmetik operatörler kullanımı
- Default değer atamaları (`default(T)`)
- Type-safe kod yazma avantajları
- Boxing/unboxing'den kaçınma (performance)

**Teknik Detaylar:**
- C# 14.0 özellikleri kullanılmıştır
- .NET 10 framework
- System.Numerics namespace (INumber<T> için)

---

## 🎯 Eğitimin Amaçları

Bu projeler aşağıdaki ileri seviye C# konularını kapsamaktadır:

1. **Enum Tipleri ve Flags**: Numaralandırma türleri ve birden fazla değer taşıma
2. **Operator Overloading**: Özel tiplerde operatör davranışlarını özelleştirme
3. **Record Types**: Değer bazlı eşitlik ve immutable veri yapıları (C# 9.0+)
4. **Tuple Types**: Birden fazla değer döndürme ve deconstruction
5. **Generic Types**: Tip güvenli, yeniden kullanılabilir ve performanslı kod yazma
6. **Exception Handling**: Hata yönetimi ve özel exception'lar
7. **Checked Context**: Aritmetik taşma kontrolü
8. **Type Safety**: Tip güvenliği ve implicit/explicit conversions

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
- GenericDetails projesinde, INumber<T> constraint kullanımı sayesinde generic tip üzerinde doğrudan aritmetik işlemler (+, -, *, / vb.) yapılabilir
- usingRecordTypes projesinde, record'lar otomatik olarak değer bazlı eşitlik kontrolü yapar; class'larda manuel implementasyon gerekir
- usingTuples projesinde, ValueTuple (C# 7.0+) kullanımı Tuple<T1,T2>'ye göre daha performanslıdır çünkü value type'dır ve stack'te saklanır

## 📞 İletişim

GitHub Repository: [https://github.com/turkayurkmez/pupilica-ileri-csharp-2026](https://github.com/turkayurkmez/pupilica-ileri-csharp-2026)
