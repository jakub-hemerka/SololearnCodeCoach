internal class Program
{
    private static void Main(string[] args)
    {
        string[] arr = Console.ReadLine()!.Split(' ');

        List<Card> cards = new List<Card>();

        foreach (string item in arr)
        {
            cards.Add(new Card(item));
        }

        cards = cards.OrderBy(x => x.Value).ToList();
        string output = EvaluateHand(cards);
        Console.Write(output);
    }

    private static string EvaluateHand(List<Card> cards)
    {
        bool isFlush = IsHandFlush(cards);
        bool isStraight = IsHandStraight(cards);

        if (isFlush && isStraight && cards[0].Value == 10)
        {
            return "Royal Flush";
        }

        if (isFlush && isStraight)
        {
            return "Straight Flush";
        }

        if (isStraight && !isFlush)
        {
            return "Straight";
        }

        if (isFlush)
        {
            return "Flush";
        }

        Dictionary<int, int> counter = new Dictionary<int, int>();
        for (int i = 0; i < cards.Count; i++)
        {
            if (!counter.ContainsKey(cards[i].Value))
            {
                counter.Add(cards[i].Value, 1);
                continue;
            }

            counter[cards[i].Value] += 1;
        }

        if (counter.ContainsValue(4))
        {
            return "Four of a Kind";
        }

        if (counter.ContainsValue(3) && counter.ContainsValue(2))
        {
            return "Full House";
        }

        if (counter.ContainsValue(3))
        {
            return "Three of a Kind";
        }

        if (counter.ContainsValue(2) && counter.Values.Count(x => x == 2) == 2)
        {
            return "Two Pairs";
        }

        if (counter.ContainsValue(2))
        {
            return "One Pair";
        }

        return "High Card";
    }

    private static bool IsHandFlush(List<Card> cards)
    {
        char first = cards[0].Suite;

        for (int i = 1; i < cards.Count; i++)
        {
            if (!first.Equals(cards[i].Suite))
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsHandStraight(List<Card> cards)
    {
        int firstCard = cards[0].Value;

        for (int i = 1; i < cards.Count; i++)
        {
            if (firstCard == 2 && i == cards.Count - 1 && cards[i].Value == 14)
            {
                return true;
            }

            if (cards[i].Value != firstCard + i)
            {
                return false;
            }
        }

        return true;
    }
}

internal struct Card
{
    public char Suite { get; private set; }
    public int Value { get; private set; }

    public Card(string s)
    {
        string first = s.Substring(0, s.Length - 1);
        Suite = s.Last();
        Value = first switch
        {
            "J" => 11,
            "Q" => 12,
            "K" => 13,
            "A" => 14,
            _ => Convert.ToInt32(first),
        };
    }
}