string word = Console.ReadLine()!.ToLower();
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

Console.Write(word.Count(c => vowels.Contains(c)));