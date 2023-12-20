using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract;
using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract.Products;
using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Factory.Products.Carros;
using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Factory.Products.Motos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Factory
{
    internal class Honda : VeiculoAbstractFactory
    {
        private readonly string _marca;

        public Honda()
            => _marca = this.GetType().Name;

        internal override ICarro GetCarro(string ano)
        {
            return new HB20(_marca, ano);
        }

        internal override IMoto GetMoto(string ano)
        {
            return new CB1000(_marca, ano);
        }
    }
}
