string[] content = Console.ReadLine()!.Split(',');
string prize = Console.ReadLine()!;

if (content.Contains(prize))
{
    Console.Write((Array.IndexOf(content, prize) + 1) * 5);
}