# Reflection Kullanımı

Bu klasör, C# dilinde **Reflection** mekanizmasının temel kullanımını ele alan projeleri içerir.

## Projeler

### introReflection
Reflection API'sine giriş niteliğinde bir konsol uygulamasıdır.

## Ele Alınan Konular

- **Reflection nedir?** — Çalışma zamanında (runtime) bir tipin meta verilerine erişim sağlama kavramı.
- **`Type` sınıfı** — `GetType()` metodu ile bir nesnenin tip bilgisine ulaşma.
- **Tip meta verileri** — Tip adı (`Name`), ad alanı (`Namespace`) ve assembly bilgisine erişim.
- **Metot keşfi** — `GetMethods()` ile bir tipe ait tüm metotların listelenmesi; dönüş tipi, metot adı ve parametre bilgilerinin okunması.
- **Özellik (Property) keşfi** — `GetProperties()` ile bir tipe ait özelliklerin listelenmesi.
- **Çalışma zamanında değer okuma** — `PropertyInfo.GetValue()` ile bir nesnenin özellik değerlerinin dinamik olarak elde edilmesi.
- **LINQ ile Reflection verisi biçimlendirme** — `Select` ve `string.Join` kullanarak parametre listelerinin okunabilir biçimde yazdırılması.

## Öğrenme Çıktıları

Bu projeyi tamamladığınızda:

1. `System.Reflection` ad alanının temel sınıflarını (`Type`, `MethodInfo`, `PropertyInfo`, `ParameterInfo`) tanıyabileceksiniz.
2. Herhangi bir nesnenin tipini çalışma zamanında inceleyebilecek ve meta verilerini listeleyebileceksiniz.
3. Bir tipin metotlarını, parametrelerini ve dönüş tiplerini dinamik olarak keşfedebileceksiniz.
4. Bir nesnenin özellik adlarını, tiplerini ve güncel değerlerini Reflection aracılığıyla okuyabileceksiniz.
5. Reflection'ın kullanım alanlarını (serialization, dependency injection, ORM, test framework'leri vb.) kavrayabileceksiniz.
