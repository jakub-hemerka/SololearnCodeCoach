char[] message = Console.ReadLine()!.Trim().ToLower().ToCharArray();

Dictionary<char, char> encodingTable = new();

char endChar = 'z';
for (char letter = 'a'; letter <= 'z'; letter++)
{
    encodingTable.Add(letter, endChar);
    endChar--;
}

for (int i = 0; i < message.Length; i++)
{
    char currentCharacter = message[i];
    if (encodingTable.ContainsKey(currentCharacter))
    {
        message[i] = encodingTable[currentCharacter];
    }
}

Console.Write(new string(message));