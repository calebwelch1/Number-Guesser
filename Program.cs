using System;

namespace CommandLineApp
{
    // main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            Console.WriteLine("What is your name?");
            // whatever user enters will become this variable
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game!", inputName);
            while (true)
            {
                // Set a correct number 
                // int correctNum = 7;
                // create a random object
                Random random = new Random();
                // call above variable, .Next calls it we put params inside
                int correctNum = random.Next(0, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 0 and 10");
                // while user does not have correct number, keep asking them to guess

                while (guess != correctNum)
                {
                    // parse input to int set to guess
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter a number");
                        Console.ResetColor();
                        // keep running the program
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNum)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Wrong Number please try again");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Good job you are correct!");
                        Console.ResetColor();
                        Console.WriteLine("Play Again? [Y or N]");

                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                        {
                            continue;
                        }
                        else if (answer == "N")
                        {
                            return;

                        }
                        else
                        {
                            return;
                        }
                    }

                }



            }
        }
        static void GetAppInfo()
        {

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Caleb Welch";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}
