string candlesAsString = Console.ReadLine()!;

if (int.TryParse(candlesAsString, out int amount))
{
    Console.Write((amount + 1) * 9);
}