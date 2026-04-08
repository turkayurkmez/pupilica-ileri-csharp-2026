using PatternMatching;

Console.WriteLine("Hello, World!");







var person = new Person("Ali", "Yalova", "IT", 26);

if (person != null)
{
    if (person.Name == "Ali")
    {
        if (person.City == "Yalova")
        {
            Console.WriteLine("Aradığımızı bulduk!");
        }
    }
}



if (person is { Age: 26, Name: "Ali", City: "Yalova" })
{
    Console.WriteLine($"tek satırda aynı sonuç:{person.Name}");
}


Console.WriteLine(getMovementDirector(5, 3));
Console.WriteLine(getMovementDirector(-5, 3));
Console.WriteLine(getMovementDirector(5, -3));
Console.WriteLine(getMovementDirector(0, 0));






string getMovementDirector(int deltaX, int deltaY) =>
    (deltaX, deltaY) switch
    {
        (0, 0) => "Sabit",
        ( < 0, 0) => "Batı",
        ( > 0, 0) => "Doğu",
        (0, > 0) => "Kuzey",
        (0, < 0) => "Güney",
        ( > 0, > 0) => "Kuzeydoğu",
        ( < 0, > 0) => "Kuzeybatı",
        ( < 0, < 0) => "Güneybatı",
        ( > 0, < 0) => "Güneydoğu"
    };

string getWeatherCondition(Temperature temperature)
{
    return temperature switch
    {
        { Celcius: < -10 } => $"{temperature.City}, çok soğuk!",
        { Celcius: var c } when c < -5 => $"{temperature.City}, buzlanma riski",
        { Celcius: var c } when c >= -5 && c < 5 => $"{temperature.City} şehrinde hava soğuk...",
        { Celcius: var c } when c >= 5 && c < 15 => $"{temperature.City} şehrinde hava fena değil :).."




    };
}

var temparatures = new List<Temperature>()
{
    new("Eskişehir", 10),
    new("Erzurum", -8),
    new("İstanbul", -1),
    new("Ankara", 3),



};


foreach (var item in temparatures)
{
    Console.WriteLine( getWeatherCondition(item));
}


/*
 *  [] => "Boş Array",
                [8] => "Tek elemanlı ve o da 8 değeri",
                [1,2,..]=> "Array 1 ve 2 ile başlıyor....",
                [..,999]=>"999 ile bitiyor!",
                [1,..,9]=>"1 ile başlayıp 9 ile bitiyor",
                [var first,.., var last] => $"bu array, {first} ile başlıyor, {last} ile bitiyor",
 */

var array1 = new int[0];
var array2 = new int[] {1,2,9,16 };
var array3 = new int[] { 9, 16,999 };
var array4 = new int[] { 10, 2, 3, 4, 5, 6, 7, 8, 90 };
var array5 = new int[] { 1, -2, 3, 4, 5, 6, 7, 8, 9 };


Console.WriteLine(ListPatterns.analyseIntArrayModernWay(array1));
Console.WriteLine(ListPatterns.analyseIntArrayModernWay(array2));
Console.WriteLine(ListPatterns.analyseIntArrayModernWay(array3));
Console.WriteLine(ListPatterns.analyseIntArrayModernWay(array4));
Console.WriteLine(ListPatterns.analyseIntArrayModernWay(array5));







public record Person(string Name, string City, string Job, int Age);
public record Temperature(string City, double Celcius);