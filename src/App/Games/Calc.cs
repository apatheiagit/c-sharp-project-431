namespace App.Games;

public class Calc : IGame
{
    private readonly Random _rnd = new();
    public string Rules => "What is the result of the expression?";

    public (string Question, string CorrectAnswer) GenerateRound()
    {
        int a = _rnd.Next(0, 100);
        int b = _rnd.Next(0, 100);
        int operation = _rnd.Next(0, 3);

        string op = operation switch
        {
            0 => "+",
            1 => "-",
            _ => "*",
        };

        int result = operation switch
        {
            0 => a + b,
            1 => a - b,
            _ => a * b,
        };

        return ($"{a} {op} {b}", result.ToString());
    }
}
