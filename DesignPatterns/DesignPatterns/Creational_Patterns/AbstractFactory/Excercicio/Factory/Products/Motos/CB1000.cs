using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Factory.Products.Motos
{
    internal class CB1000 : InformationVeiculoAbstract, IMoto
    {
        public CB1000(string marca, string ano) : base(marca, ano)
        {
            Modelo = this.GetType().Name;
        }

        public void Information()
        {
            Console.WriteLine($"Informações do Moto \nModelo: {Modelo} \nMarca:{Marca} \nAno: {Ano}");
        }
    }
}
