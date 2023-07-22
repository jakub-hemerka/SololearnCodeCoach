string zipcode = Console.ReadLine()!;

Console.Write(zipcode.Length == 5 && zipcode.All(c => char.IsDigit(c)));