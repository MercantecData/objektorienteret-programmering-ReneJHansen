using MultiThreadGameLib;
using System;
using System.Threading.Tasks;


namespace MultiThreadGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Makes a new instance of the library
            Library taskLib = new Library();
            TickCounter tickCounter;

            // Uses the delegate from the library
            tickCounter = taskLib.CreateWriteTimer;

            // Creates a random number between 1 and 10 (1 included)
            var random = new Random();
            int numberToGuess = random.Next(11);
            int playerGuess;
            bool correctGuess = false;


            // This is where the game starts
            Console.WriteLine("Guess a Number Game\nPress any key to start");
            Console.ReadKey();

            // When any key is tapped the timer starts
            Task timer = new Task(() => tickCounter(1));
            timer.Start();

            // Checks if your input is matching the random number
            while (correctGuess == false)
            {
                playerGuess = int.Parse(Console.ReadLine());
                if (playerGuess == numberToGuess)
                {
                    correctGuess = true;
                    Console.WriteLine($"Correct! The Answer is {numberToGuess}");
                }
                else if (playerGuess != numberToGuess)
                {
                    Console.WriteLine("Not the right answer");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}
