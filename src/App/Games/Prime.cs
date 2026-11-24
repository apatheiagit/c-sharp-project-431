namespace App.Games;

public class Prime : IGame
{
    private readonly Random _rnd = new();

    public string Rules => "Answer 'yes' if given number is prime. Otherwise answer 'no'.";

    public (string Question, string CorrectAnswer) GenerateRound()
    {
        int number = _rnd.Next(0, 50);
        string correctAnswer = IsPrime(number) ? "yes" : "no";
        return (number.ToString(), correctAnswer);
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        if (number <= 3)
        {
            return true;
        }
        if (number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }
        var i = 5;
        while (i * i <= number)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
            i = i + 6;
        }
        return true;
    }
}
