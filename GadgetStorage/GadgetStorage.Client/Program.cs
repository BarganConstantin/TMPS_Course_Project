using Autofac;
using GadgetStorage.Client.ConsoleUI;

namespace GadgetStorage.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startUp = new Startup();
            var container = startUp.ConfigureContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IGadgetStorageUI>();
                app.Run();
            }
        }
    }
}