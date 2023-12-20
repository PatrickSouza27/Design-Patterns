using DesignPatterns.Creational_Patterns.FactoryMethod.Model.Concret;
using DesignPatterns.Creational_Patterns.FactoryMethod.Model.CreatorAbstract.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Model.CreatorAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Model
{
    internal class Client
    {
        static void Main()
        {
            // An array of creators
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
