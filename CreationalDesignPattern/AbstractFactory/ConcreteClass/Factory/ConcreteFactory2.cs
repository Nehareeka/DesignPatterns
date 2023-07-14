using Creational.AbstractFactory.ConcreteClass.ProductA;
using Creational.AbstractFactory.ConcreteClass.ProductB;
using Creational.AbstractFactory.Interface;

namespace Creational.AbstractFactory.ConcreteClass.Factory
{
    // Each Concrete Factory has a corresponding product variant.
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
