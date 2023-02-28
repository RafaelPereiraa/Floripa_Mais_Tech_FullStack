using Exercicios_01_02_03_04_05_06.Models;

namespace Exercicios_01_02_03_04_05_06.Models.TiposContas
{
    internal class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.tipoPessoa == TipoPessoa.juridica) throw new ArgumentException("Tipo de conta indisponível");
        }
        public override void Sacar(float valor)
        {
            if (saldo >= valor + 0.1f)
            {
                saldo -= valor + 0.1f;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public override void Transferir(ContaBancaria conta, float valor)
        {
            if (saldo >= valor + 0.05f)
            {
                saldo -= valor + 0.05f;
                conta.Depositar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
