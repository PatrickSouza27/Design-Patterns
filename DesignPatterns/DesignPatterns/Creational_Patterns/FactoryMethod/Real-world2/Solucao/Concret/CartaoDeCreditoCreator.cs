using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.Concret.Products;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract;
using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.Concret
{
    internal class CartaoDeCreditoCreator : TransacaoAbstract
    {
        public override PagamentoAbstract Pagamento(string descricao, double valor)
        {
            return new CartaoDeCredito(descricao, valor);
        }
    }
}
