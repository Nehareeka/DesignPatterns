//See https://aka.ms/new-console-template for more information
using Creational.AbstractFactory;
using Creational.Builder;
using Creational.Factory;
using Creational.Prototype;
using Creational.Singleton;

//Console.WriteLine("Hello, World!");

#region AbstractFactory

new AbstractFactoryClient().Main();

# endregion

# region Factory

new FactoryClient().Main();

# endregion

# region Builder

new BuilderClient().Main();

# endregion

#region Prototype

new PrototypeClient().Main();

# endregion

#region Singleton

new SingletonClient().Main();
new SingletonClient().ThreadSafeMain();

# endregion
