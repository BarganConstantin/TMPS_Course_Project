using GadgetStorage.Domain.Adapter;
using GadgetStorage.Domain.Composite;
using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.Decorator.Components;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Facade.PackFacade
{
    public class PackFacade : IPackFacade
    {
        private readonly AbstractOrderStorage _orderStorage;
        private readonly IConsolePrintUtils _consolePrintUtils;

        public PackFacade(AbstractOrderStorage orderStorage, IConsolePrintUtils consolePrintUtils) 
        {
            _orderStorage = orderStorage;
            _consolePrintUtils = consolePrintUtils;
        }

        public ParcelComponent CreateParcelForDelivery()
        {
            var parcel = createPack(0);
            int packCount = 1;
            string destinationPackId;

            while (true)
            {
                displayParcelComponents(parcel);

                printPackMenu();

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        displayParcelComponents(parcel);

                        _consolePrintUtils.PrintOnCenterWithColour("Adding new order");
                        _consolePrintUtils.PrintWithColour("\nEnter destination pack id: ");

                        destinationPackId = Console.ReadLine();
                        addOrderInParcel(parcel, Convert.ToInt32(destinationPackId));

                        break;

                    case "2":
                        displayParcelComponents(parcel);

                        _consolePrintUtils.PrintOnCenterWithColour("Adding new pack");
                        _consolePrintUtils.PrintWithColour("\nEnter destination pack id: ");

                        destinationPackId = Console.ReadLine();
                        addPackInParcel(parcel, Convert.ToInt32(destinationPackId), packCount);
                        packCount++;

                        break;

                    case "0":
                        return parcel;
                        
                    default:
                        Console.WriteLine("Error, try again !");
                        break;
                }
            }
        }

        private void displayParcelComponents(ParcelComponent parcel)
        {
            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Preparing parcel for delivery");
            parcel.Display();
            Console.WriteLine();
        }

        private void printPackMenu()
        {
            _consolePrintUtils.PrintEmptyColourLine();

            _consolePrintUtils.PrintWithColour("\n 1 - Add order in parcel\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintWithColour(" 2 - Add pack in parcel\n", ConsoleColor.DarkBlue);
            _consolePrintUtils.PrintWithColour(" 0 - Finish packing parcel\n\n", ConsoleColor.DarkBlue);
            
            _consolePrintUtils.PrintEmptyColourLine();

            _consolePrintUtils.PrintWithColour("\nSelect option: ");
        }

        private void addOrderInParcel(ParcelComponent parcel, int destinationPackId)
        {
            var order = getOrderForPack();
            if (order == null) 
            { 
                return; 
            }

            _orderStorage.RemoveOrder(order);
            var product = new Product(order);

            addPackInParcelById(parcel, product, destinationPackId);
        }

        private void addPackInParcel(ParcelComponent parcel, int destinationPackId, int newPackId)
        {
            var pack = createPack(newPackId);
            addPackInParcelById(parcel, pack, destinationPackId);
        }

        private IOrder getOrderForPack()
        {
            Console.Clear();
            _consolePrintUtils.PrintOnCenterWithColour("Selecting order for delivery");
            Console.WriteLine();

            var availableOrders = _orderStorage.GetOrdersList();

            if (availableOrders.Count == 0) 
            {
                _consolePrintUtils.PrintWithColour($" No orders available!\n\n", ConsoleColor.Red);
                _consolePrintUtils.PrintEmptyColourLine();
                _consolePrintUtils.PrintWithColour("\nPress any key to continue ...");
                Console.ReadKey();
                return null;
            }
            _consolePrintUtils.PrintWithColour("--------------------------------------------\n\n", ConsoleColor.DarkGray);

            foreach (var order in availableOrders)
            {
                _consolePrintUtils.PrintWithColour($"ORDER ID: ", ConsoleColor.DarkGray);
                _consolePrintUtils.PrintWithColour($"{order.GetHashCode()}", ConsoleColor.DarkGreen);
                _consolePrintUtils.PrintWithColour("\nDETAILS:\n" + order.GetDescription(), ConsoleColor.DarkGray);
                _consolePrintUtils.PrintWithColour("\nTOTAL PRICE: " + order.CalculateCost().ToString("f2") + "$\n", ConsoleColor.DarkGray);
                _consolePrintUtils.PrintWithColour("\n--------------------------------------------\n\n", ConsoleColor.DarkGray);
            }

            _consolePrintUtils.PrintEmptyColourLine();

            while (true)
            {
                _consolePrintUtils.PrintWithColour("\nEnter order ID: ");

                string orderID = Console.ReadLine();

                foreach (var order in _orderStorage.GetOrdersList())
                {
                    if (order.GetHashCode() == Convert.ToInt32(orderID))
                    {
                        return order;
                    }
                }
                _consolePrintUtils.PrintWithColour($"Order with ID: {orderID} not found, try again!\n", ConsoleColor.Red);
            }
        }

        private ParcelComponent createPack(int id)
        {
            return new Pack(id);
        }

        private void addPackInParcelById(ParcelComponent parcel, ParcelComponent newComponent, int packId)
        {
            ParcelComponent pack = getPackFromParcelById(parcel, packId);
            if (pack != null) pack.Add(newComponent);
        }

        private ParcelComponent getPackFromParcelById(ParcelComponent parcel, int packId)
        {
            if (parcel.IsPack() == false) return null;
            if (parcel.Id == packId) return parcel;

            foreach (ParcelComponent component in parcel.GetChildrens())
            {
                if (component.IsPack())
                {
                    if (component.Id == packId)
                    {
                        return component;
                    }
                    else
                    {
                        var result = getPackFromParcelById(component, packId);
                        if (result != null) return result;
                    }
                }
            }

            return null;
        }
    }
}
