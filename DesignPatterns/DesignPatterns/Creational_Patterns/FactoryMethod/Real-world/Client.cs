using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.Concret;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.CreatorAbstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_World.CreatorAbstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_World
{
    internal class Client
    {
        static void Main()
        {
            // Note: constructors call Factory Method
            DocumentCreator[] documents = new DocumentCreator[2];
            documents[0] = new Resume();
            documents[1] = new Report();
            // Display document pages
            foreach (DocumentCreator document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
