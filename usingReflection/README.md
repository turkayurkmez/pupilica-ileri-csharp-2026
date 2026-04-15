# Reflection Kullanımı

Bu klasör, C# dilinde **Reflection** mekanizmasının temellerinden özel attribute tabanlı doğrulama (validation) sistemine uzanan iki aşamalı bir öğrenme yolculuğu sunar.

---

## Projeler

### 1. introReflection — Reflection'a Giriş

Reflection API'sine giriş niteliğinde bir konsol uygulamasıdır. Bir nesnenin tipini çalışma zamanında inceleyerek meta verilerini, metotlarını ve özellik değerlerini ekrana yazdırır.

#### Ele Alınan Konular

- **Reflection nedir?** — Çalışma zamanında (runtime) bir tipin meta verilerine erişim sağlama kavramı.
- **`Type` sınıfı** — `GetType()` metodu ile bir nesnenin tip bilgisine ulaşma.
- **Tip meta verileri** — Tip adı (`Name`), ad alanı (`Namespace`) ve assembly bilgisine erişim.
- **Metot keşfi** — `GetMethods()` ile bir tipe ait tüm metotların listelenmesi; dönüş tipi, metot adı ve parametre bilgilerinin okunması.
- **Özellik (Property) keşfi** — `GetProperties()` ile bir tipe ait özelliklerin listelenmesi.
- **Çalışma zamanında değer okuma** — `PropertyInfo.GetValue()` ile bir nesnenin özellik değerlerinin dinamik olarak elde edilmesi.
- **LINQ ile Reflection verisi biçimlendirme** — `Select` ve `string.Join` kullanarak parametre listelerinin okunabilir biçimde yazdırılması.

#### Öğrenme Çıktıları

1. `System.Reflection` ad alanının temel sınıflarını (`Type`, `MethodInfo`, `PropertyInfo`, `ParameterInfo`) tanıyabileceksiniz.
2. Herhangi bir nesnenin tipini çalışma zamanında inceleyebilecek ve meta verilerini listeleyebileceksiniz.
3. Bir tipin metotlarını, parametrelerini ve dönüş tiplerini dinamik olarak keşfedebileceksiniz.
4. Bir nesnenin özellik adlarını, tiplerini ve güncel değerlerini Reflection aracılığıyla okuyabileceksiniz.

---

### 2. createCustomAttribute — Özel Attribute ve Doğrulama Sistemi

Reflection bilgisini bir adım öteye taşıyarak, sıfırdan **özel attribute'ler** tanımlayıp bunları çalışma zamanında okuyan ve modelleri doğrulayan (validate eden) bir mini framework oluşturur.

#### Yöntem (Mimari Yaklaşım)

Proje üç katmanlı bir yapı izler:

1. **Attribute Katmanı** (`Attributes/`) — Doğrulama kurallarını temsil eden özel attribute sınıfları tanımlanır. Her biri `System.Attribute`'ten türer ve `[AttributeUsage(AttributeTargets.Property)]` ile yalnızca özelliklere uygulanacak şekilde kısıtlanır.
2. **Model Katmanı** (`Models/`) — İş nesneleri (ör. `User`) tanımlanır; özelliklerine attribute'ler dekoratör olarak eklenir. Böylece doğrulama kuralları modelin kendisinde, bildirimsel (declarative) olarak ifade edilir.
3. **Doğrulama Katmanı** (`Validation/`) — Reflection ile modelin özelliklerini tarayan, üzerlerindeki attribute'leri okuyan ve kurallara göre hata listesi üreten genel amaçlı (generic) bir doğrulayıcı içerir.

Bu yapı sayesinde yeni bir doğrulama kuralı eklemek için yalnızca yeni bir attribute sınıfı yazmak ve `Validator` içine ilgili kontrolü eklemek yeterlidir; model sınıfları ve çağıran kod değişmez.

#### Ele Alınan Konular

- **Özel Attribute tanımlama** — `System.Attribute`'ten türeyen sınıflar oluşturma; constructor parametreleri ve varsayılan değerlerle yapılandırma.
- **`AttributeUsage` ile kapsam kısıtlama** — Bir attribute'ün yalnızca belirli hedeflere (property, class vb.) uygulanmasını zorunlu kılma.
- **Üç farklı doğrulama attribute'ü**:
  - `MyRequired` — Bir özelliğin boş (`null`) veya yalnızca boşluk karakteri olmamasını zorunlu kılar.
  - `MyMinLength` — Metin özelliklerinin belirtilen minimum karakter uzunluğunu karşılamasını denetler.
  - `MyRange` — Sayısal özelliklerin belirtilen alt ve üst sınırlar arasında olmasını denetler.
- **`GetCustomAttribute<T>()` ile attribute okuma** — Bir özellik üzerindeki belirli bir attribute'ün varlığını ve değerlerini çalışma zamanında sorgulama.
- **Pattern matching ile attribute kontrolü** — `is { } variable` deseniyle null kontrolü ve değişken atamasının tek satırda yapılması.
- **Generic doğrulayıcı (`Validator.Validate<T>`)** — Tip bağımsız çalışan, herhangi bir sınıfı attribute'lerine göre doğrulayan generic bir statik metot tasarlama.
- **`ValidationResult` modeli** — Hata listesini tutan ve `IsValid` özelliğini hesaplanan (computed) olarak sunan basit bir sonuç nesnesi.
- **Toplu doğrulama (`AggregateValidator`)** — `ReadOnlySpan<object>` ile birden fazla nesneyi tek çağrıda doğrulama.
- **`MakeGenericMethod` ile runtime'da generic metot çağrısı** — Derleme zamanında bilinmeyen bir tip için Reflection aracılığıyla generic metodu somutlaştırıp çalıştırma.

#### Öğrenme Çıktıları

1. `System.Attribute` temel sınıfından türeterek kendi özel attribute'lerinizi tasarlayabileceksiniz.
2. `AttributeUsage` ile bir attribute'ün hangi kod öğelerine uygulanabileceğini kontrol edebileceksiniz.
3. `GetCustomAttribute<T>()` kullanarak çalışma zamanında bir özellik üzerindeki attribute'leri okuyabilecek ve değerlerine erişebileceksiniz.
4. Reflection ve generic'leri birlikte kullanarak tip bağımsız bir doğrulama mekanizması kurabileceksiniz.
5. `MakeGenericMethod` ile derleme zamanında bilinmeyen tipler için generic metotları dinamik olarak çağırabileceksiniz.
6. Bildirimsel (declarative) programlama yaklaşımıyla, doğrulama mantığını iş mantığından ayıran temiz bir mimari oluşturabileceksiniz.
