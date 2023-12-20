using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Factory;


namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface
{
    internal class Client
    {
        public void Main()
        {
            IMercadoriaAbstractFactory factory;
            IMercadoria mercadoria;


            factory = new PacoteFactory();
            mercadoria = factory.CriarMercadoria();

            mercadoria.Enviar();

            Console.WriteLine();

            factory = new ProdutoPerecivelFactory();
            mercadoria = factory.CriarMercadoria();

            mercadoria.Enviar();

            Console.WriteLine();

            factory = new ProdutoFragilFactory();
            mercadoria = factory.CriarMercadoria();

            mercadoria.Enviar();



        }
    }
}
