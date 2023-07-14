//See https://aka.ms/new-console-template for more information
using CreationalDesignPattern.AbstractFactory;
using CreationalDesignPattern.Builder;
using CreationalDesignPattern.Factory;
using CreationalDesignPattern.Prototype;
using CreationalDesignPattern.Singleton;

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
