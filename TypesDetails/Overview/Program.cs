Console.WriteLine("Hello, World!");



int getTotal(int a, int b)
{
    try
    {
        int result = checked(a + b);
        return result;
    }
    catch (OverflowException)
    {

        throw new ArgumentException("İki sayının toplamı, int kapasitesinin üzerinde!");
    }




}

int total = getTotal(2_147_483_647, 1);
Console.WriteLine($"Değerler toplamı: {total}");
