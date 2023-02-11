using Exercicio_03_04_05_06.Models;

namespace Exercicio_03_04_05_06.Functions
{
    public class CriarConta
    {
        public static ContaBancaria CriarContaBancaria(int count)
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
    }
}
