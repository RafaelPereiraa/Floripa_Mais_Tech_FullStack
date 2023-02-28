using Exercicios_01_02_03_04_05_06.Models;
using Exercicios_01_02_03_04_05_06.Models.TiposContas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_01_02_03_04_05_06.Utils
{
    internal static class TratarDadosContas
    {

        public static ContaBancaria NovaConta(Cliente cliente)
        {
            Console.WriteLine("Qual tipo de conta deseja criar? (c - corrente, p - poupança, e - empresarial");
            string tipoConta = Console.ReadLine();

            try
            {
                if (tipoConta[0] == 'c' || tipoConta[0] == 'p' || tipoConta[0] == 'e')
                {
                    int numero;
                    int agencia;
                    float limiteEmprestimo;
                    float taxaJuros;
                    string cnpj;


                    switch (tipoConta[0]){
                        case 'c':
                            Console.WriteLine("Numero da conta: ");
                            numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Numero da agencia: ");
                            agencia = int.Parse(Console.ReadLine());
                            return new ContaCorrente(numero, agencia, cliente);
                        case 'p':
                            Console.WriteLine("Numero da conta: ");
                            numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Numero da agencia: ");
                            agencia = int.Parse(Console.ReadLine());
                            return new ContaPoupanca(numero, agencia, cliente);
                        case 'e':
                            Console.WriteLine("Numero da conta: ");
                            numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Numero da agencia: ");
                            agencia= int.Parse(Console.ReadLine());
                            Console.WriteLine("Limite de Empréstimo: ");
                            limiteEmprestimo = float.Parse(Console.ReadLine());
                            Console.WriteLine("Taxa de juros (em %): ");
                            taxaJuros = float.Parse(Console.ReadLine());
                            Console.WriteLine("cnpj: ");
                            cnpj = (Console.ReadLine());
                            return new ContaEmpresarial(numero, agencia, cliente, limiteEmprestimo, taxaJuros, cnpj);
                    }
                } else
                {
                    Console.WriteLine("Tipo de conta inválido");
                }
            } catch 
            {
                Console.WriteLine("Erro Tratando Dados");
            }
            return null;
        }
    }
}
