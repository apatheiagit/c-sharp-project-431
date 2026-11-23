using Hexlet;

Console.WriteLine("Please enter the game number and press Enter.");
Console.WriteLine("1 - Greet");
Console.WriteLine("2 - Even");
Console.WriteLine("0 - Exit");
Console.WriteLine("Your choice: ");
string? choice = Console.ReadLine();
switch (choice){
    case "1":
        Cli.WelcomeUser();
        break;
    case "2":
        Cli.WelcomeUser();
        Even.EvenGame();
        break;
    default:
        Console.WriteLine("Bay!");
        break;
}
Console.ReadLine();
