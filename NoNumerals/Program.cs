string[] words = Console.ReadLine()!.Split(' ');

Dictionary<string, string> convertTable = new()
        {
            { "10", "ten" },
            { "0", "zero" },
            { "1", "one" },
            { "2", "two" },
            { "3", "three" },
            { "4", "four" },
            { "5", "five" },
            { "6", "six" },
            { "7", "seven" },
            { "8", "eight" },
            { "9", "nine" },
        };

for (int i = 0; i < words.Length; i++)
{
    if (convertTable.ContainsKey(words[i]))
    {
        words[i] = convertTable[words[i]];
    }
}

Console.Write(string.Join(' ', words));