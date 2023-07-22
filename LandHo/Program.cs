string peopleAheadAsString = Console.ReadLine()!;

if (int.TryParse(peopleAheadAsString, out int peopleAhead))
{
    Console.Write(10 + peopleAhead / 20 * 20);
}