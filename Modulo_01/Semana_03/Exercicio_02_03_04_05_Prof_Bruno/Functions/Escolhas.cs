/// Trata a escolha feita no menu inicial

using Exercicio_02_03_04_05.Menus;
using Exercicio_02_03_04_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02_03_04_05.Functions
{
    internal class Escolhas
    {
        public static List<ContaBancaria> Tratar(int escolha, List<ContaBancaria> contas)
        {
            ContaBancaria conta;
            switch (escolha)
            {

                case 1:
                    Console.Clear();

                    contas.Add(MenuAdicionarConta.Render(contas.Count, contas));
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine(contas[contas.Count - 1]);
                    break;

                case 2:
                    conta = FindConta.Find(contas, CheckNumber.Check("Digite o numero da conta para depósito: "));

                    if (conta == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Conta Inexistente\n");
                        break;
                    }
                    else
                    {
                        {
                            Console.WriteLine("Quanto deseja depositar: ");
                            conta.Depositar(CheckNumber.CheckDouble(), ContaBancaria.TipoDeposito.comum);
                        }
                    }
                    break;

                case 3:
                    conta = FindConta.Find(contas, CheckNumber.Check("Digite o numero da sua conta: "));

                    if (conta == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Conta Inexistente\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite sua senha: ");
                        if (conta.testaSenha(Console.ReadLine()))
                        {
                            Console.WriteLine("Quanto deseja sacar?");
                            conta.Sacar(CheckNumber.CheckDouble());
                        }
                    }
                    break;

                case 4:
                    conta = FindConta.Find(contas, CheckNumber.Check("Digite o numero da conta: "));


                    if (conta == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Conta Inexistente\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(conta);
                    }
                    break;

                case 5:
                    ListarContas.Listar(contas);
                    break;
                case 6:
                    conta = FindConta.Find(contas, CheckNumber.Check("Digite o numero da sua conta: "));
                    if (conta == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Conta Inexistente\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite sua senha: ");
                        if (conta.testaSenha(Console.ReadLine()))
                        {
                            Console.WriteLine("Quanto deseja depositar?");
                            double valor = CheckNumber.CheckDouble();

                            ContaBancaria contaDestino = FindConta.Find(contas, CheckNumber.Check("Digite o numero da conta destino: "));
                            if (contaDestino == null)
                            {
                                Console.WriteLine("Conta inexistente");
                                break;
                            }
                            else
                            {
                                conta.Transferir(contaDestino, valor);
                            }
                        }
                    }
                    break;

                default:                
                break;

            }
            return contas;
        }
    }
}
