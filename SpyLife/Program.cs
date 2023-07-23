string encodedMessage = Console.ReadLine()!;

char[] filtered = encodedMessage.Reverse().Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray();

Console.Write(new string(filtered));