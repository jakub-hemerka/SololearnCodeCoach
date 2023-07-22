string word = Console.ReadLine()!.ToLower();

Console.Write(word.Distinct().Count() == word.Length);