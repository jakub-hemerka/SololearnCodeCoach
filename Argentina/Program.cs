string priceInPesosAsString = Console.ReadLine()!;
string priceInDollarsAsString = Console.ReadLine()!;

if (int.TryParse(priceInPesosAsString, out int priceInPesos) && int.TryParse(priceInDollarsAsString, out int priceInDollars))
{
    if (priceInDollars * 50.0 < priceInPesos)
    {
        Console.Write("Dollars");
        return;
    }

    Console.Write("Pesos");
}