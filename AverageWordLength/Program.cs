string[] words = Console.ReadLine()!.Split(' ');

Console.Write(Math.Ceiling(words.Average(x => x.Count(c => char.IsLetterOrDigit(c)))));