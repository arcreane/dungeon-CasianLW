public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the user interface
        IUserInterface userInterface = new ConsoleUserInterface();

        // Create an instance of CommunicatingClass
        CommunicatingClass gameCommunication = new CommunicatingClass();

        // Associate the delegates with the corresponding methods
        gameCommunication.OnGetPlayerAction = (action) =>
        {
            // Simulate receiving an action from the player
            userInterface.Display($"Player action received: {action}");
        };
        gameCommunication.OnInformPlayer = (message) =>
        {
            // Use the user interface to display the message
            userInterface.Display(message);
        };

        // Test the delegates
        gameCommunication.RequestPlayerAction();
        gameCommunication.SendInfoToPlayer("Welcome to the game!");

    }
}
