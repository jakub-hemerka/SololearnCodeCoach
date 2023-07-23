string[] prizesAsStrings = Console.ReadLine()!.Split(',');
decimal[] convertedPrizes = new decimal[prizesAsStrings.Length];

for (int i = 0; i < prizesAsStrings.Length; i++)
{
    if (decimal.TryParse(prizesAsStrings[i], out decimal result))
    {
        convertedPrizes[i] = result;
    }
}

decimal savedAmount = Math.Floor((convertedPrizes.Sum() - convertedPrizes.Max()) * 0.3M * 1.07M);

Console.Write(savedAmount);