using Exercicio_03_04_05_06.Functions;
using Exercicio_03_04_05_06.Models;

namespace Exercicio_03_04_05_06;
internal class Program
{
    static void Main(string[] args)
    {
        List<string> Opcoes = new List<string>() { "1 - Nova Conta", "2 - Depositar", "3 - Sacar", "4 - Exibir Saldo" };

        List<ContaBancaria> contas = new List<ContaBancaria>();

        while (true)
        {
            RenderOpt();

            int escolha = 0;

            while (escolha > 4 ^ escolha < 1)
            {
                escolha = CheckNumber.Check("Escolha a opção desejada: ", false);
                if (escolha < 5 & escolha > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }

            int conta = -1;
            switch (escolha)
            {

                case 1:
                    Console.Clear();
                    contas.Add(CriarConta.CriarContaBancaria(contas.Count));
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine(contas[contas.Count - 1]);
                    break;
                case 2:
                    conta = -1;
                    while (conta < 0 ^ conta > contas.Count)
                    {
                        if (contas.Count == 0)
                        {
                            Console.Clear() ;
                            Console.WriteLine("Nenhuma conta cadastrada\n");
                            break;
                        }
                        Console.Clear();
                        conta = CheckNumber.Check("Digite o id da conta: ");
                        if (conta < 0 ^ conta > contas.Count)
                        {
                            Console.WriteLine("Conta inexistente");
                        }
                        else
                        {
                            contas.Find(c => c.id == conta).Depositar();
                        }
                    }
                    break;
                case 3:
                    conta = -1;
                    while (conta < 0 ^ conta > contas.Count)
                    {
                        if (contas.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhuma conta cadastrada\n");
                            break;
                        }
                        Console.Clear();
                        conta = CheckNumber.Check("Digite o id da conta: ");
                        if (conta < 0 ^ conta > contas.Count)
                        {
                            Console.WriteLine("Conta inexistente");
                        }
                        else
                        {
                            contas.Find(c => c.id == conta).Sacar();
                        }
                    }

                    break;
                case 4:
                    conta = -1;
                    while (conta < 0 ^ conta > contas.Count)
                    {
                        if (contas.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhuma conta cadastrada\n");
                            break;
                        }
                        Console.Clear();
                        conta = CheckNumber.Check("Digite o id da conta: ");
                        if (conta < 0 ^ conta > contas.Count)
                        {
                            Console.WriteLine("Conta inexistente");
                        }
                        else
                        {
                            Console.WriteLine(contas.Find(c => c.id == conta));
                        }
                    }
                    break;
                case 5:
                    break;
                default:
                    break;
            }

        }

        void RenderOpt()
        {
            Console.WriteLine("Que operação deseja realizar?");
            foreach (string opt in Opcoes)
            {
                Console.WriteLine($"{opt}");
            }
        }

    }
}


