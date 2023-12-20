using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory.Products;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3
{
    internal class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }
        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
