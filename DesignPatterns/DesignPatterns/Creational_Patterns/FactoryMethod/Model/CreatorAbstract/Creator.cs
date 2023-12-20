using DesignPatterns.Creational_Patterns.FactoryMethod.Model.CreatorAbstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Model.CreatorAbstract
{
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
