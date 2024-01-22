

public interface IUserInterface
{
    void Display(string message);
}

public class ConsoleUserInterface : IUserInterface
{
    public void Display(string message)
    {
        Console.WriteLine(message);
    }
}
