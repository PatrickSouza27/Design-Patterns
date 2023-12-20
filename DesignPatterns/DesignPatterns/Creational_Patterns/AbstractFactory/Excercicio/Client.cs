using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract;
using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract.Products;
using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio
{
    internal class Client
    {
        public void Main()
        {
            VeiculoAbstractFactory factory;
            ICarro carro;
            IMoto moto;

            factory = new Bmw();
            carro = factory.GetCarro("1999");
            moto = factory.GetMoto("2007");

            GetFactory(moto, carro);


            factory = new Honda();
            carro = factory.GetCarro("1993");
            moto = factory.GetMoto("2002");

            GetFactory(moto, carro);


        }
        public void GetFactory(IMoto moto, ICarro carro)
        {
            Console.WriteLine("-----------Carro-----------");

            carro.Information();

            Console.WriteLine("------------Moto----------------------------");

            moto.Information();
        }
    }
}
