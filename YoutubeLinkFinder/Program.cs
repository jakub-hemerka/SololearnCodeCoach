string url = Console.ReadLine()!;

// For regular version (https://www.youtube.com/watch?v=kbxkq_w51PM)
int cutStart = url.LastIndexOf('=') + 1;

if (cutStart <= 0)
{
    // For shortened version (https://youtu.be/KMBBjzp5hdc)
    cutStart = url.LastIndexOf('/') + 1;
}

Console.Write($"{url[cutStart..]}");