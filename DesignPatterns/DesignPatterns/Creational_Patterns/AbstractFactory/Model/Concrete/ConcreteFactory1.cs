
using DesignPatterns.Creational_Patterns.AbstractFactory.Model.Abstract;
using DesignPatterns.Creational_Patterns.AbstractFactory.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns
{
    internal class ConcreteFactory1 : AbstractFactoryIn
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}
