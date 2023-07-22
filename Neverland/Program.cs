string ageWhenEnteredAsString = Console.ReadLine()!;
string timePassedAsString = Console.ReadLine()!;

if (int.TryParse(ageWhenEnteredAsString, out int ageWhenEntered) && int.TryParse(timePassedAsString, out int yearsPassed))
{
    Console.Write($"My twin is {ageWhenEntered + yearsPassed} years old and they are {yearsPassed} years older than me");
}