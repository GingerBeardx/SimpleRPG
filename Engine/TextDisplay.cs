using System;
using System.Threading;

namespace Engine
{
    /// <summary>
    /// Manages the displaying of text
    /// </summary>
    public static class TextDisplay
    {
        /// <summary>
        /// Takes a string of text and writes it slowly on the screen with the provided
        /// delay.
        /// </summary>
        /// <param name="textString"></param>
        /// <param name="delay"></param>
        public static void WriteText(string textString, int delay)
        {
            foreach (var character in textString)
            {
                Console.Write(character);
                Thread.Sleep(delay);
            }
        }
    }
}
