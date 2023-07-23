internal class Program
{
    private static void Main(string[] args)
    {
        double distanceToSafety = GetData();
        double roadrunnerSpeed = GetData();
        double coyoteSpeed = GetData();

        double distanceApart = 50;
        double timeToSafety = distanceToSafety / roadrunnerSpeed;

        if (coyoteSpeed > (distanceApart + distanceToSafety) / timeToSafety)
        {
            Console.Write("Yum");
            return;
        }

        Console.Write("Meep Meep");
    }

    private static double GetData()
    {
        string dataAsString = Console.ReadLine();

        if (double.TryParse(dataAsString, out double output))
        {
            return output;
        }

        return 0;
    }
}