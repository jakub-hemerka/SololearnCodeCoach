using System.Text;

string text = Console.ReadLine()!;

StringBuilder sb = new();

_ = sb.Append(char.ToLower(text[0]));

for (int i = 1; i < text.Length; i++)
{
    if (char.IsUpper(text[i]))
    {
        _ = sb.Append('_');
    }
    _ = sb.Append(char.ToLower(text[i]));
}

Console.Write(sb.ToString());