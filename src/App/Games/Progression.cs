namespace App.Games;

public class Progression : IGame
{
    
    private const int MinLength = 5;
    private const int MaxLength = 10;
    private const int MinStep = 1;
    private const int MaxStep = 5;
    private const int MinStart = 0;
    private const int MaxStart = 50;
    private readonly Random _rnd = new();

    public string Rules => "What number is missing in the progression?";

    public (string Question, string CorrectAnswer) GenerateRound()
    {
        int length = _rnd.Next(MinLength, MaxLength + 1);
        int start = _rnd.Next(MinStart, MaxStart);
        int step = _rnd.Next(MinStep, MaxStep);
        int skipIndex = _rnd.Next(0, length);

        var (question, skip) = BuildSubsequence(start, step, skipIndex, length);
        return (question, skip.ToString());
    }

    private static (string Question, int Skip) BuildSubsequence(int start, int step, int skipIndex, int length)
    {
        var items = new string[length];

        int skip = 0;

        for (int i = 0; i < length; i++)
        {
            var current = start + step * i;
            if (i == skipIndex)
            {
                items[i] = "..";
                skip = current;
            }
            else
            {
                items[i] = current.ToString();
            }
        }
        return (string.Join(" ", items), skip);
    }
}
