internal class Program
{
    private static void Main(string[] args)
    {
        string linesAsString = Console.ReadLine()!;

        if (int.TryParse(linesAsString, out int lines))
        {
            int sumOfOddNumbers = 0;
            while (lines > 0)
            {
                string number = Console.ReadLine()!;
                sumOfOddNumbers += EvaluateNumber(number);
                lines -= 1;
            }

            Console.Write(sumOfOddNumbers);
        }
    }

    private static int EvaluateNumber(string numberAsString)
    {
        if (int.TryParse(numberAsString, out int number) && number % 2 == 0)
        {
            return number;
        }

        return 0;
    }
}