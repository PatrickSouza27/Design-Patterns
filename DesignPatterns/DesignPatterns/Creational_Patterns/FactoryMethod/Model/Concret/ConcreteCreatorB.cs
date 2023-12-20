using DesignPatterns.Creational_Patterns.FactoryMethod.Model.Concret.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Model.CreatorAbstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Model.CreatorAbstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Model.Concret
{
    internal class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
