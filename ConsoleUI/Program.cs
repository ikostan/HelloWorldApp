using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //App params
            const string greetings = "Hello dear user.";
            const string enterInput = "Please enter your input (or type 'exit' in order to close the app):";
            const string exit = "exit";
            const string exitApp = "The application will close now";
            const int sleepTime = 3000;

            Console.ForegroundColor = ConsoleColor.Green; //Change foreground color >>> GREEN

            Console.WriteLine(greetings); //Greetings message

            while (true) {

                Console.WriteLine(enterInput); //Ask for user input
                Console.ForegroundColor = ConsoleColor.Yellow; //Change foreground color >>> YELLOW

                //Keep console window open
                //Get user input and convert it into a string + clear white spaces
                string userInput = Console.ReadLine().ToString().Trim();

                Console.ForegroundColor = ConsoleColor.Green; //Change foreground color >>> GREEN

                //Close app if user type "exit"
                if (userInput.ToLower().Equals(exit)) {

                    Console.Write(exitApp);
                    Thread.Sleep(sleepTime);
                    Environment.Exit(0);
                }

                //Display user input
                Console.Write("User input: ");
                Console.ForegroundColor = ConsoleColor.Red; //Change foreground color >>> RED
                Console.Write(userInput + "\n");
                Console.ForegroundColor = ConsoleColor.Green; //Change foreground color >>> GREEN
            }           
        }
    }
}
