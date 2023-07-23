string floorLayout = Console.ReadLine()!;

int money = floorLayout.IndexOf('$');
int thief = floorLayout.IndexOf('T');

string area = money < thief ? floorLayout[money..(thief + 1)] : floorLayout[thief..(money + 1)];

if (area.Contains('G'))
{
    Console.Write("quiet");
    return;
}

Console.Write("ALARM");