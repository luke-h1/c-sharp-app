using System;


// namespace
namespace number_guesser
{
    // main class 
    class Program
    {

        // entry point method for the App

        // void = return type of method
        // static = no instances. Refering to func itself
        // typed language. So need to define types for variables
        static void Main(string[] args)
        {
            GetAppInfo();
            Greeting();

            while (true)
            {

            
            // init correct number
            // int correctNumber = 7;

            // create a new random object 
            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            // init guess variable

            int guess = 0;

            // ask user for correct number 
            Console.WriteLine("Guess a number between 1 & 10");

            // if guess not correct ask again 
            while (guess != correctNumber)
            {
                // get user input
                string input = Console.ReadLine();

                // check if number
                if (!int.TryParse(input, out guess))
                {
                        // print error msg
                        PrintColorMsg(ConsoleColor.Red, "Answer must be an number for guess"); 

                    continue;
                }

                // cast to int & put in the user's guess
                guess = Int32.Parse(input);

                // match guess to correct number
                if(guess != correctNumber)
                {
                        PrintColorMsg(ConsoleColor.Red, "hmmm..that's not correct, Try again"); 
                }

            }
                // output success
                PrintColorMsg(ConsoleColor.Green, "You guessed correctly ! 🎉🎉🎉");
                Console.WriteLine("Would you like to play again ? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }else if (answer == "N")
                {

                    return; 
                }else
                {
                    Console.WriteLine("Answer must be Y/N");
                }

                    

            }
        }

        static void GetAppInfo()
        {
            // set app variables
            string appname = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Luke H";
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            // write out app info to console 
            Console.WriteLine("{0}: Version {1}, by {2}", appname, appVersion, appAuthor);
            // reset console text color 
            Console.ResetColor();
        }

        static void Greeting()
        {
            // ask user's name
            Console.WriteLine("What is your name ? ");

            // get user input
            string inputName = Console.ReadLine();

            Console.Write("hello, {0}, let's play a game...", inputName);
        }

        // print color msg
        static void PrintColorMsg(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
