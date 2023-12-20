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
    internal class ProdutoFragilFactory : MercadoriaAbstractFactory
    {
        internal override IMercadoria CriarMercadoria()
            => new ProdutoFragil(200, "ALTO", "Vidro");
    }
}
