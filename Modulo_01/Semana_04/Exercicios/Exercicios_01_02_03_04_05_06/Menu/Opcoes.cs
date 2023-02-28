using Exercicios_01_02_03_04_05_06.Models;
using Exercicios_01_02_03_04_05_06.Models.TiposContas;
using Exercicios_01_02_03_04_05_06.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicios_01_02_03_04_05_06.Menu
{
    internal partial class Opcoes
    {
        public ContaBancaria CriarConta()
        {
            Console.WriteLine("==Cliente==");
            /*
                 Imprime e solicita os dados conforme as propriedades da classe cliente
                 * Para melhor apresentação
                 * Coloca a primeira letra em maiúsculo
                 * e usa expressão regular para separar palavras compostas
            */
            List<object> list = new();

            foreach (var property in new Cliente().GetType().GetProperties())
            {
                list.Add(TratarDadosCliente.Parse(property));
            }
            
            Cliente cliente = new Cliente(list[0].ToString(), (DateTime)list[1], list[2].ToString(), (EstadoCivil)list[3], (TipoPessoa)list[4]);
            list.Clear();

            while(true)
            {
                try {
                    return TratarDadosContas.NovaConta(cliente);
                } catch {
                    Console.WriteLine("Opção de conta inválida para este cliente");                    
                }
            }
        }
        public void Saque(List<ContaBancaria> contas)
        {
            Console.WriteLine("Digite sua conta:");
            try
            {
                int numero = int.Parse(Console.ReadLine());
                ContaBancaria contaAtual = contas.Find(c => c.numero == numero);
                Console.WriteLine("Quanto deseja sacar?");
                contaAtual.Sacar(float.Parse(Console.ReadLine()));
            }
            catch 
            {
                Console.WriteLine("Conta não encontrada");
            } 
        }
        public void Deposito(List<ContaBancaria> contas)
        {
            Console.WriteLine("Digite sua conta:");
            try
            {
                int numero = int.Parse(Console.ReadLine());
                ContaBancaria contaAtual = contas.Find(c => c.numero == numero);
                Console.WriteLine("Quanto deseja depositar?");
                contaAtual.Depositar(float.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Conta não encontrada");
            }
        }
        public void Transferir(List<ContaBancaria> contas)
        {
            Console.WriteLine("Digite sua conta:");
            try
            {
                int numero = int.Parse(Console.ReadLine());
                ContaBancaria contaSaque = contas.Find(c => c.numero == numero);
                Console.WriteLine("Quanto deseja transferir?");
                float valor = float.Parse(Console.ReadLine());
                Console.WriteLine("Qual a conta destino?");
                numero = int.Parse(Console.ReadLine());
                ContaBancaria contaDestino = contas.Find(c => c.numero == numero);
                if (contaDestino == null)
                {
                    throw new Exception();
                }

                contaSaque.Transferir(contaDestino,valor);
            }
            catch
            {
                Console.WriteLine("Conta não encontrada");
            }

        }
        public void ExibirSaldo(List<ContaBancaria> contas)
        {
            Console.WriteLine("Digite sua conta:");
            try
            {
                int numero = int.Parse(Console.ReadLine());
                ContaBancaria contaAtual = contas.Find(c => c.numero == numero);
                contaAtual.ExibirSaldo();
            }
            catch
            {
                Console.WriteLine("Conta não encontrada");
            }
        }

        internal void Emprestimo(List<ContaBancaria> contas)
        {
            Console.WriteLine("Digite sua conta: ");
            try
            {
                int numero = int.Parse(Console.ReadLine());
                ContaBancaria contaAtual = contas.Find(c => c.numero == numero);
                if (contaAtual.GetType().Name != "ContaEmpresarial") throw new Exception();
                else
                {
                    Console.WriteLine("Digite o valor do empréstimo: ");
                    contaAtual.Emprestimo(float.Parse(Console.ReadLine()));
                }

            }
            catch
            {
                Console.WriteLine("Conta não permitida");
            }
        }

        internal void PagarEmprestimo(List<ContaBancaria> contas)
        {
            Console.WriteLine("Qual o número da sua conta?");
            int numero = int.Parse(Console.ReadLine());
            ContaBancaria contaAtual = contas.Find(c => c.numero == numero);
            if (contaAtual.GetType().Name != "ContaEmpresarial") throw new Exception();            
            else
            {
                Console.WriteLine("Digite quanto deseja pagar");
                contaAtual.PagandoEmprestimo(float.Parse(Console.ReadLine()));
            }
        }

        internal void ExibirConta(List<ContaBancaria> contas)
        {
            Console.WriteLine("Qual o numero da conta deseja detalhar?");
            int numero = int.Parse(Console.ReadLine());
            ContaBancaria contaAtual = contas.Find(c => c.numero == numero);
            Console.WriteLine(contaAtual);
        }
    }
}
