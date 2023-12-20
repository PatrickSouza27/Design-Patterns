
using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract.Products;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Factory.Products
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

        public void Enviar()
        {
            Console.WriteLine($"{this.GetType().Name}\nPeso: {Peso}\nNivelFragilidade: {NivelFragilidade}\nDescricaoFragilidade: {DescricaoFragilidade}");
        }
    }
}
