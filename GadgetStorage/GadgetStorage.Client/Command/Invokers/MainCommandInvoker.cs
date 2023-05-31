using System;
using Autofac;
using GadgetStorage.Domain.Adapter;

namespace GadgetStorage.Client.Command.Invokers
{
    public class MainCommandInvoker : ICommandInvoker
    {
        private readonly ILifetimeScope _container;
        private readonly IConsolePrintUtils _consolePrintUtils;

        public MainCommandInvoker(ILifetimeScope container, IConsolePrintUtils consolePrintUtils) 
        {
            _container = container;
            _consolePrintUtils = consolePrintUtils;
        }

        public void invokeCommand(string option)
        {
            var command = _container.ResolveNamed<ICommand>(option);
            command.Execute();
        }

        public void printCommandMenu()
        {
            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Available Commands", ConsoleColor.White, ConsoleColor.Green);
            _consolePrintUtils.PrintWithColour("\n 1 - Print available Products\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintWithColour(" 2 - Register new product\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintWithColour(" 3 - Print available Orders\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintWithColour(" 4 - Register new order\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintWithColour(" 5 - Make an order delivery\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintWithColour(" 6 - Sort Storage Products\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintWithColour(" 0 - exit\n\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintEmptyColourLine(ConsoleColor.White, ConsoleColor.Green);
            _consolePrintUtils.PrintWithColour("\n Enter option: ", ConsoleColor.White);
        }
    }
}



//private readonly Dictionary<string, ICommand> _actionMap;

//public static Dictionary<string, ICommand> _actionMap = new Dictionary<string, ICommand>()
//{
//    { "1", new PrintProductsCommand() },
//    { "2", new AddGadgetCommand() },
//    { "3", new PrintOrdersCommand() },
//    { "4", new RegisterOrderCommand() },
//    { "5", new DeliverOrderCommand() },
//    { "6", new SortProductsCommand() },
//    { "0", new ExitCommand() },
//    { "-1", new PrintErrorCommand() },
//};

//public void invokeCommand(string option)
//{
//    if (_actionMap.ContainsKey(option))
//    {
//        _actionMap[option].Execute();
//    }
//    _actionMap["error"].Execute();
//}