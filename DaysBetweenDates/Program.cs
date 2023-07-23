using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string firstDateAsString = Console.ReadLine()!;
        string secondDateAsString = Console.ReadLine()!;

        DateTime firstDate = ParseDate(firstDateAsString);
        DateTime secondDate = ParseDate(secondDateAsString);

        TimeSpan span = secondDate.Subtract(firstDate);

        Console.Write(span.Days);
    }

    private static DateTime ParseDate(string dateAsString)
    {
        if (DateTime.TryParseExact(dateAsString, "MMMM d, yyyy", CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out DateTime result))
        {
            return result;
        }

        return DateTime.Today;
    }
}