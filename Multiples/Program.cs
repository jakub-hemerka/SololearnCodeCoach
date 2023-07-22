string numberAsString = Console.ReadLine()!;
int sum = 0;

if (int.TryParse(numberAsString, out int number))
{
    for (int i = number - 1; i > 0; i--)
    {
        switch (i % 3, i % 5)
        {
            case (0, 0):
            case (0, _):
            case (_, 0):
                sum += i;
                break;
            default:
                break;
        }
    }

    Console.WriteLine(sum);
}