string input = Console.ReadLine()!;

if (!int.TryParse(input, out int arrayLength) && arrayLength <= 0)
{
    return;
}

int[] sequence = new int[arrayLength];

sequence[0] = 1;
sequence[1] = 1;

for (int i = 2; i < arrayLength; i++)
{
    sequence[i] = sequence[i - sequence[i - 1]] + sequence[i - sequence[i - 2]];
}

Console.Write(sequence.Last());