using System.Globalization;

string dateAsString = Console.ReadLine()!;
string[] formats = new string[] { "M/d/yyyy", "M d, yyyy", "MMMM d, yyyy" };

if (DateTime.TryParseExact(dateAsString, formats, CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out DateTime result))
{
    Console.Write(result.ToString("dddddd"));
}