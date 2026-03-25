using usingRecordTypes;

Console.WriteLine("Hello, World!");
Product p1 = new Product() { Id = 1, Name = "ABC", Price = 1 };
Product p2 = new Product() { Id = 1, Name = "ABC", Price = 1 };

if (p1==p2)
{
    Console.WriteLine("Eşittir");
}
else
{
    Console.WriteLine("Eşit değildir");
}

Person person1 = new Person { Id = 1, Name = "Türkay", Address = "Eskişehir" };
Person person2 = new Person { Id = 1, Name = "Türkay", Address = "İstanbul" };

if (person1 == person2)
{
    Console.WriteLine("iki record nesnesi eşittir");
}
else
{
    Console.WriteLine("İki record nesnesi farklıdır");
}

//RegisterUserRequestClass register1 = new RegisterUserRequestClass() { Email = "a@b.com", UserName="user1" };
RegisterUserRequestClass register1 = new RegisterUserRequestClass("a@b.com", "user1");

//register1.Email = "selam@naber.com";


RegisterUserRequestRecord record1 = new RegisterUserRequestRecord("b@email.com", "testUser");


