internal class Program
{
    private static void Main(string[] args)
    {
        string word = Console.ReadLine()!.ToUpper();

        if (word == "")
        {
            Console.Write(0);
            return;
        }

        List<char> foundLetters = new List<char>();
        List<char> remainingLetters = new List<char>(word.OrderBy(x => x));
        List<char> alreadyChecked = new List<char>(); // Don't want to check l twice in word hello...

        int wordRank = 1;
        int index = 0;

        while (index != word.Length)
        {
            for (int i = 0; i < remainingLetters.Count; i++)
            {
                if (alreadyChecked.Contains(remainingLetters[i]))
                {
                    continue;
                }

                char letter = remainingLetters[i];
                alreadyChecked.Add(letter);
                remainingLetters.RemoveAt(i);

                if (letter == word[index])
                {
                    foundLetters.Add(letter);
                    alreadyChecked.Clear();
                    index += 1;
                    break;
                }

                // Calculating how many words are above this
                // For example, the word is SOLOLEARN
                // The word has 9 characters and I'm trying to find first letter. 8 positions are empty -> factorial it.
                // Second part is multiplication of factorials of how many times are remaining letters occuring (don't do the same letter more then once)...
                // Lets say remaining letters are E,L,L,N,O,O,R,S -> 1! * 2! * 1! * 2! * 1! * 1!
                // Result: 8! / 1! * 2! * 1! * 2! * 1! * 1! = 40320 / 4 = 10080
                int upper = CalculateFactorial(remainingLetters.Count);
                var characterGroups = remainingLetters.GroupBy(x => x);
                int lower = 1;

                foreach (var item in characterGroups)
                {
                    lower *= CalculateFactorial(item.Count());
                }
                wordRank += (upper / lower);

                remainingLetters.Insert(i, letter);
            }
        }

        Console.Write(wordRank);
    }

    private static int CalculateFactorial(int number)
    {
        int output = number;

        for (int i = number - 1; i > 0; i--)
        {
            output *= i;
        }

        return output;
    }
}