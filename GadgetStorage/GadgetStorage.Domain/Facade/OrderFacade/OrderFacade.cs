using GadgetStorage.Domain.Decorator.Components;
using GadgetStorage.Domain.Decorator.Decorators;
using GadgetStorage.Domain.Decorator;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GadgetStorage.Domain.SingletonServices.ProductsStorage;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using GadgetStorage.Domain.Adapter;
using System.Threading;

namespace GadgetStorage.Domain.Facade.OrderFacade
{
    public class OrderFacade : IOrderFacade
    {
        private readonly AbstractOrderStorage _orderStorage;
        private readonly AbstractProductStorage _productStorage;
        private readonly IConsolePrintUtils _consolePrintUtils;

        public OrderFacade(AbstractOrderStorage orderStorage, AbstractProductStorage productStorage, IConsolePrintUtils consolePrintUtils)
        {
            _orderStorage = orderStorage;
            _productStorage = productStorage;
            _consolePrintUtils = consolePrintUtils;
        }

        public void RegisterOrder()
        {
            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Register new order");
            Console.WriteLine();

            PrintStorageProducts();
            var id = GetSelectedProductId();
            var product = _productStorage.GetProductById(Convert.ToInt32(id));
            _productStorage.RemoveProduct(product);

            IOrder order = new BasicOrder(product);

            Console.Clear();
            Console.WriteLine("Basic order created!");

            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Register new order");
            _consolePrintUtils.PrintWithColour("\n Basic order created!\n");
            Console.WriteLine();
            _consolePrintUtils.PrintEmptyColourLine();
            Thread.Sleep(1500);

            order = AddAdditionalOptionToOrder(order);
            _orderStorage.AddOrder(order);
        }

        private string GetSelectedProductId()
        {
            while (true)
            {
                _consolePrintUtils.PrintWithColour("\nSelect product id: ");
                var id = Console.ReadLine();

                if (_productStorage.GetProductById(Convert.ToInt32(id)) == null)
                {
                    _consolePrintUtils.PrintWithColour("Invalid product id, please try again.", ConsoleColor.DarkRed);
                    continue;
                }

                return id;
            }
        }

        private IOrder AddAdditionalOptionToOrder(IOrder order)
        {
            while (true)
            {
                Console.Clear();
                _consolePrintUtils.PrintOnCenterWithColour("Register New Order");
                Console.WriteLine();
                _consolePrintUtils.PrintWithColour(" 1. Discount\n");
                _consolePrintUtils.PrintWithColour(" 2. Gift Wrapper\n");
                _consolePrintUtils.PrintWithColour(" 3. Shipping Fee\n");
                _consolePrintUtils.PrintWithColour(" 4. Warranty Fee\n");
                _consolePrintUtils.PrintWithColour(" 0. Finish\n");
                Console.WriteLine();
                _consolePrintUtils.PrintEmptyColourLine();
                Console.WriteLine();
                _consolePrintUtils.PrintWithColour("Please select additional option: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    _consolePrintUtils.PrintWithColour("Invalid input, please try again.", ConsoleColor.DarkRed);
                    _consolePrintUtils.PrintWithColour("\nPlease select additional option: ");
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        _consolePrintUtils.PrintWithColour("Enter Discount Percentage: ");
                        var discountPercentage = Console.ReadLine();
                        order = new DiscountDecorator(order, Convert.ToDouble(discountPercentage));
                        break;
                    case 2:
                        Console.Clear();
                        _consolePrintUtils.PrintWithColour("Enter Gift Wrapping Fee: ");
                        var giftWrappingFee = Console.ReadLine();
                        order = new GiftWrapperDecorator(order, Convert.ToDouble(giftWrappingFee));
                        break;
                    case 3:
                        Console.Clear();
                        _consolePrintUtils.PrintWithColour("Enter Shipping Fee: ");
                        var shippingFee = Console.ReadLine();
                        order = new ShippingFeeDecorator(order, Convert.ToDouble(shippingFee));
                        break;
                    case 4:
                        Console.Clear();
                        _consolePrintUtils.PrintWithColour("Enter Warranty Price: ");
                        var warrantyPrice = Console.ReadLine();
                        order = new WarrantyDecorator(order, Convert.ToDouble(warrantyPrice));
                        break;
                    case 0:
                        return order;
                    default:
                        _consolePrintUtils.PrintWithColour("Invalid choice, please try again.", ConsoleColor.DarkRed);
                        break;
                }
            }
        }

        private void PrintStorageProducts()
        {
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

            Console.WriteLine();
            _consolePrintUtils.PrintEmptyColourLine();
        }

        public void RemoveOrder(IOrder order)
        {
            _orderStorage.RemoveOrder(order);
        }

        public void PrintOrders()
        {
            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Available Orders List");
            Console.WriteLine();

            var availableOrders = _orderStorage.GetOrdersList();

            if (availableOrders.Count == 0)
            {
                _consolePrintUtils.PrintWithColour($" No orders available!\n\n", ConsoleColor.Red);
            }
            else
            {
                _consolePrintUtils.PrintWithColour("--------------------------------------------\n\n", ConsoleColor.DarkGray);

                foreach (var order in availableOrders)
                {
                    _consolePrintUtils.PrintWithColour($"ORDER ID: ", ConsoleColor.DarkGray);
                    _consolePrintUtils.PrintWithColour($"{order.GetHashCode()}", ConsoleColor.DarkGreen);
                    _consolePrintUtils.PrintWithColour("\nDETAILS:\n" + order.GetDescription(), ConsoleColor.DarkGray);
                    _consolePrintUtils.PrintWithColour("\nTOTAL PRICE: " + order.CalculateCost().ToString("f2") + "$\n", ConsoleColor.DarkGray);
                    _consolePrintUtils.PrintWithColour("\n--------------------------------------------\n\n", ConsoleColor.DarkGray);
                }
            }
            
            _consolePrintUtils.PrintEmptyColourLine();
            _consolePrintUtils.PrintWithColour("\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
}
