using ExtensionMethods;
Console.WriteLine("Hello, World!");

int number = 5;
Console.WriteLine(number.GetSquare());
string myMail = "turkay.urkmez";

string result = myMail.IsEmail() ? "emaildir" : "email değildir";
Console.WriteLine($"{myMail}, {result}");


Random random = new Random();
Console.WriteLine(random.NextChar());
Console.WriteLine(random.NextChar(false));

List<string> cities = new() { "Adana", "Afyon", "Ağrı", "Ankara", "İstanbul", "Eskişehir" };
var citiesWithStartA = cities.Where(c => c.StartsWith("A")).ToList();

citiesWithStartA.ForEach(c => Console.WriteLine(c));
