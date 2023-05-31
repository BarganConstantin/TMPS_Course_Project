using Autofac;
using GadgetStorage.Client.Command.Invokers;
using GadgetStorage.Client.Command;
using GadgetStorage.Client.ConsoleUI;
using GadgetStorage.Client.Command.Commands;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using GadgetStorage.Domain.Facade.OrderFacade;
using GadgetStorage.Domain.SingletonServices.ProductsStorage;
using GadgetStorage.Domain.Facade.ProductFacade;
using GadgetStorage.Domain.Adapter;
using Helpers;
using GadgetStorage.Domain.Facade.PackFacade;
using GadgetStorage.Domain.Facade.DeliveryFacade;
using GadgetStorage.Domain.FactoryMethod.Logistics;
using GadgetStorage.Domain.Entities.Enum;
using GadgetStorage.Domain.FactoryMethod;
using GadgetStorage.Domain.Template;

namespace GadgetStorage.Client
{
    public class Startup
    {
        public IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GadgetStorageUI>().As<IGadgetStorageUI>();

            // Register Facade services for client
            builder.RegisterType<OrderFacade>().As<IOrderFacade> ();
            builder.RegisterType<ProductFacade>().As<IProductFacade>();
            builder.RegisterType<PackFacade>().As<IPackFacade>();
            builder.RegisterType<DeliveryFacade>().As<IDeliveryFacade>();

            // Register the MainCommandInvoker as the ICommandInvoker service
            builder.RegisterType<MainCommandInvoker>().As<ICommandInvoker>();

            // Register each ICommand implementation with a unique name
            builder.RegisterType<PrintProductsCommand>().Named<ICommand>("1");
            builder.RegisterType<RegisterProductCommand>().Named<ICommand>("2");
            builder.RegisterType<PrintOrdersCommand>().Named<ICommand>("3");
            builder.RegisterType<RegisterOrderCommand>().Named<ICommand>("4");
            builder.RegisterType<DeliverOrderCommand>().Named<ICommand>("5");
            builder.RegisterType<SortProductsCommand>().Named<ICommand>("6");
            builder.RegisterType<ExitCommand>().Named<ICommand>("0");
            builder.RegisterType<PrintErrorCommand>().Named<ICommand>("-1");

            // Register services for invoker of factory method logistics
            builder.RegisterType<AirLogistics>().Named<AbstractLogistics>(DeliveryType.Air.ToString());
            builder.RegisterType<SeaLogistics>().Named<AbstractLogistics>(DeliveryType.Sea.ToString());
            builder.RegisterType<RoadLogistics>().Named<AbstractLogistics>(DeliveryType.Road.ToString());

            builder.RegisterType<LogisticsInvoker>().As<ILogisticsInvoker>();


            // Register storage services
            builder.RegisterType<InMemoryOrderStorage>().As<AbstractOrderStorage>();
            builder.RegisterType<InMemoryProductStorage>().As<AbstractProductStorage>();

            // Register adapter and it's singleton instance for extern library
            builder.RegisterType<ConsolePrintUtilsAdapter>().As<IConsolePrintUtils>();
            builder.RegisterType<ConsoleUtils>().As<IConsoleUtils>().SingleInstance();

            // Template method pattern
            builder.RegisterType<BasicStoreOrderLogic>().As<AbstractOrderSaveTemplate>();

            // Build and return the container
            return builder.Build();
        }
    }
}
