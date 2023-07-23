internal class Program
{
    private static void Main(string[] args)
    {
        double cyan = GetColor();
        double magenta = GetColor();
        double yellow = GetColor();
        double black = GetColor();

        double red = 255 * (1 - cyan) * (1 - black);
        double green = 255 * (1 - magenta) * (1 - black);
        double blue = 255 * (1 - yellow) * (1 - black);

        Console.Write($"{Math.Round(red)},{Math.Round(green)},{Math.Round(blue)}");
    }

    private static double GetColor()
    {
        string input = Console.ReadLine()!;

        if (double.TryParse(input, out double result))
        {
            return result;
        }

        return 0;
    }
}