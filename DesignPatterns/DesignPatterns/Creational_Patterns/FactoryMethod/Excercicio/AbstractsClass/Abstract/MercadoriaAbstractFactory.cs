using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract
{
    internal abstract class MercadoriaAbstractFactory
    {
        internal abstract IMercadoria CriarMercadoria();
    }
}
