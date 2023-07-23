string numberOfLinesAsString = Console.ReadLine()!;

if (int.TryParse(numberOfLinesAsString, out int numberOfLines) && numberOfLines > 0)
{
    int[] numbers = new int[numberOfLines];
    List<int> missingNumbers = new List<int>();

    for (int i = 0; i < numberOfLines; i++)
    {
        while (!int.TryParse(Console.ReadLine(), out int number))
        {
            numbers[i] = number;
        }
    }

    for (int i = numbers.Min(); i < numbers.Max(); i++)
    {
        if (!numbers.Contains(i))
        {
            missingNumbers.Add(i);
        }
    }
    Console.Write(string.Join(' ', missingNumbers));
}