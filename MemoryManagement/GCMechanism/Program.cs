using GCMechanism;

Console.WriteLine("Hello, World!");
GCMonitoring.ReportGCStatus();

GCMonitoring.MeasureGCPressure(heapBomb, "Heap Bombalama fonksiyonu");

GCMonitoring.ReportGCStatus();
void heapBomb()
{
    object o = new object();
    var total = GC.GetTotalMemory(true);

    Console.WriteLine(total.ToString("N0"));
}