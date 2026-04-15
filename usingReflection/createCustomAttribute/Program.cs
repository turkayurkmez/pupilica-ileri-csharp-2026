using createCustomAttribute.Models;
using createCustomAttribute.Validation;

Console.WriteLine("Hello, World!");
User user1 = new User()
{
    UserName = "abc",
    Age = 46
};




var result =Validator.Validate(user1);
if (!result.IsValid)
{
    Console.WriteLine(string.Join("\n",result.Errors));
}
else
{
    Console.WriteLine("Her şey olunda");
}

var user2 = new User() { UserName = "ac", Age = 19 };
var user3 = new User() { UserName = "acd", Age = 19 };

var all = AggregateValidator.ValidateAll(user2, user3);
foreach (var (typeName, typeResult) in all)
{
    Console.WriteLine($"[{typeName}] - {(typeResult.IsValid ? "Geçerli" : "Geçersiz")}" );
    typeResult.Errors.ForEach(e => Console.WriteLine($"     {e}"));
}




