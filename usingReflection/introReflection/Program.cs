using System.Reflection;

Console.WriteLine("Hello, World!");

void showDetails(Product product)
{

    var type = product.GetType();
    Console.WriteLine($"Tip adı:        {type.Name}");
    Console.WriteLine($"Namespace adı:        {type.Namespace}");
    Console.WriteLine($"Assembly adı:        {type.Assembly.GetName().Name}");

    foreach (var method in type.GetMethods())
    {
        Console.WriteLine($"{method.ReturnType.Name} {method.Name}({string.Join(',',
            method.GetParameters().Select(x=> x.ParameterType.Name + " " + x.Name))})");


           

    }

    foreach (var property in type.GetProperties())
    {
        var value = property.GetValue(product);
        Console.WriteLine($" {property.Name} ({property.PropertyType.Name})={value}");
    }




}

string course = "Pupilica";
var product = new Product() { Id=1, Name="Ürün A", Price=100};


showDetails(product);


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

}