internal class Program
{
    private static void Main(string[] args)
    {
        string numberOfNamesAsString = Console.ReadLine()!;
        if (int.TryParse(numberOfNamesAsString, out int numberOfNames) && numberOfNames > 0)
        {
            string[] initials = new string[numberOfNames];

            for (int i = 0; i < numberOfNames; i++)
            {
                initials[i] = GetInitials();
            }

            Console.Write(string.Join(' ', initials));
        }
    }

    private static string GetInitials()
    {
        string[] words = Console.ReadLine()!.Trim().Split(' ');
        string output = string.Empty;
        foreach (string word in words)
        {
            output += word[0];
        }

        return output;
    }
}