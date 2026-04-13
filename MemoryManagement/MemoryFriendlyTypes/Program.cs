using System.Diagnostics;

Console.WriteLine("Hello, World!");
string email = "turkay.urkmez@dinamikzihin.com";
string userName = email.Substring(0, email.IndexOf('@'));
string domain = email.Substring(email.IndexOf("@") + 1);

ReadOnlySpan<char> emailSpan = email.AsSpan();
var atIndex = emailSpan.IndexOf("@");
var userNameSpan = emailSpan.Slice(0,atIndex);
Console.WriteLine(userNameSpan);

string[] generateMillionEmails()
{
    string[] emails = new string[1_000_000];
    for (int i = 0; i < emails.Length; i++)
    {
        emails[i] = $"user_{i}@domain_{i}.com";
    }

    return emails;
}

var emails = generateMillionEmails();
var stopWatch = Stopwatch.StartNew();
for (int i = 0; i < emails.Length; i++)
{
    var subUserName = emails[i].Substring(0, emails[i].IndexOf('@'));
}

stopWatch.Stop();
Console.WriteLine($"Substring ile geçen süre: {stopWatch.ElapsedMilliseconds} ms");
stopWatch.Restart();

for (int i = 0; i < emails.Length; i++)
{
    var spanMail = emails[i].AsSpan();
    var spanUserName = spanMail.Slice(0, spanMail.IndexOf('@'));

}

stopWatch.Stop();

Console.WriteLine($"Span<> ile geçen süre: {stopWatch.ElapsedMilliseconds} ms");



stopWatch.Restart();
Span<int> stackNumbers = stackalloc int[100_000];
for (int i = 0; i < stackNumbers.Length; i++)
{
    stackNumbers[i] = i * 2;
}

stopWatch.Stop();
Console.WriteLine($"Span<> ile yüzbin int elemanın stack'de işlem süresi: {stopWatch.ElapsedMilliseconds} ms");

var emailWithAsync = email.AsMemory();


