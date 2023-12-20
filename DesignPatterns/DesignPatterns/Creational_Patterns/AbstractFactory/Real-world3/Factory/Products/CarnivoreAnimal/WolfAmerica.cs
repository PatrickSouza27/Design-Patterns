using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.Factory.Products.CarnivoreAnimal
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    internal class WolfAmerica : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            //eat Bison
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
