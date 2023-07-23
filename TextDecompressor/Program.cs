using System.Text.RegularExpressions;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string compressedText = Console.ReadLine()!.Trim();

        if (compressedText.Length <= 0)
        {
            return;
        }

        Regex re = new(@"([^\d])(\d+)"); // ^\d = jeden znak co není číslo
        StringBuilder output = new();
        MatchCollection matches = re.Matches(compressedText);

        foreach (Match match in matches)
        {
            _ = output.Append(ParseMatch(match.Value[0], match.Value[1..]));
        }

        Console.Write(output.ToString());
    }

    private static string ParseMatch(char character, string repeatCountAsString)
    {
        if (int.TryParse(repeatCountAsString, out int repeatCount))
        {
            return new string(character, repeatCount);
        }

        return string.Empty;
    }
}