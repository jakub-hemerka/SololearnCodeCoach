string[] content = Console.ReadLine()!.Split(',');
string prize = Console.ReadLine()!;

if (content.Contains(prize))
{
    Console.Write($"It will take you {(Array.IndexOf(content, prize) + 1) * 5} minutes.");
}