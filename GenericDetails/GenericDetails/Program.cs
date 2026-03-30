using GenericDetails;

Console.WriteLine("Hello, World!");

PointObject po = new PointObject();
po.X = 10;
po.Y = "Yirmi"; //boxing: Kutunun (object) içine at.

//int s = (int)po.Y;//unboxing 

PointGeneric<decimal> pointGeneric = new PointGeneric<decimal>();
pointGeneric.X = 0.1M;
pointGeneric.Y = 0.5M;

Console.WriteLine(pointGeneric.GetTotal());

//PointGeneric<string> pt2 = new PointGeneric<string> ();


ElectricGuitar electricGuitar = new ElectricGuitar();
Guitar classicGuitar = new Guitar ();

Musician musician = new Musician ();
musician.Play(electricGuitar);
musician.Play(classicGuitar);
//eğer dervied tipleri, base tip ile tanımlanmış bir koleksiyona atamak ko-varyanstır
var guitars = new Guitar[] { electricGuitar, classicGuitar };
var egitarArray = new ElectricGuitar[2];
//eğer base tipler ile tanımlanmış bir koleksiyona  derived bir tip eklemek istersem bu kontra-varyanstır.
//egitarArray[0] = new Guitar();

var electricGuitarList = new List<ElectricGuitar>();


IEnumerable<Guitar> baseGuittars = electricGuitarList;
GuitarImplementation<Guitar> guitarsSample = new GuitarImplementation<Guitar>(); 
var electricG = (ElectricGuitar) guitarsSample.GetInstance();
