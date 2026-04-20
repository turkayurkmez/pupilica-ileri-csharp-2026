# Dynamic ve DLR (Dynamic Language Runtime)

## 📌 Proje Hakkında

Bu proje, C# dilindeki `dynamic` anahtar kelimesi ve DLR (Dynamic Language Runtime) kavramlarını örneklerle açıklamaktadır. .NET 10 hedeflenerek geliştirilmiştir.

## 🎯 Öğrenme Çıktıları

Bu projeyi tamamladığınızda aşağıdaki konularda bilgi sahibi olacaksınız:

1. `dynamic` anahtar kelimesinin ne olduğunu ve nasıl çalıştığını açıklayabileceksiniz.
2. Derleme zamanı (compile-time) ile çalışma zamanı (runtime) tür denetimi arasındaki farkı anlayacaksınız.
3. `dynamic` türündeki değişkenlere farklı türlerde değer atanabileceğini kavrayacaksınız.
4. JSON verilerini `dynamic` nesneler olarak deserialize edebileceksiniz.
5. DLR altyapısının .NET içindeki rolünü anlayacaksınız.

## 📚 Bahsedilen Kavramlar

| Kavram | Açıklama |
|---|---|
| **dynamic** | Derleme zamanında tür denetimi yapılmayan, çalışma zamanında çözümlenen tür |
| **DLR (Dynamic Language Runtime)** | .NET üzerinde dinamik dil desteği sağlayan çalışma zamanı altyapısı |
| **Late Binding (Geç Bağlama)** | Tür ve üye çözümlemenin çalışma zamanına ertelenmesi |
| **JSON Deserialization** | JSON formatındaki verinin nesneye dönüştürülmesi |
| **Newtonsoft.Json** | JSON işlemleri için yaygın kullanılan üçüncü parti kütüphane |
| **Anonim Tipler (Anonymous Types)** | İsimsiz, derleyici tarafından oluşturulan türler |
| **Raw String Literals** | C# 11+ ile gelen çok satırlı string tanımlama söz dizimi (`"""`) |
| **Compile-time vs Runtime** | Derleme zamanı ile çalışma zamanı arasındaki fark |

## 🛠️ Kullanılan Teknolojiler

- .NET 10
- C#
- Newtonsoft.Json
