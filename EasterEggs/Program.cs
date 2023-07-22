string totalEggsAsString = Console.ReadLine()!;
string myEggsAsString = Console.ReadLine()!;
string friendsEggsAsString = Console.ReadLine()!;

if (int.TryParse(totalEggsAsString, out int totalEggs)
    && int.TryParse(myEggsAsString, out int myEggCount)
    && int.TryParse(friendsEggsAsString, out int friendEggCount))
{
    if (myEggCount + friendEggCount == totalEggs)
    {
        Console.Write("Candy Time");
        return;
    }

    Console.Write("Keep Hunting");
}