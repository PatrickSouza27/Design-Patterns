using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Factory.Products.Carros
{
    internal class HB20 : InformationVeiculoAbstract, ICarro
    {
        public HB20(string marca, string ano) : base(marca, ano)
        {
            Modelo = this.GetType().Name;
        }

        public void Information()
        {
            Console.WriteLine($"Informações do Carro \nModelo: {Modelo} \nMarca:{Marca} \nAno: {Ano}");
        }
    }
}
