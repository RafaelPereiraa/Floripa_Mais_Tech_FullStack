using Exercicio_03_04_05_06.Functions;
using System.ComponentModel;


namespace Exercicio_03_04_05_06.Models
{
    public class ContaBancaria
    {
        public int id;
        private long numeroDaConta;
        private int agencia;
        private string nomeDoTitular;
        private double saldo;
        private string senha;
        private TipoConta tipoDeConta;

        public ContaBancaria(int id, int agencia, string nomeDoTitular, TipoConta tipoDeConta)
        {
            this.id = id;
            numeroDaConta = Math.Abs(new Random().Next(10000000, 99999999));
            this.agencia = agencia;
            this.nomeDoTitular = nomeDoTitular;
            this.tipoDeConta = tipoDeConta;
            saldo = 0;
            DefinirSenha();
        }

        private void DefinirSenha()
        {
            while (true)
            {
                Console.Write("Defina sua senha: ");
                string senha = Console.ReadLine();
                if (senha != "")
                {
                    this.senha = senha;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Senha inválida");
                }
            }
        }

        public void Depositar()
        {
            Console.WriteLine("Quanto deseja depositar: ");
            saldo += CheckNumber.CheckDouble();
            Console.WriteLine("Deposito efetuado com sucesso!");
            Console.WriteLine($"Seu saldo atual é de: {saldo}");
        }

        public void Sacar()
        {
            Console.WriteLine("Digite sua senha: ");
            if (Console.ReadLine() != senha)
            {
                Console.WriteLine("Senha incorreta.");
            }
            else
            {
                Console.WriteLine("Quanto deseja sacar?");
                double valorSaque = CheckNumber.CheckDouble();

                if (valorSaque > saldo)
                {
                    Console.WriteLine("Saldo indisponível.");
                    return;
                }
                else
                {
                    saldo -= valorSaque;
                    Console.WriteLine($"Saldo restante {saldo}");
                }
            }
        }

        public override string ToString()
        {
            return $"Nome: {nomeDoTitular}\n" +
                $"Conta: {numeroDaConta}\n" +
                $"Agencia: {agencia}\n" +
                $"Tipo: conta {tipoDeConta}\n" +
                $"Saldo: {saldo:N2}\n"
                ;
        }
    }

    public enum TipoConta
    {
        [Description("Corrente")]
        corrente,
        [Description("Poupança")]
        poupanca

    }
}
