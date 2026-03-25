using System.Collections.Concurrent;
using usingTuples;

Console.WriteLine("Hello, World!");
//PROBLEM: İki sayıyı birbirine böldükten sonra hem sonucu hem de kalan değeri elde etmek istiyorum. Buna göre bir fonksiyon yazın:

int bolme1(int sayi1, int sayi2, out int kalan)
{
    kalan = sayi1 % sayi2;
    return sayi1 / sayi2;
}

int kalanDegeri = 0;
var sonuc = bolme1(13, 2, out kalanDegeri);
Console.WriteLine($"bölme sonucu: {sonuc}, kalan ise {kalanDegeri}");

DivisionOutput bolme2(int number1, int number2)
{
    return new DivisionOutput
    {
        Result = number1 / number2,
        Modulo = number1 % number2
    };
}

var output1 = bolme2(13, 2);

Console.WriteLine($"Böüm: {output1.Result} Kalan: {output1.Modulo}");

Tuple<int,int> bolme3(int number1, int number2)
{
    return Tuple.Create(number1 / number2, number1 % number2);
}

var tuple1 = bolme3(13, 2);
Console.WriteLine($"Bölüm: {tuple1.Item1} Kalan: {tuple1.Item2}");

(int kalan, int sonuc) bolme4(int number1, int number2)
{
    return (number1 / number2, number1 % number2);
}

(int sonBolum, int sonKalan) = bolme4(13, 2);
(int a, int b) = bolme3(13, 2);

Console.WriteLine($"Bölüm: {sonBolum}, kalan: {sonKalan}");

(string name, int age) = ("Türkay", 46);

Console.WriteLine(name);
Console.WriteLine(age);
