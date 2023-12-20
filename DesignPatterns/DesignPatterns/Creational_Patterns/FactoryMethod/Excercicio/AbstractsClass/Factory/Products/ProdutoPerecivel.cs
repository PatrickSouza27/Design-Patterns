using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Factory.Products
{
    internal class ProdutoPerecivel : IMercadoria
    {
        public double Peso { get; set; }
        public string TemperaturaRecomendada { get; set; }
        public string DataValidade { get; set; }

        public ProdutoPerecivel(double peso, string temperaturaRecomendada, string dataValidade)
        {
            Peso = peso;
            TemperaturaRecomendada = temperaturaRecomendada;
            DataValidade = dataValidade;
        }

        public override void Enviar()
        {
            Console.WriteLine($"{this.GetType().Name}\nPeso: {Peso}\nTemperatura: {TemperaturaRecomendada}\nDataValidade: {DataValidade}");
        }
    }
}
