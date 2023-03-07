using System;

class DiscordTokenGenerator
{

    public static string token;
    static void Main()
    {
        Console.Title = "Discord Token Puller";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("██╗  ██╗██╗   ██╗███╗   ██╗ █████╗ ██████╗ ██╗     ███████╗██████╗ ");
        Console.WriteLine("██║  ██║██║   ██║████╗  ██║██╔══██╗██╔══██╗██║     ██╔════╝██╔══██╗");
        Console.WriteLine("███████║██║   ██║██╔██╗ ██║███████║██████╔╝██║     █████╗  ██████╔╝");
        Console.WriteLine("██╔══██║██║   ██║██║╚██╗██║██╔══██║██╔══██╗██║     ██╔══╝  ██╔══██╗");
        Console.WriteLine("██║  ██║╚██████╔╝██║ ╚████║██║  ██║██║  ██║███████╗███████╗██║  ██║");
        Console.WriteLine("╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝\n");
        Console.ResetColor();
        Console.WriteLine("Welcome to Hunarler, a free Discord Token Grabber\n");
        Console.WriteLine("Press any key to Start...\n");
        Console.ReadKey();
        A:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*Caution, dont enter the id of the user that you normaly friend with!*\n");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Enter the ID of the user you want the token:");
        Console.ResetColor();
        string name = Console.ReadLine();
        if(string.IsNullOrEmpty(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Enter a ID! \n");
            Console.ResetColor();
            goto A;
        }
        else
        {
            token = GenerateToken();
        }
        Console.WriteLine("The Token of " + name + " is\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(token);
        Console.ResetColor();
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    static string GenerateToken()
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random random = new Random();
        string token = "";
        for (int i = 0; i < 59; i++)
        {
            token += alphabet[random.Next(alphabet.Length)];
        }
        token += ".";
        for (int i = 0; i < 6; i++)
        {
            token += alphabet[random.Next(alphabet.Length)];
        }
        token += ".";
        for (int i = 0; i < 27; i++)
        {
            token += alphabet[random.Next(alphabet.Length)];
        }
        return token;
    }
}
