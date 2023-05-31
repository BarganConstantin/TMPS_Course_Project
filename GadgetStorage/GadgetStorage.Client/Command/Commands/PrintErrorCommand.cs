using GadgetStorage.Domain.Adapter;
using System;

namespace GadgetStorage.Client.Command.Commands
{
    public class PrintErrorCommand : ICommand
    {
        private readonly IConsolePrintUtils _consolePrintUtils;

        public PrintErrorCommand(IConsolePrintUtils consolePrintUtils)
        {
            _consolePrintUtils = consolePrintUtils;
        }

        public void Execute()
        {
            _consolePrintUtils.PrintWithColour("Error to select option !", ConsoleColor.Red);
            _consolePrintUtils.PrintWithColour("\nTry Again !", ConsoleColor.Red);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
