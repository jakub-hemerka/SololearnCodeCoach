int leftOvers = 0;

for (int i = 0; i < 4; i++)
{
    if (int.TryParse(Console.ReadLine()!, out int numberOfBlocks))
    {
        leftOvers += numberOfBlocks % 15;
    }
}

Console.Write(leftOvers);