string[] sounds = Console.ReadLine()!.Split(' ');
string[] output = new string[sounds.Length];

for (int i = 0; i < sounds.Length; i++)
{
    output[i] = sounds[i] switch
    {
        "Grr" => "Lion",
        "Rawr" => "Tiger",
        "Ssss" => "Snake",
        "Chirp" => "Bird",
        _ => "Unknown"
    };
}

Console.Write(string.Join(" ", output));