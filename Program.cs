using System;

//Namespace
namespace Number_guesser
{
    //Main class
    class Program
    { 
        //Entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function to get info

            GreetUser(); //Ask for users name and greet

            while (true)
            {
                //Set correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();


                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //priint error message
                         

                        //Keep going
                        continue;
                    }
                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //set error message

                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again"); 
                    }
                }
                //Output success message
                // Change text color
                Console.ForegroundColor = ConsoleColor.Cyan;


                Console.WriteLine("Right number");

                //Reset text color
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play again [Y or N]");

                //Get answer
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


                //0
            }

        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor(); 
        }
        //Get and display app info 
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
