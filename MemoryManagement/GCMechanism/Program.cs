using GCMechanism;

Console.WriteLine("Hello, World!");
GCMonitoring.ReportGCStatus();

GCMonitoring.MeasureGCPressure(heapBomb, "Heap Bombalama fonksiyonu");

GCMonitoring.ReportGCStatus();
void heapBomb()
{
    object o = new object();
    o = "Naber?";
    var total = GC.GetTotalMemory(true);
    
    Console.WriteLine(total.ToString("N0"));
}

using MemoryStream memoryStream = new MemoryStream();
using FileStream fs = new FileStream("ab.txt", FileMode.OpenOrCreate);

using (FileStream eskiFs = new FileStream("abc.docx", FileMode.CreateNew))
{

}
