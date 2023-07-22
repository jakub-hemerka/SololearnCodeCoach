string pointsScoredAsString = Console.ReadLine()!;
string costOfGunAsString = Console.ReadLine()!;

if (int.TryParse(pointsScoredAsString, out int pointsScored) && int.TryParse(costOfGunAsString, out int costOfGun))
{
    Console.Write(pointsScored / 12 >= costOfGun ? "Buy it!" : "Try again");
}