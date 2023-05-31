using GadgetStorage.Domain.Builders;
using GadgetStorage.Domain.Decorator;
using GadgetStorage.Domain.Decorator.Components;
using GadgetStorage.Domain.Decorator.Decorators;
using GadgetStorage.Domain.Entities;
using GadgetStorage.Domain.SingletonServices.OrdersStorage;
using GadgetStorage.Domain.SingletonServices.ProductsStorage;
using GadgetStorage.Domain.Template;

namespace GadgetStorage.Client
{
    public class Initialization
    {
        public void Run()
        {
            AbstractProductStorage productStorage = new InMemoryProductStorage();

            AbstractPhone phone = new PhoneBuilder()
            .WithName<AbstractPhoneBuilder>("iPhone 13")
            .WithBrand<AbstractPhoneBuilder>("Apple")
            .WithCPUModel<AbstractPhoneBuilder>("A15 Bionic")
            .WithGPUModel<AbstractPhoneBuilder>("Apple-designed")
            .WithDisplayTechnology<AbstractPhoneBuilder>("Super Retina XDR OLED")
            .WithBatterySize<AbstractPhoneBuilder>("3095 mAh")
            .WithHasCamera<AbstractPhoneBuilder>("True")
            .WithPrice<AbstractPhoneBuilder>("999")
            .SetMaxCallTime(20)
            .Build();
            productStorage.AddProduct(phone);

            phone = new PhoneBuilder()
            .WithName<AbstractPhoneBuilder>("Samsung Galaxy S21")
            .WithBrand<AbstractPhoneBuilder>("Samsung")
            .WithCPUModel<AbstractPhoneBuilder>("Exynos 2100")
            .WithGPUModel<AbstractPhoneBuilder>("Mali-G78 MP14")
            .WithDisplayTechnology<AbstractPhoneBuilder>("Dynamic AMOLED 2X")
            .WithBatterySize<AbstractPhoneBuilder>("4000 mAh")
            .WithHasCamera<AbstractPhoneBuilder>("True")
            .WithPrice<AbstractPhoneBuilder>("799")
            .SetMaxCallTime(25)
            .Build();
            productStorage.AddProduct(phone);

            phone = new PhoneBuilder()
            .WithName<AbstractPhoneBuilder>("Google Pixel 6")
            .WithBrand<AbstractPhoneBuilder>("Google")
            .WithCPUModel<AbstractPhoneBuilder>("Google Tensor")
            .WithGPUModel<AbstractPhoneBuilder>("Google Tensor")
            .WithDisplayTechnology<AbstractPhoneBuilder>("AMOLED")
            .WithBatterySize<AbstractPhoneBuilder>("4600 mAh")
            .WithHasCamera<AbstractPhoneBuilder>("True")
            .WithPrice<AbstractPhoneBuilder>("699")
            .SetMaxCallTime(30)
            .Build();
            productStorage.AddProduct(phone);

            phone = new PhoneBuilder()
            .WithName<AbstractPhoneBuilder>("OnePlus 9 Pro")
            .WithBrand<AbstractPhoneBuilder>("OnePlus")
            .WithCPUModel<AbstractPhoneBuilder>("Qualcomm Snapdragon 888")
            .WithGPUModel<AbstractPhoneBuilder>("Adreno 660")
            .WithDisplayTechnology<AbstractPhoneBuilder>("Fluid AMOLED")
            .WithBatterySize<AbstractPhoneBuilder>("4500 mAh")
            .WithHasCamera<AbstractPhoneBuilder>("True")
            .WithPrice<AbstractPhoneBuilder>("969")
            .SetMaxCallTime(27)
            .Build();
            productStorage.AddProduct(phone);


            AbstractSmartWatch smartWatch = new SmartWatchBuilder()
            .WithName<AbstractSmartWatchBuilder>("Apple Watch Series 7")
            .WithBrand<AbstractSmartWatchBuilder>("Apple")
            .WithCPUModel<AbstractSmartWatchBuilder>("S7 chip with 64-bit dual-core processor")
            .WithGPUModel<AbstractSmartWatchBuilder>("Apple-designed")
            .WithDisplayTechnology<AbstractSmartWatchBuilder>("Always-On Retina display")
            .WithBatterySize<AbstractSmartWatchBuilder>("303.8 mAh")
            .WithHasCamera<AbstractSmartWatchBuilder>("False")
            .WithPrice<AbstractSmartWatchBuilder>("399")
            .SetWithGPS(true)
            .Build();
            productStorage.AddProduct(smartWatch);

            smartWatch = new SmartWatchBuilder()
            .WithName<AbstractSmartWatchBuilder>("Samsung Galaxy Watch 4")
            .WithBrand<AbstractSmartWatchBuilder>("Samsung")
            .WithCPUModel<AbstractSmartWatchBuilder>("Exynos W920 Dual Core 1.18GHz")
            .WithGPUModel<AbstractSmartWatchBuilder>("Mali-G68")
            .WithDisplayTechnology<AbstractSmartWatchBuilder>("Super AMOLED")
            .WithBatterySize<AbstractSmartWatchBuilder>("361mAh")
            .WithHasCamera<AbstractSmartWatchBuilder>("False")
            .WithPrice<AbstractSmartWatchBuilder>("143")
            .SetWithGPS(true)
            .Build();
            productStorage.AddProduct(smartWatch);

            smartWatch = new SmartWatchBuilder()
            .WithName<AbstractSmartWatchBuilder>("Fitbit Sense")
            .WithBrand<AbstractSmartWatchBuilder>("Fitbit")
            .WithCPUModel<AbstractSmartWatchBuilder>("Fitbit chip A1")
            .WithGPUModel<AbstractSmartWatchBuilder>("Fitbit-designed")
            .WithDisplayTechnology<AbstractSmartWatchBuilder>("AMOLED")
            .WithBatterySize<AbstractSmartWatchBuilder>("250 mAh")
            .WithHasCamera<AbstractSmartWatchBuilder>("False")
            .WithPrice<AbstractSmartWatchBuilder>("299")
            .SetWithGPS(false)
            .Build();
            productStorage.AddProduct(smartWatch);

            smartWatch = new SmartWatchBuilder()
            .WithName<AbstractSmartWatchBuilder>("Apple Watch Series 6")
            .WithBrand<AbstractSmartWatchBuilder>("Apple")
            .WithCPUModel<AbstractSmartWatchBuilder>("S6 chip with 64-bit dual-core processor")
            .WithGPUModel<AbstractSmartWatchBuilder>("Apple-designed")
            .WithDisplayTechnology<AbstractSmartWatchBuilder>("Always-On Retina display")
            .WithBatterySize<AbstractSmartWatchBuilder>("303.8 mAh")
            .WithHasCamera<AbstractSmartWatchBuilder>("False")
            .WithPrice<AbstractSmartWatchBuilder>("399")
            .SetWithGPS(true)
            .Build();
            productStorage.AddProduct(smartWatch);


            AbstractTablet tablet = new TabletBuilder()
            .WithName<AbstractTabletBuilder>("iPad Pro 12.9-inch")
            .WithBrand<AbstractTabletBuilder>("Apple")
            .WithCPUModel<AbstractTabletBuilder>("M1 chip")
            .WithGPUModel<AbstractTabletBuilder>("Apple-designed")
            .WithDisplayTechnology<AbstractTabletBuilder>("Liquid Retina XDR")
            .WithBatterySize<AbstractTabletBuilder>("40.88 Wh")
            .WithHasCamera<AbstractTabletBuilder>("True")
            .WithPrice<AbstractTabletBuilder>("1099")
            .SetHasStylusSupport(true)
            .Build();
            productStorage.AddProduct(tablet);

            tablet = new TabletBuilder()
            .WithName<AbstractTabletBuilder>("iPad Pro 11-inch")
            .WithBrand<AbstractTabletBuilder>("Apple")
            .WithCPUModel<AbstractTabletBuilder>("M1 chip")
            .WithGPUModel<AbstractTabletBuilder>("Apple-designed")
            .WithDisplayTechnology<AbstractTabletBuilder>("Liquid Retina display")
            .WithBatterySize<AbstractTabletBuilder>("28.65 Wh")
            .WithHasCamera<AbstractTabletBuilder>("True")
            .WithPrice<AbstractTabletBuilder>("799")
            .SetHasStylusSupport(true)
            .Build();
            productStorage.AddProduct(tablet);

            tablet = new TabletBuilder()
            .WithName<AbstractTabletBuilder>("Samsung Galaxy Tab S7+")
            .WithBrand<AbstractTabletBuilder>("Samsung")
            .WithCPUModel<AbstractTabletBuilder>("Qualcomm Snapdragon 865 Plus")
            .WithGPUModel<AbstractTabletBuilder>("Adreno 650")
            .WithDisplayTechnology<AbstractTabletBuilder>("Super AMOLED Plus")
            .WithBatterySize<AbstractTabletBuilder>("10090 mAh")
            .WithHasCamera<AbstractTabletBuilder>("True")
            .WithPrice<AbstractTabletBuilder>("849")
            .SetHasStylusSupport(true)
            .Build();
            productStorage.AddProduct(tablet);

            tablet = new TabletBuilder()
            .WithName<AbstractTabletBuilder>("Microsoft Surface Pro 7")
            .WithBrand<AbstractTabletBuilder>("Microsoft")
            .WithCPUModel<AbstractTabletBuilder>("10th Gen Intel Core i5")
            .WithGPUModel<AbstractTabletBuilder>("Intel UHD Graphics")
            .WithDisplayTechnology<AbstractTabletBuilder>("PixelSense display")
            .WithBatterySize<AbstractTabletBuilder>("43.2 Wh")
            .WithHasCamera<AbstractTabletBuilder>("True")
            .WithPrice<AbstractTabletBuilder>("899")
            .SetHasStylusSupport(true)
            .Build();
            productStorage.AddProduct(tablet);

            //Console.WriteLine("Tablet created!");
            //Console.WriteLine();


            // Prototype Pattern
            //AbstractPhone phoneClone1 = phone.ShallowCopy();
            //AbstractPhone phoneClone2 = phone.Clone();

            //AbstractTablet tabletClone1 = tablet.ShallowCopy();
            //AbstractTablet tabletClone2 = tablet.Clone();

            //AbstractSmartWatch smartWatchClone1 = smartWatch.ShallowCopy();
            //AbstractSmartWatch smartWatchClone2 = smartWatch.Clone();
            //Console.WriteLine();

            //foreach (var gadget in AbstractStorage.GetInstance())
            //{
            //    Console.WriteLine("Id: {0} Name: {1}", gadget.Id, gadget.Name);
            //}
            //Console.WriteLine();


            // Factory Method Pattern
            //AbstractLogistics logistics;

            //logistics = new RoadLogistics();
            //logistics.MakeDelivery(phone);

            //logistics = new AirLogistics();
            //logistics.MakeDelivery(tablet);

            //logistics = new SeaLogistics();
            //logistics.MakeDelivery(smartWatch);



            // add a order in orders list
            IOrder order = new BasicOrder(phone);
            order = new DiscountDecorator(order, 15);
            order = new ShippingFeeDecorator(order, 89);
            order = new GiftWrapperDecorator(order, 19);
            AbstractOrderStorage orderStorage = new InMemoryOrderStorage(new BasicStoreOrderLogic());
            orderStorage.AddOrder(order);
        }
    }
}
