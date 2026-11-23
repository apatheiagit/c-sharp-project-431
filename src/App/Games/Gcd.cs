namespace App.Games;

public class Gcd : IGame
{
    private readonly Random _rnd = new();

    public string Rules => "Find the greatest common divisor of given numbers.";

    public (string Question, string CorrectAnswer) GenerateRound()
    {
        int a = _rnd.Next(0, 50);
        int b = _rnd.Next(0, 50);
        int result = CulcGcd(a, b);

        return ($"{a} {b}", result.ToString());
    }

    private static int CulcGcd(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            var rest = a % b;
            a = b;
            b = rest;
        }
        return a;
    }
}
