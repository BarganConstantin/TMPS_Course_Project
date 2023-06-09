# 🎓 Design Patterns Course Project
Course Project for Software Design Techniques and Mechanisms course at Technical University of Moldova

# Table of Contents

1. [Introduction](#introduction)
2. [Creational Design Patterns](#%EF%B8%8F-creational-design-patterns)
   - [Builder Pattern](#%EF%B8%8F-builder-pattern)🏗️
   - [Prototype Pattern](#-prototype-pattern) 🧬
   - [Singleton Pattern](#-singleton-pattern) 🔒
   - [Factory Method Pattern](#-factory-method-pattern) 🏭
3. [Structural Design Patterns](#%EF%B8%8F-structural-design-patterns)
   - [Decorator Pattern](#-decorator-pattern) 🎨
   - [Composite Pattern](#-composite-pattern) 🌳
   - [Facade Pattern](#-facade-pattern) 🏰
   - [Adapter Pattern](#-adapter-pattern) 🔌
4. [Behavioral Design Patterns](#-behavioral-design-patterns)
   - [Iterator Pattern](#-iterator-pattern)🔍
   - [Strategy Pattern](#-strategy-pattern) 💡
   - [Template Method Pattern](#-template-method-pattern)📝
5. [Conslusion](#conslusion)
6. [Application Interface](#application-overview)

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

[![MarineGEO circle logo](https://private-user-images.githubusercontent.com/60443226/242284454-f48d5708-19ec-40ac-a8a9-15c27e202ba8.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjg0NDU0LWY0OGQ1NzA4LTE5ZWMtNDBhYy1hOGE5LTE1YzI3ZTIwMmJhOC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT00YzIzOWFlNjkzOTY3ZGVlMzNmODJkOWU4ZDRlNDQ2YmQ4YjU5NmJiNjBjMjIwMjdhODU0MTBkNWZiY2U1ODBlJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.gxi4HYS_cqn_t57XOmle3T70Mkw7Jx5qUlx-Xp8NqpQ)](https://private-user-images.githubusercontent.com/60443226/242284454-f48d5708-19ec-40ac-a8a9-15c27e202ba8.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjg0NDU0LWY0OGQ1NzA4LTE5ZWMtNDBhYy1hOGE5LTE1YzI3ZTIwMmJhOC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT00YzIzOWFlNjkzOTY3ZGVlMzNmODJkOWU4ZDRlNDQ2YmQ4YjU5NmJiNjBjMjIwMjdhODU0MTBkNWZiY2U1ODBlJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.gxi4HYS_cqn_t57XOmle3T70Mkw7Jx5qUlx-Xp8NqpQ) 

[![MarineGEO circle logo](https://private-user-images.githubusercontent.com/60443226/242284569-4d2ff394-2648-4374-b8a3-2964ed823eff.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjg0NTY5LTRkMmZmMzk0LTI2NDgtNDM3NC1iOGEzLTI5NjRlZDgyM2VmZi5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1mMDcyNTg4OGU2NDhmMTkyMzBiYzE2NzgxZDI1NzdmYThhOTUzOGRhZjE0Mjk2YmQ4YTZmMDRlYmRkNWFiOGE1JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.ayPSZCAAskmMR9-tSnYECHcYxKU2LTELSYjPsxmBTL8)](https://private-user-images.githubusercontent.com/60443226/242284569-4d2ff394-2648-4374-b8a3-2964ed823eff.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjg0NTY5LTRkMmZmMzk0LTI2NDgtNDM3NC1iOGEzLTI5NjRlZDgyM2VmZi5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1mMDcyNTg4OGU2NDhmMTkyMzBiYzE2NzgxZDI1NzdmYThhOTUzOGRhZjE0Mjk2YmQ4YTZmMDRlYmRkNWFiOGE1JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.ayPSZCAAskmMR9-tSnYECHcYxKU2LTELSYjPsxmBTL8)

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

[![MarineGEO circle logo](https://private-user-images.githubusercontent.com/60443226/242285810-2bb08639-7b54-433b-8a6f-736828c2b7b8.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjg1ODEwLTJiYjA4NjM5LTdiNTQtNDMzYi04YTZmLTczNjgyOGMyYjdiOC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT02OTk2MTVlZDUwNmZkYzY0OWU5NDZjMjE0MDE4MjQzYWQzNDI5MzcxN2E5NDM3NzdiMmJjYTc3Mzg3MjNjMjU4JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.xTRGi6VtfLQ4_7Zzb4hPJANyjkhu560tGuj30yJHB1A)](https://private-user-images.githubusercontent.com/60443226/242285810-2bb08639-7b54-433b-8a6f-736828c2b7b8.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjg1ODEwLTJiYjA4NjM5LTdiNTQtNDMzYi04YTZmLTczNjgyOGMyYjdiOC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT02OTk2MTVlZDUwNmZkYzY0OWU5NDZjMjE0MDE4MjQzYWQzNDI5MzcxN2E5NDM3NzdiMmJjYTc3Mzg3MjNjMjU4JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.xTRGi6VtfLQ4_7Zzb4hPJANyjkhu560tGuj30yJHB1A)

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

[![MarineGEO circle logo](https://private-user-images.githubusercontent.com/60443226/242292111-f932c9ae-c264-4083-b926-5b02f3727b43.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjkyMTExLWY5MzJjOWFlLWMyNjQtNDA4My1iOTI2LTViMDJmMzcyN2I0My5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT0xNjE2MDlkZjliM2IyZmM0MjZmMmQ3MDgxYTk4N2JiNzA0MzBhMjViYTU3N2E2NzY0YzY5ZDJhNjI1OTIyMmY5JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.m0pyiqYHsLQdCJJIdPQ8dMtw1hRlsNvn9-FwrLgSMac)](https://private-user-images.githubusercontent.com/60443226/242292111-f932c9ae-c264-4083-b926-5b02f3727b43.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjkyMTExLWY5MzJjOWFlLWMyNjQtNDA4My1iOTI2LTViMDJmMzcyN2I0My5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT0xNjE2MDlkZjliM2IyZmM0MjZmMmQ3MDgxYTk4N2JiNzA0MzBhMjViYTU3N2E2NzY0YzY5ZDJhNjI1OTIyMmY5JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.m0pyiqYHsLQdCJJIdPQ8dMtw1hRlsNvn9-FwrLgSMac)

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

<div align="center">
  <kbd>
    <img src="https://user-images.githubusercontent.com/60443226/233807006-6b1661e5-6a49-491b-916f-8732765afa26.png" alt="MarineGEO circle logo"/>
  </kbd>
</div>
<br/>

In the diagram, `IOrder` represents the interface for orders, `BasicOrder` is the core implementation, and `OrderDecorator` is the base decorator class implementing the `IOrder` interface. The concrete decorators, such as `DiscountDecorator`, `GiftWrapperDecorator`, `ShippingFeeDecorator`, and `WarrantyDecorator`, extend the `OrderDecorator` class and modify the behavior by adding features.

## 🌳 Composite Pattern

The Composite pattern is a structural design pattern that allows you to compose objects into tree-like structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly.

In the GadgetDelivery application, the Composite pattern is used to represent the structure of parcels and packs that contain multiple components. The `ParcelComponent` class serves as the base component class, representing either a single product or a pack of multiple components. The `Product` class extends `ParcelComponent` and represents a single product, while the `Pack` class represents a pack that can contain multiple components.

The `ParcelComponent` class defines common methods and properties for both products and packs. It includes methods like `Add`, `Remove`, `Display`, and `GetChildrens` that allow components to be added, removed, displayed in a hierarchical manner, and retrieved. The `Product` class, representing a single product, implements these methods in a way that is appropriate for a leaf node in the hierarchy. The `Pack` class, representing a pack of components, uses a list to store its children components and implements the methods to handle adding, removing, and displaying the components.

To visualize the implementation of the Composite pattern in the GadgetDelivery application, the following UML diagram illustrates the relationships between the component classes:

<div align="center">
  <kbd>
    <img src="https://user-images.githubusercontent.com/60443226/233806493-12298285-8037-4027-9b6b-9c2dcfa932af.png" alt="MarineGEO circle logo"/>
  </kbd>
</div>
<br/>

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

<div align="center">
  <kbd>
    <img src="https://user-images.githubusercontent.com/60443226/233806513-62c58a12-fb4e-422a-bc13-1cc540d0eb55.png" alt="MarineGEO circle logo"/>
  </kbd>
</div>
<br/>

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

<div align="center">
  <kbd>
    <img src="https://user-images.githubusercontent.com/60443226/233806529-2048985d-3b44-41e9-abbb-837862d5052f.png" alt="MarineGEO circle logo"/>
  </kbd>
</div>
<br/>

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

<div align="center">
  <kbd>
    <img src="https://user-images.githubusercontent.com/60443226/235783490-135086dd-43f6-465f-8790-5a156c2b7b64.png" alt="MarineGEO circle logo"/>
  </kbd>
</div>
<br/>

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

<div align="center">
  <kbd>
    <img src="https://user-images.githubusercontent.com/60443226/235783574-e81dc6d0-5b0a-42f7-9413-5e630cae3605.png" alt="MarineGEO circle logo"/>
  </kbd>
</div>
<br/>

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

<div align="center">
  <kbd>
    <img src="https://user-images.githubusercontent.com/60443226/235783649-ec3b0c95-35ca-46c5-80a3-d3fb36c72fb6.png" alt="MarineGEO circle logo"/>
  </kbd>
</div>
<br/>

In the diagram, `AbstractOrderSaveTemplate` represents the abstract template class, and `BasicStoreOrderLogic` is the concrete subclass that provides specific implementations for the abstract methods.

By applying the Template Method pattern, the GadgetDelivery application achieves a reusable and extensible structure for saving orders. The template method provides a defined algorithm with customizable steps that can be overridden by subclasses to adapt the behavior to specific requirements.

# Conslusion

The GadgetStorage Application exemplifies the practical implementation of various design patterns to address the challenges of gadget management. By incorporating creational, structural, and behavioral design patterns, the application offers solutions for gadget creation, storage management, and order processing.

These design patterns improve the flexibility, maintainability, and extensibility of the application. The use of patterns such as Builder, Prototype, Singleton, Composite, Factory Method, and Facade demonstrates the benefits of adopting a pattern-driven approach to software development.

Through the implementation of design patterns, developers can achieve better code organization, separation of concerns, and code reusability. Design patterns promote modular and scalable software architectures, making it easier to modify and extend the system in the future.

By studying and applying design patterns, developers gain a deeper understanding of software design principles and best practices. Design patterns serve as a foundation for creating robust, maintainable, and adaptable software solutions.

In conclusion, the GadgetStorage Application showcases the power and effectiveness of design patterns in developing efficient and scalable systems. The project serves as a valuable resource for developers, providing insights into the practical application of design patterns and their benefits in software development.

# Application Overview

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242295774-e84af73b-aed6-4dad-8c64-462e10e73fc7.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk1Nzc0LWU4NGFmNzNiLWFlZDYtNGRhZC04YzY0LTQ2MmUxMGU3M2ZjNy5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT05NTQ3YTI1OTJiMTRjZTNkZWU4MGEzMDQxNTFmZmYwN2JjMWM2ODJlYTkzZjBlMjQzMWI2MWFhMTI1OTQ2YWI2JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.nYfExGMNXsIAyPrKY94omztR1bmd7Vy154wjsXUlYl0" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242294102-dbdf46a9-df5d-455c-85e8-64c051745b76.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk0MTAyLWRiZGY0NmE5LWRmNWQtNDU1Yy04NWU4LTY0YzA1MTc0NWI3Ni5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1lNjc2MTEwZjQ4YmE3ZGE4ZThiYWJjZGQ5OWUwY2FjNWI5ZDY3MjNiZDJlN2YzYmUwYzY5NGJiMGM2NjQ3YmE2JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.JQLhGHYYfYyWRKMAD6VRMWftsSyYfVYIfLZciCGXzKg" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242294755-6eb8e346-9e3f-4323-ab93-7f372ebeb3f5.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk0NzU1LTZlYjhlMzQ2LTllM2YtNDMyMy1hYjkzLTdmMzcyZWJlYjNmNS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1jZmRlMDE1N2QyMTVhNWM4M2Y2ODEwYTk0NjRjOGFmNjIyODFlNWFlMjY0MDE3YThhOGM4N2U1MzBhNGY0MGVlJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.kMOGt11OiTaFCDFDU6pKycILpcHMVRyJZoASYh0FkEo" alt="MarineGEO circle logo" />
</p>
<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242295066-b6254496-3e03-4ae3-9cce-105d358358ca.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk1MDY2LWI2MjU0NDk2LTNlMDMtNGFlMy05Y2NlLTEwNWQzNTgzNThjYS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT04OWE4NGYzNmM0YTliODVkNDQ1MDA1Zjg0NTg0ZTkzYTNhMGU0YjNhZDNmZDdkNjQ0NmQ2ZmVlNzhhMGFjNTVlJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.XL0Hk61UAjSqgM0yAZYqs3QkfwqtZTE7aN6K2t43QbE" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242295451-310974b7-360b-4aa9-b0ce-5abc58a9859e.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk1NDUxLTMxMDk3NGI3LTM2MGItNGFhOS1iMGNlLTVhYmM1OGE5ODU5ZS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT05ODdmNzI4YzM1YjZlZTE3NjJjYmU4MTEzN2NmZTU2Mzc1N2Q3NWRlNWRmMzMzMmI1YmQ1OWZiOGU5YTM3ZmZkJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.Tfdv86mWWynGya1brGSAtePxuelx8XH9WwPwiXd-2z4" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242295544-8097cfce-32ce-4c07-a2bb-a0cd69b34f9f.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk1NTQ0LTgwOTdjZmNlLTMyY2UtNGMwNy1hMmJiLWEwY2Q2OWIzNGY5Zi5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1mMzVlMTU0NzJmMGRiMjYwMWNkMmUwMDZkZmQ3ZTdkMmY0ZTVjZDExZjUyM2VhZTlkNzgwZDI0YmJlOTFlMmUzJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.pUmzlfOt7oYjQJOWI29yjxlWbclWH47scJG7QmnD0ss" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242295657-2b0f84ae-0b1b-412b-b8e5-b598504967d7.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk1NjU3LTJiMGY4NGFlLTBiMWItNDEyYi1iOGU1LWI1OTg1MDQ5NjdkNy5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1hMGZjMDcxMGNiOTZkNzBjNzQ4ODFhNWEwM2UzMGEzNTU3YzRiNGI3ZmE1MjY1OTNmYTg5M2VjZGJjMTdiMDc3JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.FqS97LLHqtfZy9SD1YHZQF6z2Dti-lAI7S5rtWkcHaI" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242294290-50237a80-1a68-45f9-b090-75608a93245d.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk0MjkwLTUwMjM3YTgwLTFhNjgtNDVmOS1iMDkwLTc1NjA4YTkzMjQ1ZC5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1lYjc1NWZlMDlhYTZiNGNkZDg1MTdhOTg5MzZiNjk5OGY3ZGVjMjczNjk3MGExNDAwMzg3NTNmOTY5MGU3YjFjJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.tGM84Bq6Tf7_uO9qkHqnfhWqaEWZpCKTsLe9AOtLlOw" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242294476-7d1b1a3b-6b1a-43f6-95bc-4b610ff78773.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk0NDc2LTdkMWIxYTNiLTZiMWEtNDNmNi05NWJjLTRiNjEwZmY3ODc3My5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1mMTg0MDM3M2I3NzQwMjdjZTI0MGZhMzVlN2FkMTAxOTAyNDMwZjhmYjBkYmYzZDJkOWFhYmM3NmM3NDY5ODhiJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.5B45-4zpmal1h6VoPuqZR4IaSjs-BTycEoDpNpsG4p8" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242294598-1eebed12-12f6-4fca-b4f1-aaaa37e3e7c9.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk0NTk4LTFlZWJlZDEyLTEyZjYtNGZjYS1iNGYxLWFhYWEzN2UzZTdjOS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT04MGExMmUzZjVkYTA4Njk2NzZiNjQ1OGY4MTc4ZWI3MGNiZjZjZmMxZGQ3ZGJkOGYwYzQzNzM3NWQ0OTBiOGMyJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.oDONGTYDIqUWF4_nAFhYsF4MRagPWPaUEJXMIGq3SIk" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242294654-016b38ad-0962-4366-84cc-8f4107c8900e.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk0NjU0LTAxNmIzOGFkLTA5NjItNDM2Ni04NGNjLThmNDEwN2M4OTAwZS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT04M2Q2YTVmYzgzOTQwZWZlNzE5OWFlZmE1Nzg3MmE1YmMzZmU1MjYzNmM4NTQzNDM1NzcyMzA3ZDcxNzdjNjAyJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.T-tbK1okd_7qM7Y5deWiKy3VJm3N51niBXJah3e_2_Q" alt="MarineGEO circle logo" />
</p>

<p align="center">
  <img src="https://private-user-images.githubusercontent.com/60443226/242295832-37c05551-2ebf-4608-8ed2-f1c3ec228717.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJrZXkxIiwiZXhwIjoxNjg2MjAxMTczLCJuYmYiOjE2ODYyMDA4NzMsInBhdGgiOiIvNjA0NDMyMjYvMjQyMjk1ODMyLTM3YzA1NTUxLTJlYmYtNDYwOC04ZWQyLWYxYzNlYzIyODcxNy5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBSVdOSllBWDRDU1ZFSDUzQSUyRjIwMjMwNjA4JTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDIzMDYwOFQwNTA3NTNaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1iZmU4MWY2MjJiZjdkYmFlZmQyZmU0MjJhNWEwOWUyNjk3ZjFjYTA2MWI4ZjdlZmI3YmQzMzQzMmI3NjgyZjY4JlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.5RJpp4FkzNqh3516MN3e0mWTpCkvK-urO6sPSPcTreU" alt="MarineGEO circle logo" />
</p>
