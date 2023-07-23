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

    string reversed = new string(sign.Reverse().ToArray());

    if (sign.Equals(reversed))
    {
        Console.Write("Open");
        return;
    }
}

Console.Write("Trash");