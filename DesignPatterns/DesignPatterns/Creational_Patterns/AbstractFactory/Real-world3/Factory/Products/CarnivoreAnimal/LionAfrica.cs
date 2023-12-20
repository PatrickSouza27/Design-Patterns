using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.Factory.Products.CarnivoreAnimal
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    internal class LionAfrica : Carnivore
    {
        // Eat Wildebeest
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
