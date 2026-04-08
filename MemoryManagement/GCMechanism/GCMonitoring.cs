using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime;
using System.Text;

namespace GCMechanism
{
    public static class GCMonitoring
    {
        public static void ReportGCStatus()
        {
            Console.WriteLine("------------ GC Durum Raporu --------------");
            //1. Collection count:
            Console.WriteLine($"Gen0 collections: {GC.CollectionCount(0)} ");
            Console.WriteLine($"Gen1 collections: {GC.CollectionCount(1)} ");
            Console.WriteLine($"Gen2 collections: {GC.CollectionCount(2)} ");
            Console.WriteLine($"Gen3 collections: {GC.CollectionCount(3)} ");
            Console.WriteLine($"Gen4 collections: {GC.CollectionCount(4)} ");

            //2. Bellek kullanımı:
            var totalMemory = GC.GetTotalMemory(false);
            Console.WriteLine($"Toplam bellek kullanımı: {totalMemory:N0} byte");

            //3. GC mode denetimi:
            Console.WriteLine($"GC Modu:{(GCSettings.IsServerGC ? "Server":"Workstation")}");

            //4. Latency Mode:
            Console.WriteLine($"GC Gecikme Modu:{(GCSettings.LatencyMode)}");

            //5. Memory Pressure:
            Console.WriteLine($"Toplam Uygun Bellek: {GC.GetTotalAllocatedBytes():N0} ");
        }

        public static void MeasureGCPressure(Action testAction, string testName)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            var startMemory = GC.GetTotalMemory(false);
            int startGen0 = GC.CollectionCount(0);
            int startGen1 = GC.CollectionCount(1);
            int startGen2 = GC.CollectionCount(2);

            var stopWatch = Stopwatch.StartNew();
            testAction();
            stopWatch.Stop();

            var endMemory = GC.GetTotalMemory(false);
            int endGen0 = GC.CollectionCount(0);
            int endGen1 = GC.CollectionCount(1);
            int endGen2 = GC.CollectionCount(2);

            Console.WriteLine($"----- {testName} sonuçları ------ ");

            Console.WriteLine($"Çalışma süresi:{stopWatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Bellek değişimi: {endMemory - startMemory}");
            Console.WriteLine($"Gen0 koleksiyonu: {endGen0 - startGen0}");
            Console.WriteLine($"Gen1 koleksiyonu: {endGen1 - startGen1}");
            Console.WriteLine($"Gen2 koleksiyonu: {endGen2 - startGen2}");


        }
    }
}
