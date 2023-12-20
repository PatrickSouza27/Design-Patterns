using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.Concret.Products
{
    internal class Boleto : PagamentoAbstract
    {
        public Boleto()
        {
        }

        public Boleto(string descricao, double valor) : base(descricao, valor)
        {
        }

        public override void Paid()
        {
            Console.WriteLine($"Pagamento Concluido\nDescrição: {Descricao}\nValor: {Valor}\nTipo: {this.GetType().Name}");
        }
    }
}
