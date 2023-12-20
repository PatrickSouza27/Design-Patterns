using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract.Products
{
    internal abstract class InformationVeiculoAbstract
    {
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected string Ano { get; set; }

        protected InformationVeiculoAbstract(string marca, string ano)
        {
            Marca = marca;
            Ano = ano;
        }
    }
}
