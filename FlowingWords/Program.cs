string[] words = Console.ReadLine()!.Split(' ');

if (words.Length < 2)
{
    return;
}

for (int i = 0; i < words.Length - 1; i++)
{
    char lastLetterInCurrentWord = char.ToLower(words[i][^1]);
    char firstLetterInNextWord = char.ToLower(words[i + 1][0]);

    if (lastLetterInCurrentWord != firstLetterInNextWord)
    {
        Console.Write("false");
        return;
    }
}

Console.Write("true");