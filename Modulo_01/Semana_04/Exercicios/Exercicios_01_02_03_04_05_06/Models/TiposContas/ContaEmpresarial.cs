using Exercicios_01_02_03_04_05_06.Models;

namespace Exercicios_01_02_03_04_05_06.Models.TiposContas
{
    internal class ContaEmpresarial : ContaBancaria
    {
        public float limiteEmprestimo { get; private set; }
        public float taxaJuros { get; private set; }
        public Boolean possuiEmprestimo { get; private set; } = false;
        public float valorUsado { get; private set; }
        public string cnpj { get; private set; }

        public ContaEmpresarial(int numero, int agencia, Cliente cliente, float limiteEmprestimo, float taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            if (cliente.tipoPessoa == TipoPessoa.fisica) throw new ArgumentException("Tipo de conta indisponível");

            this.limiteEmprestimo = limiteEmprestimo;
            this.taxaJuros = taxaJuros;           
            this.cnpj = cnpj;
        }

        public override void Emprestimo(float valor) => FazerEmprestimo(valor);

        public void FazerEmprestimo(float valorEmprestimo)
        {
            if (valorEmprestimo > limiteEmprestimo || possuiEmprestimo)
            {
                Console.WriteLine("Empréstimo indisponível");
            }
            else
            {
                Console.WriteLine("Empréstimo Efetuado");
                possuiEmprestimo = true;
                saldo += valorEmprestimo;
                valorUsado = valorEmprestimo * (1 + taxaJuros / 100);
            }
        }
        public override void PagandoEmprestimo(float valor) => PagarEmprestimo(valor);

        public void PagarEmprestimo(float valorPagamento)
        {
            if (valorPagamento > valorUsado && valorPagamento <= saldo)
            {
                Console.WriteLine("Empréstimo pago");
                valorUsado = 0;
                saldo -= valorPagamento;
                possuiEmprestimo = false;
            }
            else {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public override void Sacar(float valor)
        {
            if (this.saldo >= valor + 1.0f)
            {
                this.saldo -= valor + 1.0f;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        public override void Transferir(ContaBancaria conta, float valor)
        {
            if (saldo >= valor + 0.5f)
            {
                saldo -= valor + 0.5f;
                conta.Depositar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        new public string ToString()
        {
            return
                $"""
                {base.ToString()}
                Limite Empréstimo: R${limiteEmprestimo}
                Taxa de Juros: {taxaJuros}%
                Valor usado: R${valorUsado}
                CNPJ: {cnpj}
                """;
        }
    }
}
