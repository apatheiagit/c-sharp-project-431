namespace Hexlet;

public static class Even
{
    public static void EvenGame()
    {
        Console.WriteLine("Answer 'yes' if the number is even, otherwise answer 'no'.");
        Random rnd = new Random();
        int count = 0;

        while (count < 3)
        {
            int number = rnd.Next(0, 1000);
            Console.WriteLine("Question: " + number);
            Console.WriteLine("Your answer: ");
            string? answer = Console.ReadLine();
            if ((answer == "yes" && isEven(number)) || (answer == "no" && !isEven(number)))
            {
                Console.WriteLine("Correct!");
                count++;
            }
            else
            {
                Console.WriteLine("'yes' is wrong answer ;(. Correct answer was 'no'.");                
                Console.WriteLine($"Let's try again,{Cli.UserName}!");               

                return;
            }
        }
        Console.WriteLine($"Congratulations, {Cli.UserName}!");        
    }

    private static bool isEven(int number)
    {
        return (number % 2 == 0);
    }
}