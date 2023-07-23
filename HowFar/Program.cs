string layout = Console.ReadLine()!;

int indexOfP = layout.IndexOf('P');
int indexOfH = layout.IndexOf('H');
int distance = indexOfH > indexOfP ? indexOfH - indexOfP - 1 : indexOfP - indexOfH - 1;
Console.Write(distance);