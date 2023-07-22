string paintCountAsString = Console.ReadLine()!;

if (int.TryParse(paintCountAsString, out int paintCount))
{
    Console.Write((paintCount * 5 + 40) * 1.10);
}