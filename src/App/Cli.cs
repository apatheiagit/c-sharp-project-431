namespace Hexlet;

public static class Cli
{
    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome to the Brain Games!");
        Console.WriteLine("May I have your name?");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}