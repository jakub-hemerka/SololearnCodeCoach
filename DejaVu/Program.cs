string text = Console.ReadLine()!;

if (text.Length == text.Distinct().Count())
{
    Console.Write("Unique");
    return;
}

Console.Write("Deja Vu");