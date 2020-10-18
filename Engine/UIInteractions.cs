using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Engine
{
    public static class UIInteractions
    {
        /// <summary>
        /// Displays the game introduction.
        /// </summary>
        public static void ShowWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var welcomeStringOne = "Welcome to RedBeard's Lost World\n";
            var welcomeStringTwo = "Explore the land of Celticus!\n" +
                "Solve Puzzles!\n" +
                "Discover treasure!\n" +
                "Fight monsters!\n" +
                "And consort with wenches!\n";


            TextDisplay.WriteText(welcomeStringOne, 30);
            TextDisplay.WriteText(welcomeStringTwo, 50);
            Console.WriteLine();
            Console.Write("Please press a key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Displays the main menu and incorporates basic interactions.
        /// </summary>
        public static void ShowMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ReadBeard's Lost World");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");
            TextDisplay.WriteText("Welcome to Celticus, Adventurer!\n", 20);
            TextDisplay.WriteText("Please choose one of the following options:\n", 20);
            
            while (true)
            {
                var selection = GetMenuSelection();

                if (selection.ToLower() == "s" || selection.ToLower() == "start")
                {
                    continue;
                }
                else if (selection.ToLower() == "c" || selection.ToLower() == "continue")
                {
                    continue;
                }
                else if (selection.ToLower() == "d" || selection.ToLower() == "delete")
                {
                    continue;
                }
                else if (selection.ToLower() == "q" || selection.ToLower() == "quit")
                {
                    TextDisplay.WriteText("Farewell, Adventurer!", 30);
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine();
                    TextDisplay.WriteText("I'm sorry, mate, I didn't understand ye.\n", 20);
                }
            }
        }

        /// <summary>
        /// Gets the main menu selection from the user and returns it to the main menu.
        /// </summary>
        /// <returns>User Input for main menu</returns>
        private static string GetMenuSelection()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("(S)tart a new adventure");
            Console.WriteLine("(C)ontinue a saved adventure");
            Console.WriteLine("(D)elete a saved adventure");
            Console.WriteLine("(Q)uit the game");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Please enter your selection -> ");
            var input = Console.ReadLine();
            
            return input;
        }
    }
}
