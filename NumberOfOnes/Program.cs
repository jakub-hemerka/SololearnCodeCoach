string numberAsString = Console.ReadLine()!;
string numberInBinary = "";

if (int.TryParse(numberAsString, out int number))
{
    while (number > 0)
    {
        numberInBinary += $"{number % 2}";
        number /= 2;
    }
    
    Console.Write(numberInBinary.Count(c => c == '1'));
}