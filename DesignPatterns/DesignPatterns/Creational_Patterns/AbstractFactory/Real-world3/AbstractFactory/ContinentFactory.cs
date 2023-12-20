using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    internal abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
