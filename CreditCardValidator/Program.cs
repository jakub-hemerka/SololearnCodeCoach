char[] cardNumberAsCharacters = Console.ReadLine()!.ToCharArray();
int[] cardNumber = new int[cardNumberAsCharacters.Length];

if (cardNumberAsCharacters.Length == 16 && cardNumberAsCharacters.All(char.IsDigit))
{
    Array.Reverse(cardNumberAsCharacters);
    for (int i = 0; i < cardNumberAsCharacters.Length; i++)
    {
        if (i % 2 == 1)
        {
            cardNumber[i] = (int)char.GetNumericValue(cardNumberAsCharacters[i]) * 2;
        }

        if (cardNumber[i] > 9)
        {
            cardNumber[i] -= 9;
        }
    }

    Console.Write(cardNumber.Sum() % 10 == 0 ? "valid" : "invalid");
}