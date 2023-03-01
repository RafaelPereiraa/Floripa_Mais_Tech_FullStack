using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class ProdutoFinanceiro : Produto
    {
        public ProdutoFinanceiro()
        {
        }

        public ProdutoFinanceiro(string nome, string cor) : base(nome, cor)
        {
        }

        public void Acesso()
        {
            ProdutoFinanceiro produto = new ProdutoFinanceiro("Caneta", "Azul");
            produto.Vender();
            produto.AlteraAtributosPrivados(99, 100.0);

        }
    }
}
