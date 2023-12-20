

using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract.Products;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Factory.Products
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

        public void Enviar()
        {
            Console.WriteLine($"{this.GetType().Name}\nPeso: {Peso}\nConteudo: {Conteudo}\nDimensao: {Dimensao}");
        }
    }
}
