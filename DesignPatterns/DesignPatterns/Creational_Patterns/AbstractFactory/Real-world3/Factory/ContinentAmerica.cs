﻿using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.AbstractFactory.Products;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.Factory.Products.CarnivoreAnimal;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.Factory.Products.HerbivoreAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world3.Factory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    internal class ContinentAmerica : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new WolfAmerica();
        }

        public override Herbivore CreateHerbivore()
        {
            return new BisonAmerica();
        }
    }
}
