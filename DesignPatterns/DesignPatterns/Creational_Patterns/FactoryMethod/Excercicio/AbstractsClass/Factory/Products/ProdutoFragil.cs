using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.AbstractsClass.Factory.Products
{
    internal class ProdutoFragil : IMercadoria
    {
        public double Peso { get; set; }
        public string NivelFragilidade { get; set; }
        public string DescricaoFragilidade { get; set; }

        public ProdutoFragil(double peso, string nivelFragilidade, string descricaoFragilidade)
        {
            Peso = peso;
            NivelFragilidade = nivelFragilidade;
            DescricaoFragilidade = descricaoFragilidade;
        }

        public override void Enviar()
        {
            Console.WriteLine($"{this.GetType().Name}\nPeso: {Peso}\nNivelFragilidade: {NivelFragilidade}\nDescricaoFragilidade: {DescricaoFragilidade}");
        }
    }
}
