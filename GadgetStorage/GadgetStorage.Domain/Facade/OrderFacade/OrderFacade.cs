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
            Console.WriteLine("Register new order");

            PrintStorageProducts();
            var id = GetSelectedProductId();
            var product = _productStorage.GetProductById(Convert.ToInt32(id));
            _productStorage.RemoveProduct(product);

            IOrder order = new BasicOrder(product);

            Console.WriteLine("Basic order created!");

            order = AddAdditionalOptionToOrder(order);
            _orderStorage.AddOrder(order);
        }

        private string GetSelectedProductId()
        {
            while (true)
            {
                Console.Write("select product id: ");
                var id = Console.ReadLine();

                if (_productStorage.GetProductById(Convert.ToInt32(id)) == null)
                {
                    Console.WriteLine("Invalid product id, please try again.");
                    continue;
                }

                return id;
            }
        }

        private IOrder AddAdditionalOptionToOrder(IOrder order)
        {
            while (true)
            {
                Console.WriteLine("Please select additional option:");
                Console.WriteLine("1. Discount");
                Console.WriteLine("2. Gift Wrapper");
                Console.WriteLine("3. Shipping Fee");
                Console.WriteLine("4. Warranty Fee");
                Console.WriteLine("0. Finish");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input, please try again.");
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter Discount Percentage: ");
                        var discountPercentage = Console.ReadLine();
                        order = new DiscountDecorator(order, Convert.ToDouble(discountPercentage));
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter Gift Wrapping Fee: ");
                        var giftWrappingFee = Console.ReadLine();
                        order = new GiftWrapperDecorator(order, Convert.ToDouble(giftWrappingFee));
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter Shipping Fee: ");
                        var shippingFee = Console.ReadLine();
                        order = new ShippingFeeDecorator(order, Convert.ToDouble(shippingFee));
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Enter Warranty Price: ");
                        var warrantyPrice = Console.ReadLine();
                        order = new WarrantyDecorator(order, Convert.ToDouble(warrantyPrice));
                        break;
                    case 0:
                        return order;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private void PrintStorageProducts()
        {
            foreach (var gadget in _productStorage.GetProductsList())
            {
                Console.WriteLine("Id: {0} Name: {1}", gadget.Id, gadget.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Type any key to continue ...");
            Console.ReadLine();
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
