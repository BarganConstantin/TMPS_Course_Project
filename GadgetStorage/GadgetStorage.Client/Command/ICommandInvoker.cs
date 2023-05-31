

namespace GadgetStorage.Client.Command
{
    public interface ICommandInvoker
    {
        void printCommandMenu();
        void invokeCommand(string option);
    }
}
