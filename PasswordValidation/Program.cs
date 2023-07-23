string password = Console.ReadLine()!.Trim();

if (password.Length < 7)
{
    Console.Write("Weak");
    return;
}

int numbersCount = 0;
int specialCharactersCount = 0;
List<char> specialCharactersTable = new() { '!', '@', '#', '$', '%', '&', '*' };

foreach (char letter in password)
{
    if (char.IsDigit(letter))
    {
        numbersCount += 1;
    }

    if (specialCharactersTable.Contains(letter))
    {
        specialCharactersCount += 1;
    }
}

if (numbersCount < 2 || specialCharactersCount < 2)
{
    Console.Write("Weak");
    return;
}

Console.Write("Strong");