using System.Globalization;

string dateInUSFormat = Console.ReadLine()!;
string[] formats = new string[] { "M/d/yyyy", "MMMM d, yyyy" };

if (DateTime.TryParseExact(dateInUSFormat, formats, CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out DateTime parsedDate))
{
    Console.Write(parsedDate.ToString("d/M/yyyy"));
}