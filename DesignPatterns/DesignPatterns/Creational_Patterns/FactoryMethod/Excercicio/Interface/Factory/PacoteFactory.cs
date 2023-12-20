


using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Factory.Products;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract
{
    internal class PacoteFactory : IMercadoriaAbstractFactory
    {
        public IMercadoria CriarMercadoria()
            => new Pacote(400, "Celular", "20x30");           
    }
}
