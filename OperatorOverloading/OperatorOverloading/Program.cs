using OperatorOverloading;

Console.WriteLine("Hello, World!");

CartItem cartItem1 = new CartItem() { ProductId=1, Quantity=5, Price=3};
CartItem cartItem2 = new CartItem() { ProductId = 2, Quantity = 10, Price = 5 };
CartItem cartItem3 = new CartItem() { ProductId = 3, Quantity = 15, Price = 10 };

List<CartItem>cartItems = new List<CartItem> { cartItem1, cartItem2, cartItem3 };

var result = cartItem1 + cartItem2;
Console.WriteLine($"İki ürünün toplam fiyatı:  {result} TL");

decimal total = 0;
foreach (var item in cartItems)
{
    total  += item;
}

Console.WriteLine($"Toplam: {total} TL");