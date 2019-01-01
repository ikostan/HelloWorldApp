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
            string greetings = "Hello dear user.\n";
            string enterInput = "Please enter your input (or type 'exit' in order to close the app):\n";
            string exit = "exit";
            string exitApp = "The application will close now";
            int sleepTime = 3000;

            Console.Write(greetings); //Greetings message

            while (true) {

                Console.Write(enterInput); //Ask for user input

                //Keep console window open
                //Get user input and convert it into a string + clear white spaces
                string userInput = Console.ReadLine().ToString().Trim();

                //Close app if user type "exit"
                if (userInput.ToLower().Equals(exit)) {

                    Console.Write(exitApp);
                    Thread.Sleep(sleepTime);
                    Environment.Exit(0);
                }

                //Display user input
                Console.Write("User input: " + userInput + "\n");
            }           
        }
    }
}
