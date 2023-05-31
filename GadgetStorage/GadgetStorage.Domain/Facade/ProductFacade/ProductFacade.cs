using GadgetStorage.Domain.Adapter;
using GadgetStorage.Domain.Builders;
using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using GadgetStorage.Domain.SingletonServices.ProductsStorage;
using GadgetStorage.Domain.Strategy;
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
                    _consolePrintUtils.PrintWithColour(string.Format("Id: {0}\tName: {1} ({2}$)\n", gadget.Id, gadget.Name, gadget.Price), ConsoleColor.DarkGray);
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
            _consolePrintUtils.PrintOnCenterWithColour("Register New Product");
            Console.WriteLine();
            _consolePrintUtils.PrintWithColour(" 1. Phone\n");
            _consolePrintUtils.PrintWithColour(" 2. Tablet\n");
            _consolePrintUtils.PrintWithColour(" 3. SmartWatch\n");
            _consolePrintUtils.PrintWithColour(" 0. Cancel\n");
            Console.WriteLine();
            _consolePrintUtils.PrintEmptyColourLine();
            Console.WriteLine();
            _consolePrintUtils.PrintWithColour("Select what you want to add: ");


            int choice;
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    _consolePrintUtils.PrintWithColour("Invalid input, please try again.\n", ConsoleColor.DarkRed);
                    _consolePrintUtils.PrintWithColour("Select what you want to add: ");
                }

                int exit = 0;
                switch (choice)
                {
                    case 1:
                        addPhone();
                        exit = 1;
                        break;
                    case 2:
                        addTablet();
                        exit = 1;
                        break;
                    case 3:
                        addSmartWatch();
                        exit = 1;
                        break;
                    case 0:
                        return;
                    default:
                        _consolePrintUtils.PrintWithColour("Invalid input, please try again.\n", ConsoleColor.DarkRed);
                        _consolePrintUtils.PrintWithColour("Select what you want to add: ");
                        break;
                }
                if (exit == 1) break;
            }
        }

        public void RemoveProduct(AbstractGadget product)
        {
            _productStorage.RemoveProduct(product);
        }

        private void addPhone()
        {
            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Enter Phone Details");
            Console.WriteLine();
            _consolePrintUtils.PrintWithColour("Name: ");
            string phoneName = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Brand: ");
            string phoneBrand = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("CPU Model: ");
            string phoneCPUModel = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("GPU Model: ");
            string phoneGPUModel = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Display Technology: ");
            string phoneDisplayTech = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Battery Size: ");
            string phoneBatterySize = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Has Camera (True/False): ");
            string phoneHasCamera = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Price: ");
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
            Console.WriteLine();
            _consolePrintUtils.PrintOnCenterWithColour("Phone created!");
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        private void addTablet()
        {
            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Enter Tablet Details");
            Console.WriteLine();
            _consolePrintUtils.PrintWithColour("Name: ");
            string tabletName = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Brand: ");
            string tabletBrand = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("CPU Model: ");
            string tabletCPUModel = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("GPU Model: ");
            string tabletGPUModel = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Display Technology: ");
            string tabletDisplayTech = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Battery Size: ");
            string tabletBatterySize = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Has Camera (True/False): ");
            string tabletHasCamera = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Price: ");
            string tabletPrice = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Does the tablet have stylus support? (True/False)");
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
            Console.WriteLine();
            _consolePrintUtils.PrintOnCenterWithColour("Tablet created!");
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        private void addSmartWatch()
        {
            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Enter Smart Watch Details");
            Console.WriteLine();
            _consolePrintUtils.PrintWithColour("Name: ");
            string smartWatchName = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Brand: ");
            string smartWatchBrand = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("CPU Model: ");
            string smartWatchCPUModel = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("GPU Model: ");
            string smartWatchGPUModel = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Display Technology: ");
            string smartWatchDisplayTech = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Battery Size: ");
            string smartWatchBatterySize = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Has GPS (True/False): ");
            string smartWatchHasGPS = Console.ReadLine();

            _consolePrintUtils.PrintWithColour("Price: ");
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
            Console.WriteLine();
            _consolePrintUtils.PrintOnCenterWithColour("SmartWatch created!");
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        public void SortProducts()
        {
            string option;
            ISortStrategy strategy = null;

            while (true)
            {
                Console.Clear();
                _consolePrintUtils.PrintOnCenterWithColour("Sort Products");
                Console.WriteLine();

                _consolePrintUtils.PrintWithColour("1 - Name Sort Strategy\n");
                _consolePrintUtils.PrintWithColour("2 - Price Sort Strategy\n");
                _consolePrintUtils.PrintWithColour("0 - Cancel\n");

                Console.WriteLine();
                _consolePrintUtils.PrintEmptyColourLine();
                _consolePrintUtils.PrintWithColour("\nSelect option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        strategy = new NameSortStrategy();
                        break;
                    case "2":
                        strategy = new PriceSortStrategy();
                        break;
                }
                
                if (strategy != null)
                {
                    break;
                }
            }
            
            AbstractSorter sorter = new Sorter(strategy);
            sorter.Sort(_productStorage.GetProductsList());

            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Sort Products");
            _consolePrintUtils.PrintWithColour("\n Products was sorted successfully!\n");
            Console.WriteLine();
            _consolePrintUtils.PrintEmptyColourLine();
            Thread.Sleep(1500);
        }
    }
}
