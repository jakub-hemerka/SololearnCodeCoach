string paintCountAsString = Console.ReadLine()!;

if (int.TryParse(paintCountAsString, out int paintCount))
{
    Console.Write(Math.Round((paintCount * 5 + 40) * 1.10));
}