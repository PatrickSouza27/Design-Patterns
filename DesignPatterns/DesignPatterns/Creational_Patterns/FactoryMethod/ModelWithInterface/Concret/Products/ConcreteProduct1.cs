using DesignPatterns.Creational_Patterns.FactoryMethod.ModelWithInterface.CreatorAbstract.InterfaceProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.ModelWithInterface.Concret.Products
{
    internal class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
