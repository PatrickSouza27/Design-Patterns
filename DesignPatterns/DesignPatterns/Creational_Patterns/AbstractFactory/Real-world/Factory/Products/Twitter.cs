using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world.Factory.Products
{
    internal class Twitter : MediaSocial
    {
        public override void Like()
        {
            Console.WriteLine("Like pelo Twitter");
        }

        public override void Post(string title, string body)
        {
            Console.WriteLine(title);
            Console.WriteLine(body + " no twitter");
        }
    }
}
