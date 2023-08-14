using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.TemplateMethod
{
    internal class TemplateMethodClient
    {
        public void Main()
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            ClientCode(new ConcreteClass2());
        }

        // The client code calls the template method to execute the algorithm.
        // Client code does not have to know the concrete class of an object it
        // works with, as long as it works with objects through the interface of
        // their base class.
        public static void ClientCode(AbstractClass abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }
    }
}
