using System;
using System.Text;

namespace Helpers
{
    public class ConsoleUtils : IConsoleUtils
    {
        public void DisplayWithColour(string text, ConsoleColor foreground)
        {
            Console.ForegroundColor = foreground;
            Console.Write(text);
            Console.ResetColor();
        }
        public void DisplayWithColour(string text, ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Write(text);
            Console.ResetColor();
        }

        public void DisplayOnCenterWithColour(string text, ConsoleColor foreground, ConsoleColor background)
        {
            const int width = 44;

            int spaceLen = (width - text.Length) / 2;

            StringBuilder space = new StringBuilder();

            for (int i = 0; i < spaceLen; i++) 
            {
                space.Append(' '); 
            }

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Write(space + text + space + "\n");
            Console.ResetColor();
        }

        public void DisplayEmptyColourLine(ConsoleColor foreground, ConsoleColor background)
        {
            DisplayOnCenterWithColour("                                            ", foreground, background);
        }
    }
}
