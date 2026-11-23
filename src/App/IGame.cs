namespace App.Games;

public interface IGame
{
    string Rules { get; }
    (string Question, string CorrectAnswer) GenerateRound();
}
