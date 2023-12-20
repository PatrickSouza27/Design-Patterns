using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Factory.Products
{
    internal class Pacote : IMercadoria
    {
        public double Peso { get; set; }
        public string Conteudo { get; set; }
        public string Dimensao { get; set; }

        public Pacote(double peso, string conteudo, string dimensao)
        {
            Peso = peso;
            Conteudo = conteudo;
            Dimensao = dimensao;
        }

        public override void Enviar()
        {
            Console.WriteLine($"{this.GetType().Name}\nPeso: {Peso}\nConteudo: {Conteudo}\nDimensao: {Dimensao}");
        }
    }
}
