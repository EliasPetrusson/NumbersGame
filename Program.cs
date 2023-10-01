namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate a random secret number between 1 and 20.
            Random random = new Random();
            int secretNumber = random.Next(1, 21);

            int numberOfTries = 5;
            int userGuess; // Declare userGuess outside the loop.
            bool isGuessCorrect = false; // Track if the user has guessed correctly.

            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");

            for (int attempt = 1; attempt <= numberOfTries; attempt++)
            {
                Console.Write($"Gissning {attempt}: ");
                if (int.TryParse(Console.ReadLine(), out userGuess))
                {
                    if (CheckGuess(userGuess, secretNumber))
                    {
                        isGuessCorrect = true;
                        break; // End the game if the guess is correct.
                    }
                }
                else
                {
                    Console.WriteLine("Fel! Skriv in ett riktigt nummer!");
                    attempt--; // Decrement the attempt count for invalid input.
                }
            }

            if (isGuessCorrect)
            {
                Console.WriteLine("Wohoo! Du klarade det!");
            }
            else
            {
                Console.WriteLine($"Ledsen, du lyckades inte gissa talet på fem försök! Talet var {secretNumber}.");
            }
        }

        static bool CheckGuess(int guess, int secretNumber)
        {
            if (guess == secretNumber)
            {
                return true; // Guess is correct.
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");
            }
            else
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");
            }
            return false; // Guess is incorrect.
        }
    }
}