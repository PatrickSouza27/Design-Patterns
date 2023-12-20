using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.FactoryMethod.Real_world2.Solucao.CreatorAbstract.Products
{
    internal abstract class PagamentoAbstract
    {
        protected string Descricao { get; set; }
        protected double Valor { get; set; }

        protected PagamentoAbstract() { }
        protected PagamentoAbstract(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public abstract void Paid();
    }
}
