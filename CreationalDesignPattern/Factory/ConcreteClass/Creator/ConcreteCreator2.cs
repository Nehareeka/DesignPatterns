using Creational.Factory.Interface;
using Creational.Factory.AbstractClass;
using Creational.Factory.ConcreteClass.Product;

namespace Creational.Factory.ConcreteClass
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
