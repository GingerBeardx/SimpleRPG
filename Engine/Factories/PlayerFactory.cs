using System;

namespace Engine.Factories
{
    public static class PlayerFactory
    {
        /// <summary>
        /// Creates a new player
        /// </summary>
        /// <returns>New Player Object</returns>
        public static Player CreatePlayer()
        {
            Console.Clear();
            TextDisplay.WriteText("I will assist you in creating your player.\n", 30);
            TextDisplay.WriteText("Please enter the following information:\n\n", 30);

            Console.Write("Player Name -> ");
            string playerName = Console.ReadLine();

            Console.Write("Player Gender -> ");
            string playerGender = Console.ReadLine();

            Player newCharacter = new Player(playerName, playerGender, 10, 10, 10, 5);
            TextDisplay.WriteText("You have created your player with the following info:\n", 30);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Player info: {newCharacter.GetPlayer()}");
            Console.WriteLine("------------------------------------------------------------");
            TextDisplay.WriteText("Please press enter to begin your advenure ->", 40);
            Console.ReadLine();

            return newCharacter;
        }
    }
}
