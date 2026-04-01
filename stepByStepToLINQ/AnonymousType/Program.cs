using AnonymousType;

Console.WriteLine("Hello, World!");

var number = 9;
var random = new Random();
var person = new { Name = "Türkay", City = "Eskişehir" };

var products = new List<Product>()
{
    new(){ Id=1, Name="Mouse", Category="Bigisayar", Price=450, Description="Logitech mini mouse "},
    new(){ Id=2, Name="Mouse-1", Category="Bigisayar", Price=650, Description="Logitech mini mouse1"},
    new(){ Id=3, Name="Mouse-2", Category="Bigisayar", Price=4500, Description="Logitech mini mouse2"},
    new(){ Id=4, Name="Mouse-3", Category="Bigisayar", Price=3000, Description="Logitech mini mouse3"},

};

var specialProducts = new List<dynamic>();
//dynamic  sample = "Deneme";
//sample.HadiBunuYap();

foreach (var product  in products)
{
    specialProducts.Add(new { Ad = product.Name, Fiyat = product.Price });
}

foreach (var item in specialProducts)
{
    Console.WriteLine(item.Ad);
}

var output = test();

var justNameAndPriceList = from product  in products
                           where product.Price > 1000
                           select new { UrunAdi= product.Name,  Fiyati = product.Price };

//1970'ler: Yazılım dili, insan diline yakın olmalı:
// Select Name, Price FROM Products WHERE Price > 1000


List<string> test()
{
    return new List<string>() { "Ahmet", "Elif", "Süleyman", "Nurcan" };

}

foreach (var item in justNameAndPriceList)
{
    Console.WriteLine($"Ürün adı: {item.UrunAdi}, Fiyatı: {item.Fiyati}");
}