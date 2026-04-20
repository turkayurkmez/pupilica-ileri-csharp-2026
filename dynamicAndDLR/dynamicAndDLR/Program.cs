using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

dynamic value = "test verisi";

value = new Random();
int output = value.Next(1, 10);
Console.WriteLine(output);

value = 8;

value = Math.Pow(value, 2);
Console.WriteLine(value);

dynamic process(string value)
{
    dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(value);

    Console.WriteLine(jsonObject.user.name);

    return new
    {
        UserName = jsonObject.user.name,
        Age = jsonObject.user.age,
        Skills = jsonObject.user.skills,
        Timestamp = jsonObject.user.timestamp,
    };

}



string jsonRequest = """
    {
      "user":{
        "name":"Türkay",
        "age":46,
        "skills":["C#, Java, Python, TS"]

      },
      "timestamp":"2026-04-20"
    }
    """;

dynamic processedJson = process(jsonRequest);
Console.WriteLine($"Serialization gerçekleşti. Gelen veri: {processedJson.UserName}, bildiği diller: {processedJson.Skills}");