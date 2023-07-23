string[] map = Console.ReadLine()!.ToUpper().Split(',');

List<(int X, int Y)> coordinates = new List<(int X, int Y)>();

for (int i = 0; i < map.Length; i++)
{
    for (int j = 0; j < map[i].Length; j++)
    {
        if (map[i][j] == 'P')
        {
            coordinates.Add((j, i));
        }
    }
}

if (coordinates.Count == 2)
{
    int distance = Math.Abs(coordinates[1].X - coordinates[0].X) + Math.Abs(coordinates[1].Y - coordinates[0].Y);

    Console.Write(distance);
}