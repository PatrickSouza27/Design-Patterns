using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Factory
{
    internal class PacoteFactory : MercadoriaAbstractFactory
    {
        internal override IMercadoria CriarMercadoria()
            => new Pacote(400, "Celular", "20x30");
    }
}
