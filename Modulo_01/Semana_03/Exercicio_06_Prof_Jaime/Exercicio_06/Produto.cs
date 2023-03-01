using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preço;

        public Produto()
        {            
        }
        public Produto(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        public void VerificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto.");
        }

        protected void Vender()
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void Descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
        }

        protected void AlteraAtributosPrivados(double peso2, double preco)
        {
            this.peso = peso2;
            Console.WriteLine("Variável peso de escopo da classe: " + peso);
        }

    }
}
