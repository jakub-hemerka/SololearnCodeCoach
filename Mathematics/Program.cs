using System.Data;

double result = Convert.ToDouble(Console.ReadLine());
string[] operations = Console.ReadLine()!.Split(' ');

DataTable calculator = new();
for (int i = 0; i < operations.Length; i++)
{
    object currentResult = calculator.Compute(operations[i], "");
    if (Convert.ToDouble(currentResult) == result)
    {
        Console.Write($"index {i}");
        return;
    }
}

Console.Write("none");