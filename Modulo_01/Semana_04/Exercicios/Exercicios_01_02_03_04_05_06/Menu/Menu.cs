using Exercicios_01_02_03_04_05_06.Models;
using Exercicios_01_02_03_04_05_06.Models.TiposContas;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;

namespace Exercicios_01_02_03_04_05_06.Menu
{
    public class Menu
    {
        const string mensagem = """
                    Bem vindo ao Banco Floripa +Tech!   

                    1 - Criar conta
                    2 - Saque
                    3 - Deposito
                    4 - Transferir
                    5 - Exibir Saldo
                    6 - Exibir Contas
                    7 - Fazer Empréstimo
                    8 - Pagar Empréstimo
                    9 - Detalhar Contas
                    0 - Sair

                    Digite a opção desejada.
                 """;

        // Renderiza o menu principal
        public static void Render()
        {
            List<ContaBancaria> contas = new();

            string mensagemParaRender = mensagem;

            while (true)
            {
                Console.WriteLine(mensagemParaRender);
                TratarEscolha(int.Parse(Console.ReadLine()), contas);
            }
        }

        private static void TratarEscolha(int opt, List<ContaBancaria> contas)
        {
            Opcoes opcoes = new();
            switch (opt)
            {
                case 1:
                    try
                    {
                        ContaBancaria novaConta = opcoes.CriarConta();
                        if (novaConta == null)
                        {
                            throw new Exception();
                        }
                        contas.Add(novaConta);
                    }
                    catch
                    {
                        Console.WriteLine("Erro ao criar conta");
                    }
                    break;
                case 2:
                    opcoes.Saque(contas);
                    break;
                case 3:
                    opcoes.Deposito(contas);
                    break;
                case 4:
                    opcoes.Transferir(contas);
                    break;
                case 5:
                    opcoes.ExibirSaldo(contas);
                    break;
                case 6:
                    contas.ForEach(c =>
                    {
                        Console.WriteLine($"Conta: {c.numero}" +
                            $" - Agencia: {c.agencia}" +
                            $" - Titular: {c.cliente.nome}");
                    });
                    break;
                case 7:
                    opcoes.Emprestimo(contas);
                    break;
                case 8:
                    opcoes.PagarEmprestimo(contas);
                    break;
                case 9:
                    opcoes.ExibirConta(contas);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
