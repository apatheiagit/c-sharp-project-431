namespace Hexlet;

public static class Cli
{
    public static string? UserName { get; set; }

    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome to the Brain Games!");
        Console.WriteLine("May I have your name?");
        UserName = Console.ReadLine();
        Console.WriteLine($"Hello, {UserName}!");
    }
}
