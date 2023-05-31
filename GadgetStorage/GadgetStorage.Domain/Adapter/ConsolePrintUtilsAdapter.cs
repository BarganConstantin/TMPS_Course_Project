using Helpers;
using System;

namespace GadgetStorage.Domain.Adapter
{
    public class ConsolePrintUtilsAdapter : IConsolePrintUtils
    {
        private readonly IConsoleUtils _consoleUtils;

        public ConsolePrintUtilsAdapter(IConsoleUtils consoleUtils)
        {
            _consoleUtils = consoleUtils;
        }

        public void PrintEmptyColourLine(ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Green)
        {
            _consoleUtils.DisplayEmptyColourLine(foreground, background);
        }

        public void PrintOnCenterWithColour(string text, ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Green)
        {
            _consoleUtils.DisplayOnCenterWithColour(text, foreground, background);
        }

        public void PrintWithColour(string text, ConsoleColor foreground = ConsoleColor.White)
        {
            _consoleUtils.DisplayWithColour(text, foreground);
        }

        public void PrintWithColour(string text, ConsoleColor foreground, ConsoleColor background)
        {
           _consoleUtils.DisplayWithColour(text, foreground, background);
        }
    }
}
