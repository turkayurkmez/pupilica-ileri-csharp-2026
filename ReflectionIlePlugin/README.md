# Reflection ile Plugin Mimarisi

.NET 10 ve Windows Forms kullanarak **Reflection** tabanlı bir plugin sistemi oluşturmayı gösteren eğitim projesidir.

## 🎯 Öğrenme Hedefleri

- **Reflection** kavramını anlamak: `Assembly.LoadFile`, `Assembly.GetTypes` ile çalışma zamanında DLL yükleme
- **Plugin mimarisi** tasarlamak: Ortak bir arayüz (SDK) üzerinden gevşek bağlı (loosely coupled) bileşenler oluşturma
- **Interface tabanlı sözleşme** yaklaşımını uygulamak: `IPlugin` arayüzü ile plugin'lerin uyması gereken kontratı tanımlama
- Çalışma zamanında **dinamik nesne oluşturma** (`Activator.CreateInstance`) pratiği yapmak
- **Separation of Concerns** prensibini üç katmanlı proje yapısıyla kavramak

## 🔄 Uygulama Akışı

```
1. Kullanıcı menüden "Plugin Ekle" seçeneğine tıklar
2. Bir klasör seçer (FolderBrowserDialog)
3. Helper sınıfı, seçilen klasördeki .dll dosyalarını tarar
4. Her DLL'deki tipler Reflection ile incelenir
5. IPlugin arayüzünü implemente eden tipler tespit edilir
6. Bulunan plugin'ler menüye dinamik olarak eklenir
7. Kullanıcı bir plugin'e tıkladığında ilgili şekil ekrana çizilir
```

## 🏗️ Proje Yapısı ve Kullanılan Yaklaşım

| Proje | Rol | Açıklama |
|---|---|---|
| **Display.SDK** | Sözleşme (Contract) | `IPlugin` arayüzü, `Plug` modeli ve `Helper` yardımcı sınıfını içerir. Hem uygulama hem plugin'ler bu projeye bağımlıdır. |
| **Display.Library** | Plugin | `Circle` ve `Square` gibi `IPlugin` implementasyonlarını barındırır. Derlenen DLL, çalışma zamanında yüklenir. |
| **Display.Aplplication** | Ana Uygulama (Host) | Windows Forms uygulaması. Plugin'leri keşfeder, menüye ekler ve çizdirme işlemini tetikler. |

### Yaklaşım

- **SDK-first tasarım**: Ortak arayüz ayrı bir projede tanımlanır; plugin geliştiriciler yalnızca SDK'ya referans vererek yeni şekiller ekleyebilir.
- **Dinamik keşif**: Uygulama, plugin DLL'lerini derleme zamanında değil çalışma zamanında yükler — böylece yeni plugin'ler uygulamayı yeniden derlemeden eklenebilir.
- **Handshake deseni**: `Helper` sınıfı, bir tipin `IPlugin` arayüzünü uygulayıp uygulamadığını kontrol ederek güvenli bir "el sıkışma" gerçekleştirir.

## ⚙️ Gereksinimler

- .NET 10 SDK
- Visual Studio 2026 (veya uyumlu bir IDE)

## 🚀 Çalıştırma

1. Solution'ı açın ve **Display.Library** projesini derleyin.
2. **Display.Aplplication** projesini başlatın.
3. Menüden *Plugin Ekle*'yi seçip `Display.Library` çıktı klasörünü gösterin.
4. Eklenen şekillere tıklayarak çizim yapın.
