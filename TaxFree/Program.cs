string[] items = Console.ReadLine()!.Split(',');
decimal total = 0;

foreach (string item in items)
{
    if (!decimal.TryParse(item, out decimal price))
    {
        continue;
    }

    if (price > 20M)
    {
        total += price;
        continue;
    }

    total += price * 1.07M;
}

Console.Write(total);