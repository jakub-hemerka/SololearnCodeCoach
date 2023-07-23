List<string> input = Console.ReadLine()!.Split(' ').ToList();

if (input.Any(x => x.Length == 0))
{
    return;
}

string word = input.OrderBy(x => x.Length).First();
input.RemoveAt(0);

int position = 0;
int cutLength = 1;
string output = string.Empty;

while (position + cutLength <= word.Length)
{
    string temp = word.Substring(position, cutLength);
    if (input.All(x => x.Contains(temp)))
    {
        cutLength += 1;
        if (temp.Length > output.Length)
        {
            output = temp;
        }
        continue;
    }

    position += 1;
    cutLength = 1;
}

Console.Write(output);