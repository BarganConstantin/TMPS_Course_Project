using GadgetStorage.Domain.Adapter;
using GadgetStorage.Domain.Builders;
using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using GadgetStorage.Domain.SingletonServices.ProductsStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Facade.ProductFacade
{
    public class ProductFacade : IProductFacade
    {
        private readonly AbstractProductStorage _productStorage;
        private readonly IConsolePrintUtils _consolePrintUtils;
        public ProductFacade(AbstractProductStorage productStorage, IConsolePrintUtils consolePrintUtils)
        {
            _productStorage = productStorage;
            _consolePrintUtils = consolePrintUtils;
        }

        public void PrintProducts()
        {

            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Available Products List");
            Console.WriteLine();

            var iterator = _productStorage.GetIterator();

            if (!iterator.HasNext())
            {
                _consolePrintUtils.PrintWithColour($" No orders available!\n\n", ConsoleColor.Red);
            }
            else
            {
                while (iterator.HasNext())
                {
                    var gadget = iterator.Next();
                    _consolePrintUtils.PrintWithColour(string.Format("Id: {0}\tName: {1}\n", gadget.Id, gadget.Name), ConsoleColor.DarkGray);
                }
            }

            Console.WriteLine( );
            _consolePrintUtils.PrintEmptyColourLine();
            _consolePrintUtils.PrintWithColour("\nPress any key to continue ...");
            Console.ReadKey();
        }

        public void RegisterProduct()
        {
            Console.Clear();
            Console.WriteLine("Select what you want to add:");
            Console.WriteLine("1. Phone");
            Console.WriteLine("2. Tablet");
            Console.WriteLine("3. SmartWatch");
            Console.WriteLine("0. Cancel");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input, please try again.");
            }

            switch (choice)
            {
                case 1:
                    addPhone();
                    break;
                case 2:
                    addTablet();
                    break;
                case 3:
                    addSmartWatch();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine();
        }

        public void RemoveProduct(AbstractGadget product)
        {
            _productStorage.RemoveProduct(product);
        }

        private void addPhone()
        {
            Console.WriteLine("Enter Phone Details:");
            Console.Write("Name: ");
            string phoneName = Console.ReadLine();

            Console.Write("Brand: ");
            string phoneBrand = Console.ReadLine();

            Console.Write("CPU Model: ");
            string phoneCPUModel = Console.ReadLine();

            Console.Write("GPU Model: ");
            string phoneGPUModel = Console.ReadLine();

            Console.Write("Display Technology: ");
            string phoneDisplayTech = Console.ReadLine();

            Console.Write("Battery Size: ");
            string phoneBatterySize = Console.ReadLine();

            Console.Write("Has Camera (True/False): ");
            string phoneHasCamera = Console.ReadLine();

            Console.Write("Price: ");
            string phonePrice = Console.ReadLine();

            AbstractPhone phone = new PhoneBuilder()
               .WithName<AbstractPhoneBuilder>(phoneName)
               .WithBrand<AbstractPhoneBuilder>(phoneBrand)
               .WithCPUModel<AbstractPhoneBuilder>(phoneCPUModel)
               .WithGPUModel<AbstractPhoneBuilder>(phoneGPUModel)
               .WithDisplayTechnology<AbstractPhoneBuilder>(phoneDisplayTech)
               .WithBatterySize<AbstractPhoneBuilder>(phoneBatterySize)
               .WithHasCamera<AbstractPhoneBuilder>(phoneHasCamera)
               .WithPrice<AbstractPhoneBuilder>(phonePrice)
               .SetMaxCallTime(20)
               .Build();

            _productStorage.AddProduct(phone);
            Console.WriteLine("Phone created!");
            Thread.Sleep(1000);
        }

        private void addTablet()
        {
            Console.WriteLine("Enter Tablet Details:");
            Console.Write("Name: ");
            string tabletName = Console.ReadLine();

            Console.Write("Brand: ");
            string tabletBrand = Console.ReadLine();

            Console.Write("CPU Model: ");
            string tabletCPUModel = Console.ReadLine();

            Console.Write("GPU Model: ");
            string tabletGPUModel = Console.ReadLine();

            Console.Write("Display Technology: ");
            string tabletDisplayTech = Console.ReadLine();

            Console.Write("Battery Size: ");
            string tabletBatterySize = Console.ReadLine();

            Console.Write("Has Camera (True/False): ");
            string tabletHasCamera = Console.ReadLine();

            Console.Write("Price: ");
            string tabletPrice = Console.ReadLine();

            Console.WriteLine("Does the tablet have stylus support? (True/False)");
            string hasStylusSupport = Console.ReadLine();

            AbstractTablet tablet = new TabletBuilder()
            .WithName<AbstractTabletBuilder>(tabletName)
            .WithBrand<AbstractTabletBuilder>(tabletBrand)
            .WithCPUModel<AbstractTabletBuilder>(tabletCPUModel)
            .WithGPUModel<AbstractTabletBuilder>(tabletGPUModel)
            .WithDisplayTechnology<AbstractTabletBuilder>(tabletDisplayTech)
            .WithBatterySize<AbstractTabletBuilder>(tabletBatterySize)
            .WithHasCamera<AbstractTabletBuilder>(tabletHasCamera)
            .WithPrice<AbstractTabletBuilder>(tabletPrice)
            .SetHasStylusSupport(Convert.ToBoolean(hasStylusSupport))
            .Build();

            _productStorage.AddProduct(tablet);
            Console.WriteLine("Tablet created!");
            Thread.Sleep(1000);
        }

        private void addSmartWatch()
        {
            Console.WriteLine("Enter Smart Watch Details:");
            Console.Write("Name: ");
            string smartWatchName = Console.ReadLine();

            Console.Write("Brand: ");
            string smartWatchBrand = Console.ReadLine();

            Console.Write("CPU Model: ");
            string smartWatchCPUModel = Console.ReadLine();

            Console.Write("GPU Model: ");
            string smartWatchGPUModel = Console.ReadLine();

            Console.Write("Display Technology: ");
            string smartWatchDisplayTech = Console.ReadLine();

            Console.Write("Battery Size: ");
            string smartWatchBatterySize = Console.ReadLine();

            Console.Write("Has GPS (True/False): ");
            string smartWatchHasGPS = Console.ReadLine();

            Console.Write("Price: ");
            string smartWatchPrice = Console.ReadLine();

            AbstractSmartWatch smartWatch = new SmartWatchBuilder()
                .WithName<AbstractSmartWatchBuilder>(smartWatchName)
                .WithBrand<AbstractSmartWatchBuilder>(smartWatchBrand)
                .WithCPUModel<AbstractSmartWatchBuilder>(smartWatchCPUModel)
                .WithGPUModel<AbstractSmartWatchBuilder>(smartWatchGPUModel)
                .WithDisplayTechnology<AbstractSmartWatchBuilder>(smartWatchDisplayTech)
                .WithBatterySize<AbstractSmartWatchBuilder>(smartWatchBatterySize)
                .WithHasCamera<AbstractSmartWatchBuilder>("False")
                .WithPrice<AbstractSmartWatchBuilder>(smartWatchPrice)
                .SetWithGPS(bool.Parse(smartWatchHasGPS))
                .Build();

            _productStorage.AddProduct(smartWatch);
            Console.WriteLine("SmartWatch created!");
            Thread.Sleep(1000);
        }
    }
}
