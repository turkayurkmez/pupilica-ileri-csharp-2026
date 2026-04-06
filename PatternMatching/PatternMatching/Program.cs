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


public record Person(string Name, string City, string Job, int Age);
public record Temperature(string City, double Celcius);