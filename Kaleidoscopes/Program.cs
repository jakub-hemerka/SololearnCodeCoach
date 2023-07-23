string itemsBoughtAsString = Console.ReadLine()!;
double price = 0;

if (int.TryParse(itemsBoughtAsString, out int itemsBought))
{
    price = itemsBought * 5;

	if (itemsBought > 1)
	{
		price *= 0.90;
	}

	Console.Write(Math.Round(price * 1.07, 2, MidpointRounding.AwayFromZero));
}