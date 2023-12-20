using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Enum;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns
{
    internal class VeiculoPequenoPorte : Veiculo
    {
        public VeiculoPequenoPorte(string modelo, Porte porte) : base(modelo, porte)
        {
        }
    }
}
