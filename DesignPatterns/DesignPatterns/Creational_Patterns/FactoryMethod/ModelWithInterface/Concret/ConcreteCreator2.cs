using DesignPatterns.Creational_Patterns.FactoryMethod.ModelWithInterface.Concret.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.ModelWithInterface.CreatorAbstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.ModelWithInterface.CreatorAbstract.InterfaceProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.ModelWithInterface.Concret
{
    internal class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }


    }
}
