using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory.Products
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    internal abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}
