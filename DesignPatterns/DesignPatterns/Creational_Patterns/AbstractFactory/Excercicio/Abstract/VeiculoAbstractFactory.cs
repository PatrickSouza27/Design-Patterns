using DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Excercicio.Abstract
{
    internal abstract class VeiculoAbstractFactory
    {
        internal abstract ICarro GetCarro(string ano);
        internal abstract IMoto GetMoto(string ano);
    }
}
