using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Violacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.Concret.Products
{
    internal class CartaoDeDebito : PagamentoAbstract
    {
        public CartaoDeDebito()
        {
        }

        public CartaoDeDebito(string descricao, double valor) : base(descricao, valor)
        {
        }

        public override void Paid()
        {
            Console.WriteLine($"Pagamento Concluido\nDescrição: {Descricao}\nValor: {Valor}\nTipo: {this.GetType().Name}");
        }
    }
}
