string craftsSoldAsString = Console.ReadLine()!;

if (int.TryParse(craftsSoldAsString, out int craftsSold))
{
    int outcome = 21000000;
    int income = craftsSold * 3000000;

    if (outcome > income)
    {
        Console.Write("Loss");
        return;
    }

    if (outcome < income)
    {
        Console.Write("Profit");
        return;
    }

    Console.Write("Broke Even");
}