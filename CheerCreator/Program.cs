string yardsGainedAsString = Console.ReadLine()!;

if (int.TryParse(yardsGainedAsString, out int yardsGained))
{
    string output = yardsGained switch
    {
        > 10 => "High Five",
        < 1 => "shh",
        _ => string.Join(null, Enumerable.Repeat("Ra!", yardsGained)),
    };
    Console.Write(output);
}