using LINQShowcase;

Console.WriteLine("Hello, World!");

var products = new ProductService().GetProducts();

Console.WriteLine("............. Tüm veriler ...............");
products.ForEach(p => Console.WriteLine(p));

var nameAndPrice = products.Select(p=> new {p.Name, p.Price})
                           .ToList();

Console.WriteLine("..............Sadece ad ve fiyat......................");
Console.WriteLine(  );
nameAndPrice.ForEach(p => Console.WriteLine(p));

var expensiveProducts = products.Where(p => p.Price > 10000)
                                .Select(p=>new { UrunAdi = p.Name, Fiyat = p.Price})
                                .ToList();

Console.WriteLine("..............10.000 TL'den pahalı ürünler......................");
Console.WriteLine();
expensiveProducts.ForEach(p => Console.WriteLine(p));

Console.WriteLine("............... En pahalı 3 ürün .............");
var topThreeProducts = products.Select(p => new { p.Name, p.Price })
                               .Take(3)
                               .OrderByDescending(p => p.Price)
                               .ToList();

topThreeProducts.ForEach(p => Console.WriteLine(p));

Console.WriteLine("............. id'si 8 olan ürün ....................");
var theProductWithId8 = products.FirstOrDefault(p => p.Id == 16, new Product { Name = "Böyle bir ürün bulunamadı" });
Console.WriteLine(theProductWithId8.Name);

//var onlyOneProduct = products.SingleOrDefault(p => p.Id == 16);
//Console.WriteLine(onlyOneProduct.Name);

var averagePrice = products.Average(p => p.Price);
Console.WriteLine("Fiyat ortalaması....");
Console.WriteLine(averagePrice.ToString("N2") + " TL");

var maxPrice = products.Max(p => p.Price);

var productsWithMaxPrice = products.FirstOrDefault(p => p.Price == maxPrice);
Console.WriteLine(".......... En pahalı ürün .................");
Console.WriteLine(productsWithMaxPrice.Name);

var productWithMinPrice = products.MinBy(p => p.Price);
Console.WriteLine(productWithMinPrice.Name);