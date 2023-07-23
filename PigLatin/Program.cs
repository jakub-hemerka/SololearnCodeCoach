string[] words = Console.ReadLine()!.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    words[i] = $"{words[i][1..]}{words[i][0]}ay";
}

Console.Write(string.Join(' ', words));