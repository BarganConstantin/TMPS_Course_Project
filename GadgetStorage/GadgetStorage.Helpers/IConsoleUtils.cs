using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public interface IConsoleUtils
    {
        void DisplayWithColour(string text, ConsoleColor foreground);
        void DisplayWithColour(string text, ConsoleColor foreground, ConsoleColor background);
        void DisplayOnCenterWithColour(string text, ConsoleColor foreground, ConsoleColor background);
        void DisplayEmptyColourLine(ConsoleColor foreground, ConsoleColor background);
    }
}
