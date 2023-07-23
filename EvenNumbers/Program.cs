string[] allNumbersAsStrings = Console.ReadLine()!.Split(' ');
List<int> evenNumbers = new();

foreach (string numberAsString in allNumbersAsStrings)
{
    if (int.TryParse(numberAsString, out int number) && number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
}

Console.Write(string.Join(' ', evenNumbers));