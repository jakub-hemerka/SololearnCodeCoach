string itemsBoughtAsString = Console.ReadLine()!;
decimal price = 0;

if (int.TryParse(itemsBoughtAsString, out int itemsBought))
{
    price = itemsBought * 5;

	if (itemsBought > 1)
	{
		price *= 0.90M;
	}

	Console.Write(price * 1.07M);
}