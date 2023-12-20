using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Factory;
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass
{
    internal class Client
    {
        public void Main()
        {
            MercadoriaAbstractFactory factory;
            IMercadoria mercadoria;

            factory = new PacoteFactory();
            mercadoria = factory.CriarMercadoria();

            mercadoria.Enviar();

            Console.WriteLine();

            factory = new ProdutoFragilFactory();
            mercadoria = factory.CriarMercadoria();

            mercadoria.Enviar();

            Console.WriteLine();

            factory = new ProdutoPerecivelFactory();
            mercadoria = factory.CriarMercadoria();

            mercadoria.Enviar();


        }
    }
}
