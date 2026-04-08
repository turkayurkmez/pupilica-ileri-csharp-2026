# GCMechanism – Garbage Collection Mekanizması

## Proje Hakkında

Bu proje, .NET 10 üzerinde **Garbage Collector (GC)** mekanizmasının nasıl çalıştığını, bellek yönetiminin nasıl izlenebileceğini ve yönetilmeyen kaynakların nasıl temizleneceğini uygulamalı olarak ele almaktadır.

## Ele Alınan Konular

### 1. GC Durum Raporlama (`GCMonitoring.ReportGCStatus`)

- Generation bazında (Gen0 – Gen4) koleksiyon sayılarının `GC.CollectionCount` ile izlenmesi
- `GC.GetTotalMemory` ile anlık toplam bellek kullanımının raporlanması
- `GCSettings.IsServerGC` ile GC modunun (Server / Workstation) belirlenmesi
- `GCSettings.LatencyMode` ile gecikme modunun sorgulanması
- `GC.GetTotalAllocatedBytes` ile toplam tahsis edilen bayt miktarının görüntülenmesi

### 2. GC Baskı (Pressure) Ölçümü (`GCMonitoring.MeasureGCPressure`)

- Test öncesinde `GC.Collect`, `GC.WaitForPendingFinalizers` ile temiz bir başlangıç durumu oluşturma
- `Stopwatch` ile çalışma süresinin ölçülmesi
- Bellek değişiminin (önceki – sonraki) hesaplanması
- Generation bazında (Gen0, Gen1, Gen2) koleksiyon farkının raporlanması
- Herhangi bir `Action` delegesinin GC üzerindeki etkisini ölçebilen genel amaçlı bir test altyapısı

### 3. Heap Bombalama Senaryosu (`Program.cs`)

- Kısa ömürlü nesnelerin heap üzerindeki etkisinin gözlemlenmesi
- `GC.GetTotalMemory(true)` ile zorla toplama sonrası bellek miktarının okunması
- GC durum raporunun test öncesi ve sonrası karşılaştırılması

### 4. IDisposable Deseni ve Kaynak Yönetimi (`FileGenerator`)

- `IDisposable` arayüzünün uygulanması
- Destructor / Finalizer (`~FileGenerator`) yaklaşımı yerine OOP paradigmasına uygun `Dispose` deseninin tercih edilmesi
- `FileStream` gibi yönetilmeyen kaynakların `Close` ve `Dispose` ile serbest bırakılması
- `GC.SuppressFinalize` ile finalizer kuyruğunun atlanarak performans kazanımı sağlanması

## Öğrenme Çıktıları

Bu projeyi tamamladığınızda aşağıdaki kazanımlara sahip olursunuz:

1. .NET Garbage Collector'ın generation tabanlı çalışma mantığını anlama
2. GC koleksiyon sayılarını ve bellek kullanımını programatik olarak izleyebilme
3. Server ve Workstation GC modları arasındaki farkı kavrama
4. Belirli bir kod bloğunun GC üzerindeki baskısını ölçebilme
5. `IDisposable` desenini doğru şekilde uygulayabilme
6. Finalizer ile `Dispose` deseni arasındaki farkı ve `GC.SuppressFinalize` kullanımını bilme
7. Bellek sızıntılarını ve gereksiz GC baskısını tespit edebilme

## Kullanılan Teknolojiler

- **Platform:** .NET 10
- **Dil:** C# 14.0
