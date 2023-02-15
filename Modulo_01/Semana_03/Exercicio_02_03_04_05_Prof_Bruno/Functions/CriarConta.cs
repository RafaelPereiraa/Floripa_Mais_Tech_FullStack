/// Cria a conta conforme o tipo de seleção e os dados digitados

using Exercicio_02_03_04_05.Models;

namespace Exercicio_02_03_04_05.Functions
{
    public class CriarConta
    {

        internal static ContaBancaria CriarContaCompleta(int count)
        {
            Console.WriteLine("Digite o nome do titular: ");
            string nomeDoTitular = Console.ReadLine();
            long numeroDaConta = CheckNumber.Check("Digite o número para cadastro da conta: ", true);
            int agencia = CheckNumber.Check("Digite a agência para cadastro da conta: ", true);
            

            string tipo;
            while (true)
            {
                Console.WriteLine("Tipo de Conta (corrente/poupança):");
                tipo = Console.ReadLine();
                if ((tipo != "corrente") & (tipo != "poupanca"))
                {
                    Console.WriteLine("Tipo de conta inválido.");
                }
                else
                {
                    break;
                }
            }
            TipoConta tipoDeConta = (tipo == "corrente" ? TipoConta.corrente : TipoConta.poupanca);
            
            Console.Clear();
            return new ContaBancaria(count, numeroDaConta, agencia, nomeDoTitular, tipoDeConta);
        }

        public static ContaBancaria CriarContaComAgencia(int count)
        {

            Console.WriteLine("Digite o nome do titular: ");
            string nomeDoTitular = Console.ReadLine();
            int agencia = CheckNumber.Check("Digite a agência para cadastro da conta: ", true);

            string tipo;
            while (true)
            {
                Console.WriteLine("Tipo de Conta (corrente/poupança):");
                tipo = Console.ReadLine();
                if ((tipo != "corrente") & (tipo != "poupanca"))
                {
                    Console.WriteLine("Tipo de conta inválido.");
                }
                else
                {
                    break;
                }
            }
            TipoConta tipoDeConta = (tipo == "corrente" ? TipoConta.corrente : TipoConta.poupanca);
            Console.Clear();
            return new ContaBancaria(count, agencia, nomeDoTitular, tipoDeConta);
        }

        internal static ContaBancaria CriarContaAleatoria(int count)
        {
            Console.WriteLine("Digite o nome do titular: ");
            string nomeDoTitular = Console.ReadLine();
            string tipo;
            while (true)
            {
                Console.WriteLine("Tipo de Conta (corrente/poupança):");
                tipo = Console.ReadLine();
                if ((tipo != "corrente") & (tipo != "poupanca"))
                {
                    Console.WriteLine("Tipo de conta inválido.");
                }
                else
                {
                    break;
                }
            }
            TipoConta tipoDeConta = (tipo == "corrente" ? TipoConta.corrente : TipoConta.poupanca);
            Console.Clear();
            return new ContaBancaria(count, nomeDoTitular, tipoDeConta);
        }

    }
}
