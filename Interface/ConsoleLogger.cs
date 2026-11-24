namespace Interface;

public class ConsoleLogger: ILogger
{
    public string Name => "Console";

    public void Log(string message)
    {
        Console.WriteLine($"[{Name}] {message}");
    }
}

public class FilleLogge : ILogger
{
    public string  Name => "File";

    public void Log(string message)
    {
       Console.WriteLine($"Gravando no arquivo: {message}");
    }
}