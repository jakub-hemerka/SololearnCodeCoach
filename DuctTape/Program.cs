string heightAsString = Console.ReadLine()!;
string widthAsString = Console.ReadLine()!;

if (int.TryParse(heightAsString, out int height) && int.TryParse(widthAsString, out int width))
{
    int lines = width * 12 / 2;
    int totalLength = lines * height * 2;

    Console.Write(Math.Ceiling(totalLength / 60.0));
}