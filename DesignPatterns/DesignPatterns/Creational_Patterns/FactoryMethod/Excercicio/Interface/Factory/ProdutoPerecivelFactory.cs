using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Factory
{
    internal class ProdutoPerecivelFactory : IMercadoriaAbstractFactory
    {
        public IMercadoria CriarMercadoria()
            => new ProdutoPerecivel(300, "200°", "12/12/2002");
    }
}
