using DesignPatterns.Creational_Patterns.AbstractFactory.ModelWithInterface.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.ModelWithInterface.Abstract
{
    internal interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
