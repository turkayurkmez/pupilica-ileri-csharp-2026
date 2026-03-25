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



