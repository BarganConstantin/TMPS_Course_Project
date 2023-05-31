# 🎓 Design Patterns Course Project
Course Project for Software Design Techniques and Mechanisms course at Technical University of Moldova

# Table of Contents

1. [Introduction](#introduction)
2. [Creational Design Patterns](#creational-design-patterns)
   - [Builder Pattern](#Builder-Pattern)🏗️
   - [Prototype Pattern](#Prototype-Pattern) 🧬
   - [Singleton Pattern](#Singleton-Pattern) 🔒
   - [Factory Method Pattern](#Factory-Method-Pattern) 🏭
3. [Structural Design Patterns](#Structural-Design-Patterns)
   - [Decorator Pattern](#Decorator-Pattern) 🎨
   - [Composite Pattern](#Composite-Pattern) 🌳
   - [Facade Pattern](#Facade-Pattern) 🏰
   - [Adapter Pattern](#Adapter-Pattern) 🔌
4. [Behavioral Design Patterns](#Behavioral-Design-Patterns)
   - [Iterator Pattern](#Iterator-Pattern)🔍
   - [Strategy Pattern](#Strategy-Pattern) 💡
   - [Template Method Pattern](#Template-Method-Pattern)📝
5. [Implementation](#Implementation)
6. [Conclusion](#Conclusion)

# Introduction

The GadgetStorage Application is a comprehensive and efficient system designed to manage gadgets, including phones, smartwatches, and tablets. In today's technology-driven world, the demand for gadgets is constantly increasing, and organizations need a robust solution to handle gadget creation, storage management, and order processing effectively. This project aims to address these challenges by incorporating a range of design patterns to create a flexible, maintainable, and extensible codebase.

In this project, we will explore various design patterns and their implementation within the GadgetStorage Application. Design patterns are proven solutions to recurring software design problems, offering developers a set of best practices and guidelines for creating high-quality, reusable, and modular code. By utilizing design patterns, we can achieve better separation of concerns, improve code organization, enhance code reusability, and facilitate future system modifications and extensions.

The project focuses on several categories of design patterns, including creational, structural, and behavioral patterns. Each category addresses different aspects of the application, such as gadget creation, storage management, and order processing, providing elegant and efficient solutions to specific challenges.

The implementation of design patterns in the GadgetStorage Application demonstrates the practical application and benefits of using design patterns in real-world scenarios. By studying these patterns, developers can gain valuable insights into software design principles and improve their problem-solving skills.

In the creational design patterns section, we explore the Builder pattern, which facilitates the construction of complex objects with different configurations. We also delve into the Prototype pattern, which enables the creation of new objects by cloning existing ones.

The structural design patterns section covers the Decorator pattern, which allows the dynamic addition of functionalities to objects, and the Composite pattern, which treats groups of objects as a single entity.

Moving on to the behavioral design patterns, we discuss the Iterator pattern, which provides a way to access the elements of an aggregate object sequentially, and the Strategy pattern, which enables the interchangeability of algorithms within an object.

The project concludes with a detailed analysis of the implemented design patterns and their impact on the GadgetStorage Application. We discuss the benefits, challenges, and considerations associated with each pattern and provide insights into their practical use and applicability in real-world software development.

By studying and implementing these design patterns, developers can enhance their software design skills, improve code quality, and create applications that are modular, flexible, and maintainable. The GadgetStorage Application serves as a practical demonstration of how design patterns can be effectively applied to solve complex problems and create robust software systems.

In the subsequent sections of this documentation, we will delve into the implementation details of each design pattern within the GadgetStorage Application. Through code examples, diagrams, and explanations, we will provide a comprehensive understanding of the design patterns and their impact on the application's architecture.

Let's embark on this journey of exploring design patterns and their practical application in the GadgetStorage Application, gaining valuable insights into software design principles and honing our skills as developers.

Now, let's dive into the implementation details of the GadgetStorage Application and explore each design pattern in-depth.

# 🛠️ Creational Design Patterns

Creational design patterns deal with object creation mechanisms, providing solutions to creating objects that are flexible, extensible, and maintainable. These patterns emphasize decoupling the client code from the specific classes and configurations used to create objects. By utilizing creational design patterns, developers can achieve more modular and reusable code, allowing for easy adaptation to changing requirements and reducing the dependency on concrete implementations.

The creational design patterns covered in this project offer solutions to different object creation scenarios. The Builder Pattern enables the construction of complex objects by separating the construction process from the object representation. The Prototype Pattern allows for the creation of new objects by cloning existing ones. The Factory Method Pattern provides an interface for creating objects, allowing subclasses to alter the type of objects to be created. Lastly, the Singleton Pattern ensures that there is only one instance of a class created and that it is globally accessible.

Now, let's delve into each creational design pattern implemented in the GadgetStorage application, explore the problems they solve, understand their benefits, and examine their implementation details.

## 🏗️ Builder Pattern

The Builder pattern is a creational design pattern that allows the construction of complex objects step by step. It provides a flexible solution for creating objects that require different configurations or combinations of components. In the GadgetStorage application, the Builder pattern is utilized to construct gadgets such as phones, smartwatches, and tablets with various specifications.

To implement the Builder pattern, we have defined an abstract class called `AbstractGadgetBuilder` that serves as the base builder for all gadgets. This class provides a set of methods to set different properties of the gadget, such as name, brand, CPU model, GPU model, display technology, battery size, camera presence, price, and color. Each method returns the builder instance itself, allowing for method chaining and a fluent interface.

Additionally, we have three concrete builder classes: `PhoneBuilder`, `SmartWatchBuilder`, and `TabletBuilder`, which inherit from the `AbstractGadgetBuilder` class. These builder classes provide specific methods to set additional properties specific to each gadget type.

For example, the `AbstractPhoneBuilder` class extends `AbstractGadgetBuilder` and introduces a `SetMaxCallTime` method to set the maximum call time property of a phone. Similarly, the `AbstractSmartWatchBuilder` class introduces a `SetWithGPS` method to set the GPS presence property of a smartwatch. The `AbstractTabletBuilder` class introduces a `SetHasStylusSupport` method to set the stylus support property of a tablet.

To create a specific gadget, such as a phone, we use the corresponding builder class (`PhoneBuilder` in this case). We can then chain the method calls to set the desired properties of the phone. Finally, we call the `Build` method on the builder instance to obtain the fully constructed phone object.

Here's an example of how the Builder pattern is used to create a phone in the GadgetStorage application:

```csharp
AbstractPhoneBuilder phoneBuilder = new PhoneBuilder();
AbstractPhone phone = phoneBuilder
    .WithName("Phone Model X")
    .WithBrand("ABC Corporation")
    .WithCPUModel("Snapdragon 888")
    .WithGPUModel("Adreno 660")
    .WithDisplayTechnology("AMOLED")
    .WithBatterySize("4000mAh")
    .WithHasCamera("Yes")
    .WithPrice("$999")
    .SetMaxCallTime(60)
    .Build();
```

In the above example, we first instantiate a `PhoneBuilder` object and then use the chain of method calls to set the desired properties of the phone. Finally, we call the `Build` method to obtain the fully constructed `AbstractPhone` object.

The Builder pattern provides several benefits in the GadgetStorage application. It allows us to construct gadgets with complex configurations while keeping the construction code separate from the final object's representation. It enables us to create different variations of gadgets by using different builder classes and method combinations. It also improves code readability and maintainability by providing a fluent and intuitive interface for setting object properties.

To visualize the implementation of the Builder pattern in the GadgetStorage application, the following UML diagram illustrates the relationships between the builder classes and their interactions:

![Builder Pattern UML Diagram](https://chat.openai.com/c/path_to_builder_pattern_uml_diagram.png)

In the diagram, `AbstractGadgetBuilder` serves as the abstract builder class, while the concrete builder classes (`PhoneBuilder`, `SmartWatchBuilder`, and `TabletBuilder`) implement the specific construction logic for each gadget type. The product classes (`AbstractPhone`, `AbstractSmartWatch`, and `AbstractTablet`) represent the final constructed objects.

By utilizing the Builder pattern, the GadgetStorage application achieves a modular and flexible approach to constructing gadgets, allowing for easy addition of new gadget types and configurations in the future.

## 🧬 Prototype Pattern

The Prototype pattern is a creational design pattern that allows objects to be created by cloning existing objects. It provides a way to create new objects by copying an existing object's state, without the need for explicitly invoking their constructors. In the GadgetStorage application, the Prototype pattern is implemented using interfaces and classes specific to each gadget type, namely `IPhonePrototype`, `ISmartWatchPrototype`, and `ITabletPrototype`.

The implementation of the Prototype pattern in the GadgetStorage application follows a similar structure for each gadget type. Let's explore the implementation for each prototype interface and class:

``` c#
public interface IPhonePrototype
{
    AbstractPhone Clone(AbstractPhone prototype);
}

public class PhonePrototype : IPhonePrototype
{
    public AbstractPhone Clone(AbstractPhone prototype)
    {
        AbstractPhoneBuilder builder = new PhoneBuilder();
        AbstractPhone phone = builder
            .WithName<AbstractPhoneBuilder>(prototype.Name)
            .WithBrand<AbstractPhoneBuilder>(prototype.Brand)
            .WithCPUModel<AbstractPhoneBuilder>(prototype.CPUModel)
            .WithGPUModel<AbstractPhoneBuilder>(prototype.GPUModel)
            .WithDisplayTechnology<AbstractPhoneBuilder>(prototype.DisplayTechnology)
            .WithBatterySize<AbstractPhoneBuilder>(prototype.BatterySize)
            .WithHasCamera<AbstractPhoneBuilder>(prototype.HasCamera)
            .WithPrice<AbstractPhoneBuilder>(prototype.Price)
            .SetMaxCallTime(prototype.MaxCallTime)
            .Build();
        return phone;
    }
}
```

In the above code snippet, we define the `IPhonePrototype` interface with a single method `Clone`, which takes an `AbstractPhone` object as a parameter and returns a cloned instance of the phone. The `PhonePrototype` class implements this interface and provides the cloning logic specific to the phone.

Similarly, we have `ISmartWatchPrototype` and `ITabletPrototype` interfaces, along with their respective implementation classes `SmartWatchPrototype` and `TabletPrototype`. These classes contain the cloning logic for the smartwatch and tablet gadgets, using the appropriate builder classes (`SmartWatchBuilder` and `TabletBuilder`) to create the cloned objects.

To clone an object using the Prototype pattern, we can instantiate the respective prototype class (`PhonePrototype`, `SmartWatchPrototype`, or `TabletPrototype`) and then call the `Clone` method with the object to be cloned as a parameter. The cloning process involves creating a new instance of the appropriate builder class, setting the properties of the builder based on the prototype object, and finally calling the `Build` method on the builder to obtain the cloned gadget object.

The Prototype pattern provides several benefits in the GadgetStorage application. It allows us to create new gadgets by cloning existing ones, avoiding the need to create objects from scratch. It provides a way to create variations of gadgets with different property values while keeping the construction logic centralized in the builder classes. It also improves performance by avoiding the overhead of repeated object initialization.

To visualize the implementation of the Prototype pattern in the GadgetStorage application, you can refer to the UML diagram below:

![Prototype Pattern UML Diagram](https://chat.openai.com/c/path_to_prototype_pattern_uml_diagram.png)

The diagram illustrates the relationships between the prototype interfaces (`IPhonePrototype`, `ISmartWatchPrototype`, `ITabletPrototype`) and their corresponding implementation classes (`PhonePrototype`, `SmartWatchPrototype`, `TabletPrototype`). The builder classes (`PhoneBuilder`, `SmartWatchBuilder`, `TabletBuilder`) are responsible for constructing the cloned objects based on the prototype's properties.

By utilizing the Prototype pattern, the GadgetStorage application achieves a flexible and efficient way of creating new gadgets by cloning existing ones. This design approach simplifies the process of adding new gadget types and configurations in the future.

## 🔒 Singleton Pattern

The Singleton pattern is a creational design pattern that ensures the existence of only one instance of a class and provides a global point of access to it. It is useful in situations where you want to restrict the instantiation of a class to a single object, ensuring that all code references the same instance.

In the GadgetStorage application, the Singleton pattern is implemented in the `AbstractOrderStorage` and `AbstractProductStorage` classes to ensure that there is only one instance of the order and product storage respectively.

Let's take a closer look at the `AbstractOrderStorage` class as an example. It contains a private static `List<IOrder>` field `_orders` and a private static object called `padlock`. The `GetInstance()` method is a protected method that provides access to the `_orders` list.

The `GetInstance()` method uses double-checked locking to ensure that only one instance of the `_orders` list is created. It first checks if `_orders` is null and, if so, acquires a lock using the `padlock` object. This is done to prevent multiple threads from accessing the `_orders` list simultaneously during initialization. Once inside the locked section, it checks `_orders` again to ensure it is still null before creating a new instance of the list.

The `AbstractOrderStorage` class also includes abstract methods for managing orders, such as `GetOrdersList()`, `AddOrder()`, and `RemoveOrder()`, which are implemented in the concrete `InMemoryOrderStorage` class. The `InMemoryOrderStorage` class inherits from `AbstractOrderStorage` and utilizes the `GetInstance()` method to access the singleton instance of the `_orders` list.

Here's an example of how the Singleton pattern is used in the GadgetStorage application:

```csharp
InMemoryOrderStorage orderStorage = new InMemoryOrderStorage();
orderStorage.AddOrder(order1);
orderStorage.AddOrder(order2);
List<IOrder> orders = orderStorage.GetOrdersList();
```

In the above example, we create an instance of the `InMemoryOrderStorage` class. When we call the `AddOrder` method, it internally uses the `GetInstance()` method to access the singleton `_orders` list and adds the order to it. Similarly, when we call the `GetOrdersList` method, it also uses the `GetInstance()` method to retrieve the singleton `_orders` list.

The same Singleton pattern implementation is applied to the `AbstractProductStorage` and `InMemoryProductStorage` classes, ensuring a single instance of the `_gadgets` list for storing products.

To visualize the implementation of the Singleton pattern in the GadgetStorage application, the following UML diagram illustrates the relationships between the storage classes and their interactions:

![Singleton Pattern UML Diagram](https://chat.openai.com/c/path_to_singleton_pattern_uml_diagram.png)

In the diagram, `AbstractOrderStorage` and `AbstractProductStorage` serve as the singleton classes that manage the instances of the `_orders` and `_gadgets` lists respectively. The concrete classes, `InMemoryOrderStorage` and `InMemoryProductStorage`, implement the specific storage logic and utilize the singleton instance.

By using the Singleton pattern, the GadgetStorage application ensures that there is only one instance of the order and product storage, allowing multiple parts of the application to access and modify the same data. It provides a centralized and globally accessible storage solution while avoiding the overhead of creating multiple instances.

## 🏭 Factory Method Pattern

The Factory Method pattern is a creational design pattern that provides an interface for creating objects but lets subclasses decide which class to instantiate. It encapsulates the object creation logic in a separate method, allowing subclasses to override the method to create objects of different types.

In the GadgetDelivery application, the Factory Method pattern is implemented in the `AbstractLogistics` class and its subclasses, such as `AirLogistics`, `RoadLogistics`, and `SeaLogistics`. The `createTransport()` method in the `AbstractLogistics` class is the factory method, which is responsible for creating instances of the `ITransport` interface.

The `AbstractLogistics` class contains a `MakeDelivery()` method that utilizes the factory method. It creates an instance of `ITransport` using the `createTransport()` method and then calls the `MakeDelivery()` method on the created transport object to perform the delivery.

Each subclass of `AbstractLogistics` overrides the `createTransport()` method to create a specific type of transport, such as a `Plane`, `Truck`, or `Ship`. These subclasses take an instance of `AbstractOrderStorage` as a constructor parameter, indicating a dependency on order storage.

The `ITransport` interface defines the common method `MakeDelivery()` that all transport types must implement.

Here's an example of how the Factory Method pattern is used in the GadgetDelivery application:

```csharp
AbstractLogistics logistics = new AirLogistics(orderStorage);
logistics.MakeDelivery(parcel);
```

In the above example, we create an instance of the `AirLogistics` class, which is a subclass of `AbstractLogistics`. The `AirLogistics` constructor takes an instance of `AbstractOrderStorage` as a parameter. When we call the `MakeDelivery` method on the `logistics` object, it internally calls the `createTransport` method, which creates a `Plane` object with the provided order storage and performs the delivery using the plane.

The same pattern is applied to the `RoadLogistics` and `SeaLogistics` classes, which create `Truck` and `Ship` objects respectively.

To visualize the implementation of the Factory Method pattern in the GadgetDelivery application, the following UML diagram illustrates the relationships between the logistics and transport classes:

![Factory Method Pattern UML Diagram](https://chat.openai.com/c/path_to_factory_method_uml_diagram.png)

In the diagram, `AbstractLogistics` serves as the creator class with the factory method `createTransport()`. The concrete creator classes, such as `AirLogistics`, `RoadLogistics`, and `SeaLogistics`, override the factory method to create specific transport objects. The transport classes, `Plane`, `Truck`, and `Ship`, implement the `ITransport` interface.

By using the Factory Method pattern, the GadgetDelivery application decouples the logistics and transport creation logic. It allows new types of transport to be added without modifying the existing code, as the specific transport creation is delegated to subclasses.

# 🏗️ Structural Design Patterns

Structural design patterns are an essential part of software design that focus on the organization and composition of classes and objects. These patterns help create flexible and efficient systems by defining relationships between objects, allowing them to work together in a coherent and scalable manner.

The primary goal of structural design patterns is to simplify the design and implementation of complex systems by providing reusable solutions to common design problems. These patterns address the arrangement and interaction between classes, enabling developers to create robust and maintainable code.

Structural design patterns often involve the use of inheritance, composition, and interfaces to establish relationships between classes. They facilitate code reusability, modularity, and flexibility, making it easier to extend and modify the system as requirements change.

By applying structural design patterns, developers can achieve better code organization, improve system performance, and enhance code maintainability. These patterns provide a higher level of abstraction, allowing developers to focus on the overall structure and behavior of their software rather than getting lost in implementation details.

Now, let's delve into each structural design pattern implemented in the GadgetStorage application, explore the problems they solve, understand their benefits, and examine their implementation details.

## 🎨 Decorator Pattern

The Decorator pattern is a structural design pattern that allows behavior to be added to an individual object dynamically. It provides a flexible alternative to subclassing for extending functionality.

In the GadgetDelivery application, the Decorator pattern is implemented to enhance the functionality of the `BasicOrder` class by adding additional features and modifying existing behavior. The `IOrder` interface represents the basic order functionality, and the `BasicOrder` class is the core implementation that represents a basic order without any additional features.

The Decorator pattern introduces the `OrderDecorator` abstract class, which serves as the base decorator. It implements the `IOrder` interface and contains a reference to an instance of `IOrder`. The decorators, such as `DiscountDecorator`, `GiftWrapperDecorator`, `ShippingFeeDecorator`, and `WarrantyDecorator`, extend the `OrderDecorator` class and provide specific additional features.

Each decorator class adds its own behavior by overriding the `GetDescription()` and `CalculateCost()` methods of the base decorator. They call the corresponding methods on the wrapped `_order` object and modify the result by incorporating the additional functionality.

Here's an example of how the Decorator pattern is used in the GadgetDelivery application:

``` csharp
IOrder order = new BasicOrder(product);
order = new DiscountDecorator(order, 10); // Apply a discount of 10%
order = new GiftWrapperDecorator(order, 5); // Add gift wrapping with a fee of $5
order = new ShippingFeeDecorator(order, 3); // Add a shipping fee of $3
order = new WarrantyDecorator(order, 15); // Add a warranty with a price of $15

string description = order.GetDescription();
double totalCost = order.CalculateCost();
```

In the above example, we start with a `BasicOrder` object representing the core order. Then we apply different decorators to modify the order. The `GetDescription()` method of each decorator is called to obtain the description of the order, which includes the description of the wrapped order and the additional features. Similarly, the `CalculateCost()` method is used to calculate the total cost of the order, taking into account the cost of the wrapped order and the added features.

By using the Decorator pattern, the GadgetDelivery application allows for flexible customization of orders. New decorators can be added easily without modifying the existing code. It also provides a clear separation between the core functionality and the added features.

To visualize the implementation of the Decorator pattern in the GadgetDelivery application, the following UML diagram illustrates the relationships between the order and decorator classes:

![Decorator Pattern UML Diagram](https://chat.openai.com/c/path_to_decorator_uml_diagram.png)

In the diagram, `IOrder` represents the interface for orders, `BasicOrder` is the core implementation, and `OrderDecorator` is the base decorator class implementing the `IOrder` interface. The concrete decorators, such as `DiscountDecorator`, `GiftWrapperDecorator`, `ShippingFeeDecorator`, and `WarrantyDecorator`, extend the `OrderDecorator` class and modify the behavior by adding features.

## 🌳 Composite Pattern

The Composite pattern is a structural design pattern that allows you to compose objects into tree-like structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly.

In the GadgetDelivery application, the Composite pattern is used to represent the structure of parcels and packs that contain multiple components. The `ParcelComponent` class serves as the base component class, representing either a single product or a pack of multiple components. The `Product` class extends `ParcelComponent` and represents a single product, while the `Pack` class represents a pack that can contain multiple components.

The `ParcelComponent` class defines common methods and properties for both products and packs. It includes methods like `Add`, `Remove`, `Display`, and `GetChildrens` that allow components to be added, removed, displayed in a hierarchical manner, and retrieved. The `Product` class, representing a single product, implements these methods in a way that is appropriate for a leaf node in the hierarchy. The `Pack` class, representing a pack of components, uses a list to store its children components and implements the methods to handle adding, removing, and displaying the components.

To visualize the implementation of the Composite pattern in the GadgetDelivery application, the following UML diagram illustrates the relationships between the component classes:

![Composite Pattern UML Diagram](https://chat.openai.com/c/path_to_factory_method_uml_diagram.png)

In the diagram, `ParcelComponent` is the base component class, `Product` is the leaf component class representing a single product, and `Pack` is the composite component class representing a pack of components.

Here's an example of how the Composite pattern is used in the GadgetDelivery application:

```csharp
// Creating products
IOrder order1 = new BasicOrder(product1);
IOrder order2 = new BasicOrder(product2);

// Creating packs
ParcelComponent pack1 = new Pack(1);
pack1.Add(new Product(order1));
pack1.Add(new Product(order2));

ParcelComponent pack2 = new Pack(2);
pack2.Add(new Product(order1));
pack2.Add(new Product(order2));

// Adding packs to another pack
ParcelComponent mainPack = new Pack(3);
mainPack.Add(pack1);
mainPack.Add(pack2);

// Displaying the structure
mainPack.Display();
```

In the above example, we create two products (`order1` and `order2`). Then we create two packs (`pack1` and `pack2`) and add the products to the packs. Finally, we create a main pack (`mainPack`) and add the packs to it. The `Display()` method is called on the `mainPack` to display the hierarchical structure of the components.

By using the Composite pattern, the GadgetDelivery application can treat individual products and packs uniformly, allowing for the creation of complex structures. It enables the application to work with the components and their compositions in a consistent manner.

## 🏰 Facade Pattern

The Facade pattern provides a simplified interface to a complex subsystem, making it easier to use for clients. This pattern is useful when you want to hide the complexity of a system and provide a simplified interface to its functionality.

In the provided code, we have implemented the Facade pattern to provide a simplified interface to two subsystems: product management and order management. We have created two Facade classes, `ProductFacade` and `OrderFacade`, that provide simplified interfaces to the underlying storage classes.

The `ProductFacade` provides three methods: `RegisterProduct()`, `RemoveProduct()`, and `PrintProducts()`, which allow clients to register new products, remove existing products, and print a list of all products, respectively.

The `OrderFacade` provides three methods: `RegisterOrder()`, `RemoveOrder()`, and `PrintOrders()`, which allow clients to register new orders, remove existing orders, and print a list of all orders, respectively.

By providing these simplified interfaces, clients can use the functionality of the subsystems without having to know all the details of the underlying storage classes. This reduces the dependence between the client and the services, making it easier to maintain and modify the code in the future.

Below is a UML diagram that illustrates the structure of the Facade pattern in this project:

![Composite Pattern UML Diagram](https://chat.openai.com/c/path_to_factory_method_uml_diagram.png)

Here's an example of how the Facade pattern is used in the GadgetDelivery application:

```csharp
public class RegisterProductCommand : ICommand
    {
        private readonly IProductFacade _productFacade;
        public RegisterProductCommand(IProductFacade productFacade)
        {
            _productFacade = productFacade;
        }

        public void Execute()
        {
            _productFacade.RegisterProduct();
        }
    }
```

By providing these simplified interfaces, clients can use the functionality of the subsystems without having to know all the details of the underlying storage classes. This reduces the dependence between the client and the services, making it easier to maintain and modify the code in the future.

## 🔌 Adapter Pattern

The Adapter pattern is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge between two incompatible interfaces, converting the interface of one object into another interface that clients expect.

In the GadgetDelivery application, the Adapter pattern is used to adapt the `IConsolePrintUtils` interface to the `IConsoleUtils` interface. The `IConsolePrintUtils` interface represents a set of print utility methods for the console, while the `IConsoleUtils` interface represents a different set of console utility methods.

The `ConsolePrintUtilsAdapter` class serves as the adapter and implements the `IConsolePrintUtils` interface. It takes an instance of `IConsoleUtils` in its constructor, allowing it to interact with the existing console utility methods.

The adapter class delegates the calls from the `IConsolePrintUtils` methods to the corresponding methods of the `IConsoleUtils` instance. By doing so, it adapts the interface of `IConsolePrintUtils` to match the interface expected by the clients.

To visualize the implementation of the Adapter pattern in the GadgetDelivery application, the following UML diagram illustrates the relationships between the adapter and utility interfaces:

![Adpater Pattern UML Diagram](https://chat.openai.com/c/path_to_factory_method_uml_diagram.png)

In the diagram, `IConsolePrintUtils` represents the print utility interface, `IConsoleUtils` represents the existing console utility interface, and `ConsoleUtils` is the concrete implementation of the existing console utility class. The `ConsolePrintUtilsAdapter` acts as the adapter and adapts the `IConsolePrintUtils` interface to the `IConsoleUtils` interface by implementing `IConsolePrintUtils` and delegating calls to `IConsoleUtils`.

Here's an example of how the Adapter pattern is used in the GadgetDelivery application:

```cs
IConsoleUtils consoleUtils = new ConsoleUtils(); // Existing console utility class
IConsolePrintUtils consolePrintUtils = new ConsolePrintUtilsAdapter(consoleUtils); // Adapter

consolePrintUtils.PrintWithColour("Hello, world!", ConsoleColor.Red); // Calls the adapted method

// The adapter allows using the PrintWithColour method of IConsolePrintUtils
// while internally delegating the call to the DisplayWithColour method of IConsoleUtils
```

In the example, we create an instance of the existing `ConsoleUtils` class that implements the `IConsoleUtils` interface. Then, we create an instance of the `ConsolePrintUtilsAdapter`, passing the `ConsoleUtils` object as a dependency. Now, we can use the `consolePrintUtils` object, which adheres to the `IConsolePrintUtils` interface and internally calls the corresponding methods of the `ConsoleUtils` object.

By using the Adapter pattern, the GadgetDelivery application allows the existing console utility class to be used seamlessly with the `IConsolePrintUtils` interface. It avoids the need to modify the existing code and enables compatibility between the different utility interfaces.

# 🧠 Behavioral Design Patterns

Behavioral design patterns in software engineering are concerned with the interaction and communication between objects and classes. These patterns focus on defining the responsibilities and behaviors of objects, facilitating the design of flexible and reusable systems.

The main objective of behavioral design patterns is to provide solutions for managing the behavior and communication of objects in a way that is efficient, decoupled, and extensible. These patterns address common design challenges related to managing complex control flows, encapsulating algorithms, and handling object collaboration.

Behavioral design patterns emphasize the utilization of interfaces, abstract classes, and protocols to define interactions between objects. They help developers design software systems that are adaptable, maintainable, and easy to extend.

Now, let's delve into each behavioral design pattern implemented in the GadgetStorage application, explore the problems they solve, understand their benefits, and examine their implementation details.

## 🔍 Iterator Pattern

The Iterator pattern is a behavioral design pattern that provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation. It allows you to iterate over a collection of objects without exposing the internal structure of the collection.

In the GadgetDelivery application, the Iterator pattern is used to iterate over the products stored in the `InMemoryProductStorage`. The `InMemoryProductStorage` class acts as the aggregate object that holds a collection of gadgets. The `ProductIterator` class is the iterator that provides the functionality to iterate over the gadgets in the storage.

Here's how the Iterator pattern is applied in the GadgetDelivery application:

1. The `IProductIterator` interface defines the common iterator operations, including `HasNext()` to check if there is a next element and `Next()` to retrieve the next element.
2. The `InMemoryProductStorage` class extends the `AbstractProductStorage` abstract class and implements the iterator-related methods. It also has an internal class `ProductIterator` that implements the `IProductIterator` interface.
3. The `ProductIterator` class maintains a reference to the list of gadgets (`_gadgets`) and an index (`_index`) to keep track of the current position in the iteration.
4. The `ProductIterator` class implements the `HasNext()` method to check if there are more elements in the collection by comparing the current index with the number of gadgets.
5. The `Next()` method returns the next gadget in the iteration by retrieving it from the `_gadgets` list based on the current index. It also increments the index for the next iteration.
6. The `InMemoryProductStorage` class overrides the `GetIterator()` method from the `AbstractProductStorage` class and returns a new instance of the `ProductIterator`, passing the gadgets list (`GetInstance()`) as a parameter.

By using the Iterator pattern, the `InMemoryProductStorage` class encapsulates the iteration logic within the `ProductIterator`, allowing clients to iterate over the collection of gadgets without exposing the internal implementation details.

Here's a simplified UML diagram to illustrate the relationships involved in the Iterator pattern implementation:

![Iterator Pattern UML Diagram](https://chat.openai.com/c/path_to_factory_method_uml_diagram.png)

In the diagram, `IProductIterator` represents the iterator interface, `ProductIterator` is the concrete iterator class, and `InMemoryProductStorage` is the aggregate object that provides the iterator implementation.

By implementing the Iterator pattern, the GadgetDelivery application enables the ability to iterate over the products stored in the `InMemoryProductStorage` using a standardized iterator interface.

## 💡 Strategy Pattern

The Strategy pattern is a behavioral design pattern that enables selecting an algorithm at runtime from a family of interchangeable algorithms and encapsulates each algorithm into a separate class. It allows the algorithm to vary independently from the clients that use it.

In the GadgetDelivery application, the Strategy pattern is used to implement different sorting strategies for gadgets in the `Sorter` class. The `Sorter` class represents the context that uses a sorting strategy based on the selected algorithm.

Here's how the Strategy pattern is applied in the GadgetDelivery application:

1. The `ISortStrategy` interface declares the common interface for all sorting strategies. It defines a single method `Sort()` that takes a list of gadgets as input and returns the sorted list.
2. The `NameSortStrategy` and `PriceSortStrategy` classes are concrete implementations of the `ISortStrategy` interface. Each strategy class implements the `Sort()` method according to a specific sorting algorithm, such as sorting by name or price.
3. The `AbstractSorter` class is an abstract class that serves as the context for the sorting strategies. It contains a reference to the current sorting strategy (`strategy`) and declares abstract methods `SetStrategy()` and `Sort()`.
4. The `Sorter` class extends the `AbstractSorter` class and provides the concrete implementation for the `SetStrategy()` and `Sort()` methods. The constructor of the `Sorter` class accepts an initial sorting strategy and sets it as the current strategy.
5. The `SetStrategy()` method in the `Sorter` class allows changing the sorting strategy at runtime by updating the `strategy` field.
6. The `Sort()` method in the `Sorter` class delegates the sorting operation to the current strategy (`strategy.Sort()`).

By using the Strategy pattern, the `Sorter` class encapsulates the sorting algorithm and allows different sorting strategies to be applied dynamically based on the selected strategy. The sorting strategy can be changed at runtime by calling the `SetStrategy()` method.

Here's a UML diagram to illustrate the relationships involved in the Strategy pattern implementation:

![Adpater Pattern UML Diagram](https://chat.openai.com/c/path_to_factory_method_uml_diagram.png)

In the diagram, `ISortStrategy` represents the strategy interface, `NameSortStrategy` and `PriceSortStrategy` are the concrete strategy classes, `AbstractSorter` is the abstract class that defines the context, and `Sorter` is the concrete class that provides the context implementation.

By applying the Strategy pattern, the GadgetDelivery application achieves flexibility in sorting gadgets by encapsulating different sorting algorithms into separate strategy classes and allowing clients to select and switch between strategies dynamically.

## 📝 Template Method Pattern

The Template Method pattern is a behavioral design pattern that defines the skeleton of an algorithm in a base class and allows subclasses to provide specific implementations for certain steps of the algorithm. It enables the subclasses to redefine or extend certain steps of the algorithm without changing its structure.

In the GadgetDelivery application, the Template Method pattern is used to define a template for saving orders in the `AbstractOrderSaveTemplate` class. The template method `Save()` defines the overall algorithm for saving an order, while the individual steps are delegated to the concrete subclasses.

Here's how the Template Method pattern is applied in the GadgetDelivery application:

1. The `AbstractOrderSaveTemplate` class is an abstract class that serves as the template for saving orders. It provides the template method `Save()`, which defines the overall algorithm for saving an order.
2. The `Save()` method in the `AbstractOrderSaveTemplate` class consists of several steps:
   - `beforeSave()`: This step is an abstract method that subclasses need to implement. It is called before saving the order and allows subclasses to perform custom validation or checks. The method takes the current order and the list of orders as parameters and returns a boolean value indicating whether the order should be saved.
   - `orders.Add(order)`: This step adds the order to the list of orders if the `beforeSave()` validation succeeds.
   - `afterSave()`: This step is an abstract method that subclasses need to implement. It is called after the order is successfully saved and allows subclasses to perform additional actions or logging.
   - `failedSave()`: This step is an abstract method that subclasses need to implement. It is called when the `beforeSave()` validation fails, indicating that the order cannot be saved. Subclasses can handle the failure scenario in a customized way.
3. The `BasicStoreOrderLogic` class extends the `AbstractOrderSaveTemplate` class and provides concrete implementations for the abstract methods: `beforeSave()`, `afterSave()`, and `failedSave()`. These methods define the specific behavior for saving orders in a basic store order logic scenario.

By using the Template Method pattern, the `AbstractOrderSaveTemplate` class defines the overall structure of the order-saving algorithm, while the concrete subclasses, such as `BasicStoreOrderLogic`, provide specific implementations for certain steps of the algorithm. This allows for customization and extension of the order-saving process while maintaining a consistent algorithm structure.

Here's a UML diagram to illustrate the relationships involved in the Template Method pattern implementation:

![Template Method Pattern UML Diagram](https://chat.openai.com/c/path_to_factory_method_uml_diagram.png)

In the diagram, `AbstractOrderSaveTemplate` represents the abstract template class, and `BasicStoreOrderLogic` is the concrete subclass that provides specific implementations for the abstract methods.

By applying the Template Method pattern, the GadgetDelivery application achieves a reusable and extensible structure for saving orders. The template method provides a defined algorithm with customizable steps that can be overridden by subclasses to adapt the behavior to specific requirements.
