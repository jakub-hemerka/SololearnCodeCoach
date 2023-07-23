using System.Text;

string word = Console.ReadLine()!;
StringBuilder output = new(word);

string cutLengthAsString = Console.ReadLine()!;

if (int.TryParse(cutLengthAsString, out int cutLength) && cutLength > 0 && cutLength < output.Length)
{
    for (int pos = 0; pos + cutLength < output.Length; pos += (cutLength + 1))
    {
        _ = output.Insert(pos + cutLength, '-');
    }

    Console.Write(output.ToString());
}