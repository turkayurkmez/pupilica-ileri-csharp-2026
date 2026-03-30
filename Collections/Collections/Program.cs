using Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");
List<string> list = new (){"A","B","C","Ç"};

ClassRoom classRoom  = new ClassRoom();
classRoom.AddStudent(new Student { Id = 1, Name = "Türkay" });
classRoom.AddStudent(new Student { Id = 2, Name = "Enes" });

foreach (var student in classRoom)
{
    Console.WriteLine(student.Name);
}

Queue<string> queue = new Queue<string>();
queue.Enqueue("mail1@example.com");
queue.Enqueue("mail2@example.com");
queue.Enqueue("mail3@example.com");

while (queue.Count > 0)
{
    string sendingMailAddress = queue.Dequeue();
    Console.WriteLine($"mail {sendingMailAddress} adresine gönderildi. Listede bekleyen mail sayısı: {queue.Count}");

}

Stack<string> stack = new Stack<string>();
stack.Push("A");
stack.Push("B");
stack.Push("C");

while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}

ObservableCollection<string> obsevableCollection = new ObservableCollection<string>();
obsevableCollection.CollectionChanged += ObsevableCollection_CollectionChanged;

obsevableCollection.Add("Bunu Ekledim");
obsevableCollection.Add("Şunu Ekledim");
obsevableCollection[0] = "Onu Değiştirdim";
obsevableCollection.Add("A");
obsevableCollection.RemoveAt(0);
var item = obsevableCollection[0];
obsevableCollection[0] = obsevableCollection[1];
obsevableCollection[1] = item;




void ObsevableCollection_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    switch (e.Action)
    {
        case NotifyCollectionChangedAction.Add:
            Console.WriteLine($"Yeni bir eleman eklendi: {e.NewItems[0]}");
            break;
        case NotifyCollectionChangedAction.Remove:
            Console.WriteLine($"Eleman silindi: {e.OldItems[0]}");
            break;
        case NotifyCollectionChangedAction.Replace:
            Console.WriteLine($"Eski değer: {e.OldItems[0]}, {e.NewItems[0]} olarak değişti");
            break;
        case NotifyCollectionChangedAction.Move:
            Console.WriteLine($"{e.OldStartingIndex} indexindeki {e.OldItems[e.OldStartingIndex]} eleman, {e.NewStartingIndex} indexine taşındı ");
            break;
        case NotifyCollectionChangedAction.Reset:
            Console.WriteLine("Resetlendi");
            break;
        default:
            break;
    }


    

}

string[] countries = { "Türkiye", "İspanya", "Kore", "Azerbaycan", "Estonya" };
Console.WriteLine(countries[^1]);
Console.WriteLine(string.Join(",", countries[0..2]));
Console.WriteLine(string.Join(",", countries[..3]));

Console.WriteLine(string.Join(",", list[^3..]));

Console.WriteLine("Hangi sayfa?");
int pageSize = 3;
int pageNo = int.Parse(Console.ReadLine()) ;
int start = (pageNo - 1) * pageSize;
int end = start + pageSize;
countries.Take(start..end)
         .ToList()
         .ForEach(x => Console.WriteLine(x));
