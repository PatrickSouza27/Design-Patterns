using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.Factory.Products.CarnivoreAnimal
{
    internal class DingoOceania : Carnivore
    {
        /// <summary>
        /// The 'ProductC1' class
        /// </summary>
        public override void Eat(Herbivore h)
        {
            //eat canguru

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
