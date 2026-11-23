using App.Games;
using Hexlet;

namespace App;

public static class Engine
{
    private const int RoundsCount = 3;

    public static void Play(IGame game)
    {
        Cli.WelcomeUser();
        Console.WriteLine(game.Rules);

        for (int round = 0; round < RoundsCount; round++)
        {
            var (question, correctAnswer) = game.GenerateRound();

            Console.WriteLine($"Question: {question}");
            Console.Write("Your answer: ");
            string? answer = Console.ReadLine();

            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct!");
                continue;
            }

            Console.WriteLine(
                $"'{answer}' is wrong answer ;(. Correct answer was '{correctAnswer}'."
            );
            Console.WriteLine($"Let's try again, {Cli.UserName}!");
            return;
        }

        Console.WriteLine($"Congratulations, {Cli.UserName}!");
    }
}
