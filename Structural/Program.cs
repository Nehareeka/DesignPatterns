//See https://aka.ms/new-console-template for more information
using Structural.Adapter;
using Structural.Bridge;
using Structural.Composite;
using Structural.Decorator;
using Structural.Facade;
using Structural.Flyweight;
using Structural.Proxy;

#region Adapter

AdapterClient client = new AdapterClient();
client.Main();

# endregion

#region Builder

BridgeClient bridgeClient = new BridgeClient();
bridgeClient.Main();

#endregion

#region Composite

CompositeClient compositeClient = new CompositeClient();
compositeClient.Main();

#endregion

#region Decorator

DecoratorClient decoratorClient = new DecoratorClient();
decoratorClient.Main();

#endregion

#region Facade

FacadeClient facadeClient = new FacadeClient();
facadeClient.Main();

#endregion

#region Flyweight

FlyweightClient flyweightClient = new FlyweightClient();
flyweightClient.Main();

#endregion

#region Proxy

ProxyClient proxyClient = new ProxyClient();
proxyClient.Main();

#endregion

