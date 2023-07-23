string linesAsString = Console.ReadLine()!;
if (!int.TryParse(linesAsString, out int lines) && lines > 0)
{
    return;
}

int[] numbers = new int[lines];
bool output = true;

for (int i = 0; i < lines; i++)
{
    string numberAsString = Console.ReadLine()!;
    if (!int.TryParse(numberAsString, out int number))
    {
        continue;
    }

    numbers[i] = number;

    if (numbers.Take(i).Sum() >= number)
    {
        output = false;
    }

}

Console.Write(output);