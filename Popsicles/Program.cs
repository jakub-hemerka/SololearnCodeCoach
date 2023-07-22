string siglingsAsString = Console.ReadLine()!;
string popsiclesAsString = Console.ReadLine()!;

if (int.TryParse(siglingsAsString, out int siblings) && int.TryParse(popsiclesAsString, out int popsicles))
{
    if (popsicles % siblings == 0)
    {
        Console.Write("give away");
        return;
    }

    Console.Write("eat them yourself");
}