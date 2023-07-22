string crimesCountAsString = Console.ReadLine()!;

if (int.TryParse(crimesCountAsString, out int crimesCount))
{
    switch (crimesCount)
	{
        case < 5:
			Console.Write("I got this!");
			break;
		case > 10:
			Console.Write("Good Luck out there!");
			break;
		default:
            Console.Write("Help me Batman");
			break;
	}
}