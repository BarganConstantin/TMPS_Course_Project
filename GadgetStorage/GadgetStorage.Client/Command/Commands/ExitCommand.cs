using System;
using System.Threading;

namespace GadgetStorage.Client.Command.Commands
{
    public class ExitCommand : ICommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("\n                                                     ,---. \r\n" +
                "  ,----.                    ,--.,--.                 |   | \r\n" +
                " '  .-./    ,---.  ,---.  ,-|  ||  |-.,--. ,--.,---. |  .' \r\n" +
                " |  | .---.| .-. || .-. |' .-. || .-. '\\  '  /| .-. :|  |  \r\n" +
                " '  '--'  |' '-' '' '-' '\\ `-' || `-' | \\   ' \\   --.`--'  \r\n" +
                "  `------'  `---'  `---'  `---'  `---'.-'  /   `----'.--.  \r\n" +
                "                                      `---'          '--'  ");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
