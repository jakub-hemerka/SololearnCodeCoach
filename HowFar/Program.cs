string layout = Console.ReadLine()!;

Console.Write($"{Math.Abs(layout.IndexOf('P') - layout.IndexOf('H') - 1)}");