using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Factory.Products.Carros
{
    internal class X6 : InformationVeiculoAbstract, ICarro
    {
        public X6(string marca, string ano) : base(marca, ano)
        {
            Modelo = this.GetType().Name;
        }

        public void Information()
        {
            Console.WriteLine($"Informações do Carro \nModelo: {Modelo}\nMarca:{Marca}\nAno: {Ano}");
        }
    }
}
