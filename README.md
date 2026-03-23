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

## 🎯 Eğitimin Amaçları

Bu projeler aşağıdaki ileri seviye C# konularını kapsamaktadır:

1. **Enum Tipleri ve Flags**: Numaralandırma türleri ve birden fazla değer taşıma
2. **Operator Overloading**: Özel tiplerde operatör davranışlarını özelleştirme
3. **Exception Handling**: Hata yönetimi ve özel exception'lar
4. **Checked Context**: Aritmetik taşma kontrolü
5. **Type Safety**: Tip güvenliği ve implicit/explicit conversions

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

## 📞 İletişim

GitHub Repository: [https://github.com/turkayurkmez/pupilica-ileri-csharp-2026](https://github.com/turkayurkmez/pupilica-ileri-csharp-2026)
