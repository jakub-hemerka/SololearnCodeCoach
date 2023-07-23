string numberOfCarrotsAsString = Console.ReadLine()!;
string numberOfBoxesAsString = Console.ReadLine()!;

if (int.TryParse(numberOfCarrotsAsString, out int carrots) && int.TryParse(numberOfBoxesAsString, out int boxes))
{
    if (carrots % boxes >= 7)
    {
        Console.Write("Cake Time");
        return;
    }

    Console.Write($"I need to buy {7 - (carrots % boxes)} more");
}