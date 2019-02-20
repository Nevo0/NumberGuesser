using System;

// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {

            // Set app vars
            string appNmae = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Rafal Piecyk";

            // Change text  color

            Console.ForegroundColor = ConsoleColor.Green;


            //Write out app info

            Console.WriteLine("{0}: Versioon {1} by {2}", appNmae, appVersion, appAuthor);

            // console color reset

            Console.ResetColor();

            //Ask users name
            Console.WriteLine("What is tour name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's paly a game",inputName);

            while (true)
            {


                //Set correct number

                //int correctNumber = 7;

                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                // Init guessvar

                int guess = 0;


                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");


                // While guess is not corect
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Write out app info

                        Console.WriteLine("Please enter an actual number");

                        // console color reset

                        Console.ResetColor();

                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Write out app info

                        Console.WriteLine("Wrong number,  pleas try again");

                        // console color reset

                        Console.ResetColor();
                    }

                }

                // Output success massage

                Console.ForegroundColor = ConsoleColor.Yellow;

                //Write out app info

                Console.WriteLine("You are CORRECT!!");

                // console color reset

                Console.ResetColor();

                // Ask to play again

                Console.WriteLine("Play Again? [Y or  N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") ;
                else
                {
                    return;
                }
            }

        }


    }
}
