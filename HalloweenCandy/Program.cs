string housesCountAsString = Console.ReadLine()!;

if (int.TryParse(housesCountAsString, out int housesCount))
{
    Console.Write(Math.Ceiling(200.0 / housesCount));
}