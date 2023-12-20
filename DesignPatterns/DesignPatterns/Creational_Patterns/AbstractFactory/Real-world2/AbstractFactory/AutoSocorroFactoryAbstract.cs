
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Enum;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.AbstractFactory
{
    //fabrica de fabricas
    internal abstract class AutoSocorroFactoryAbstract
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
