internal class Program
{
    private static void Main(string[] args)
    {
        string[] firstBalcony = Console.ReadLine()!.Split(',');
        string[] secondBalcony = Console.ReadLine()!.Split(',');

        int aparmentA = CalculateArea(firstBalcony);
        int aparmentB = CalculateArea(secondBalcony);

        if (aparmentA > aparmentB)
        {
            Console.Write("Apartment A");
            return;
        }

        Console.Write("Apartment B");
    }

    private static int CalculateArea(string[] dimensions)
    {
        if (dimensions.Length == 2 && int.TryParse(dimensions[0], out int width) && int.TryParse(dimensions[1], out int heigth))
        {
            return width * heigth;
        }

        return 0;
    }
}