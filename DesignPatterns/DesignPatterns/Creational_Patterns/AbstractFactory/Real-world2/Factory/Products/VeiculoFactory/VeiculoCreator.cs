using DesignPatterns.Creational_Pattern;
using DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.AbstractFactory.Real_world2.Factory.Products.VeiculoFactory
{
    internal static class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new VeiculoPequenoPorte(modelo, porte),
                Porte.Medio => new VeiculoMedioPorte(modelo, porte),
                Porte.Grande => new VeiculoGrandePorte(modelo, porte),
                _ => throw new ApplicationException("Porte de veiculo Desconhecido"),
            };
        }
    }
}
