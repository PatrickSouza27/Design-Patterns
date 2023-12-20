using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory
{
    
    internal abstract class Veiculo
    {
        public string Modelo { get; set; }
        public Porte Porte { get; set; }
        protected Veiculo(string modelo, Porte porte)        {
            Modelo = modelo;
            Porte = porte;
        }

    }
}
