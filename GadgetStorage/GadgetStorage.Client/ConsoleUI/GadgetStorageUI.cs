using GadgetStorage.Client.Command;
using System;
using System.Threading;

namespace GadgetStorage.Client.ConsoleUI
{
    public class GadgetStorageUI : IGadgetStorageUI
    {
        private readonly ICommandInvoker _invoker;
        public GadgetStorageUI(ICommandInvoker invoker)
        {
            _invoker = invoker;
        }

        public void Run()
        {
            Console.WriteLine("\n                                                         ,---. \r\n" +
                " ,--.   ,--.       ,--.                                  |   | \r\n" +
                " |  |   |  | ,---. |  | ,---. ,---. ,--,--,--. ,---.     |  .' \r\n" +
                " |  |.'.|  || .-. :|  || .--'| .-. ||        || .-. :    |  |  \r\n" +
                " |   ,'.   |\\   --.|  |\\ `--.' '-' '|  |  |  |\\   --.    `--'  \r\n" +
                " '--'   '--' `----'`--' `---' `---' `--`--`--' `----'    .--.  \r\n" +
                "                                                         '--'  ");
            Thread.Sleep(1000);

            var init = new Initialization();
            init.Run();

            while (true)
            {
                _invoker.printCommandMenu();
                var option = Console.ReadLine();

                _invoker.invokeCommand(option);
            }
        }
    }
}
