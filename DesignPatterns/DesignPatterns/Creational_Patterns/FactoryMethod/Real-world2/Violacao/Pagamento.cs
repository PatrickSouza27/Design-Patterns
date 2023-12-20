using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Violacao
{
    internal class Pagamento
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }

        public Pagamento() { }
        public Pagamento(string descricao, double valor, string tipo)
        {
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
        }

        public void Paid()
        {
            Console.WriteLine($"Pagamento Concluido\nDescrição: {Descricao}\nValor: {Valor}\nTipo: {Tipo}");
        }
    }
}
