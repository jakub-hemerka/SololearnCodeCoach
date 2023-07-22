string[] snacks = Console.ReadLine()!.Split(' ');
int bribeValue = 0;

Dictionary<string, int> snackTable = new()
{
    ["Lettuce"] = 5,
    ["Carrot"] = 4,
    ["Mango"] = 9,
    ["Cheeseburger"] = 0
};

foreach (string item in snacks)
{
    if (snackTable.ContainsKey(item))
    {
        bribeValue += snackTable[item];
    }
}

if (bribeValue >= 10)
{
    Console.Write("Come on Down!");
    return;
}

Console.Write("Time to wait");