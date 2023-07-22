string fruitCountAsString = Console.ReadLine()!;

if (int.TryParse(fruitCountAsString, out int fruitCount))
{
    Console.Write(fruitCount / 2 / 3);
}