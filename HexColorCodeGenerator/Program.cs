internal class Program
{
    private static void Main(string[] args)
    {
        int red = ParseColor();
        int green = ParseColor();
        int blue = ParseColor();

        Console.Write($"#{red:x}{green:x}{blue:x}");
    }

    private static int ParseColor()
    {
        string colorAsString = Console.ReadLine()!;

        if (int.TryParse(colorAsString, out int color))
        {
            return color;
        }

        return 0;
    }
}