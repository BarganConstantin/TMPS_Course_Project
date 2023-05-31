using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Adapter
{
    public interface IConsolePrintUtils
    {
        void PrintWithColour(string text, ConsoleColor foreground = ConsoleColor.White);
        void PrintWithColour(string text, ConsoleColor foreground, ConsoleColor background);
        void PrintOnCenterWithColour(string text, ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Green);
        void PrintEmptyColourLine(ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Green);
    }
}
