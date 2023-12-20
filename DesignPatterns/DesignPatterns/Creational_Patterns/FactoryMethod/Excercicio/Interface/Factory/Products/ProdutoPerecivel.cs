using DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Abstract.Products;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Excercicio.Interface.Factory.Products
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

        public void Enviar()
        {
            Console.WriteLine($"{this.GetType().Name}\nPeso: {Peso}\nTemperatura: {TemperaturaRecomendada}\nDataValidade: {DataValidade}");
        }
    }
}
