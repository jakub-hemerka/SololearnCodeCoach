if (!int.TryParse(Console.ReadLine()!, out int number))
{
    return;
}

string[] numbers = Console.ReadLine()!.Split(' ');
foreach (string item in numbers)
{
    if (!int.TryParse(item, out int x) || number % x != 0)
    {
        Console.Write("not divisible by all");
        return;
    }
}

Console.Write("divisible by all");