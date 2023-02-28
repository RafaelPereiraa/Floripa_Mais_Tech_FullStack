using Exercicios_01_02_03_04_05_06.Models;

namespace Exercicios_01_02_03_04_05_06.Models.TiposContas
{
    internal class ContaCorrente : ContaBancaria
    {

        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.tipoPessoa == TipoPessoa.juridica) {
                throw new ArgumentException("Tipo de conta indisponível");
                return;
             };
        }

        public override void Sacar(float valor)
        {
            if (saldo >= valor + 0.5f)
            {
                saldo -= valor + 0.5f;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public override void Transferir(ContaBancaria conta, float valor)
        {
            if (saldo >= valor + 0.25f)
            {
                saldo -= valor + 0.25f;
                conta.Depositar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
