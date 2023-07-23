string[] signs = new string[4];

for (int i = 0; i < signs.Length; i++)
{
    signs[i] = Console.ReadLine()!.ToUpper();
}


foreach (string sign in signs)
{
    if (sign == "")
    {
        continue;
    }

    if (sign.Equals(sign.Reverse()))
    {
        Console.Write("Open");
        return;
    }
}

Console.Write("Trash");