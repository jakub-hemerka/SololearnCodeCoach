Dictionary<string, decimal> parkMenu = new()
{
    ["Nachos"] = 6,
    ["Pizza"] = 6,
    ["Cheeseburger"] = 10,
    ["Water"] = 4,
    ["Coke"] = 5
};

string[] orderedItems = Console.ReadLine()!.Split(' ');
decimal price = 0;

foreach (string item in orderedItems)
{
    if (parkMenu.ContainsKey(item))
    {
        price += parkMenu[item];
        continue;
    }

    price += parkMenu["Coke"];
}

Console.Write(price * 1.07M);