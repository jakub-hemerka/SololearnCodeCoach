string[] prizes = Console.ReadLine()!.Trim().Split(' ');

foreach (string prize in prizes)
{
    if (decimal.TryParse(prize, out decimal result) && result * 1.1M > 20)
    {
        Console.Write("Back to the store");
        return;
    }
}

Console.Write("On to the terminal");