string heightAsString = Console.ReadLine()!;
string widthAsString = Console.ReadLine()!;

if (int.TryParse(heightAsString, out int height) && int.TryParse(widthAsString, out int width))
{
    Console.Write(width + height);
}