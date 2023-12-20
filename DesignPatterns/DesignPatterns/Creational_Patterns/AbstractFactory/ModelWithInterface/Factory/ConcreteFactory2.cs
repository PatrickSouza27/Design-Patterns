using DesignPatterns.Creational_Patterns.AbstractFactory.ModelWithInterface.Abstract;
using DesignPatterns.Creational_Patterns.AbstractFactory.ModelWithInterface.Abstract.Products;
using DesignPatterns.Creational_Patterns.AbstractFactory.ModelWithInterface.Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.ModelWithInterface.Factory
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA2Factory();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB2Factory();
        }
    }
}
