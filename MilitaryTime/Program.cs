using System.Globalization;

string timeInTwelveFormat = Console.ReadLine()!;

if (DateTime.TryParseExact(timeInTwelveFormat, "h:m tt", CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out DateTime parsedTime))
{
    Console.Write(parsedTime.ToString("HH:mm"));
}