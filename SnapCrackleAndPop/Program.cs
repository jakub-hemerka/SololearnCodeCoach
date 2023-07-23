internal class Program
{
    private static void Main(string[] args)
    {
        int bowls = 6;
        string[] output = new string[bowls];

        for (int i = 0; i < bowls; i++)
        {
            string riceAmountAsString = Console.ReadLine()!;

            if (int.TryParse(riceAmountAsString, out int riceAmount))
            {
                string sound = DetermineSound(riceAmount);
                output[i] = sound;
            }
        }

        Console.Write(string.Join(' ', output));
    }

    private static string DetermineSound(int riceAmount)
    {
        if (riceAmount % 3 == 0)
        {
            return "Pop";
        }

        if (riceAmount % 2 == 0)
        {
            return "Crackle";
        }

        return "Snap";
    }
}