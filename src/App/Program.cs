using App;
using App.Games;
using Hexlet;

Console.WriteLine("Please enter the game number and press Enter.");
Console.WriteLine("1 - Greet");
Console.WriteLine("2 - Even");
Console.WriteLine("3 - Calc");
Console.WriteLine("4 - GCD");
Console.WriteLine("0 - Exit");
Console.WriteLine("Your choice: ");
string? choice = Console.ReadLine();
switch (choice)
{
    case "1":
        Cli.WelcomeUser();
        break;
    case "2":
        Engine.Play(new Even());
        break;
    case "3":
        Engine.Play(new Calc());
        break;
    case "4":
        Engine.Play(new Gcd());
        break;
    default:
        Console.WriteLine("Bye!");
        break;
}
Console.ReadLine();
