string[] names = Console.ReadLine()!.Split(' ');
string myName = Console.ReadLine()!;

foreach (string name in names)
{
    if (char.ToUpper(name[0]).Equals(char.ToUpper(myName[0])))
    {
        Console.Write("Compare notes");
        return;
    }
}

Console.Write("No such luck");