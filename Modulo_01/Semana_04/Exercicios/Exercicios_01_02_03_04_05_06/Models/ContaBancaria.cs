using Exercicios_01_02_03_04_05_06.Models;

namespace Exercicios_01_02_03_04_05_06.Models
{
    [Serializable]
    abstract class ContaBancaria
    {
        public int numero { get; protected set; }
        public int agencia { get; protected set; }
        public Cliente cliente { get; protected set; }
        public float saldo { get; protected set; } = 0;

        public ContaBancaria() { }
        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.cliente = cliente;
        }

        public virtual void Sacar(float valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque efetuado");
            }
        }

        public void Depositar(float valor)
        {
            saldo += valor;
        }

        public abstract void Transferir(ContaBancaria conta, float valor);

        public void ExibirSaldo()
        {
            Console.WriteLine(saldo);
        }

        public override string? ToString()
        {
            return 
                $"""
                Numero: {numero}
                Agencia: {agencia}
                Cliente: {cliente.ToString()}
                Saldo: {saldo}                
                """;
        }

        public virtual void Emprestimo(float valor) { }

        public virtual void PagandoEmprestimo(float valor) { }

    }
}
