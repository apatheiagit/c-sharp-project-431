namespace App.Games;

public class Even : IGame
{
    private readonly Random _rnd = new();

    public string Rules => "Answer 'yes' if the number is even, otherwise answer 'no'.";

    public (string Question, string CorrectAnswer) GenerateRound()
    {
        int number = _rnd.Next(0, 1000);
        string correctAnswer = IsEven(number) ? "yes" : "no";
        return (number.ToString(), correctAnswer);
    }

    private static bool IsEven(int number)
    {
        return (number % 2 == 0);
    }
}
