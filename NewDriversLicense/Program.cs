string myName = Console.ReadLine()!;
string numberOfAgentsAsString = Console.ReadLine()!;
List<string> queueList = Console.ReadLine()!.Split(' ').ToList();

if (double.TryParse(numberOfAgentsAsString, out double numberOfAgents))
{
    if (numberOfAgents > 5)
    {
        numberOfAgents = 5;
    }

    queueList.Add(myName);
    queueList.Sort();

    double myPosition = queueList.IndexOf(myName) + 1;
    double waitingTime = Math.Ceiling(myPosition / numberOfAgents) * 20;

    Console.Write(waitingTime);
}