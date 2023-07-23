string sentence = Console.ReadLine()!;

char[] output = sentence.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray();

Console.Write(new string(output));