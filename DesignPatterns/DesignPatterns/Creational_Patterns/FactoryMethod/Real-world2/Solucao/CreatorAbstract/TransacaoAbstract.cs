using DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract
{
    internal abstract class TransacaoAbstract
    {
        public abstract PagamentoAbstract Pagamento(string descricao, double valor);
    }
}
