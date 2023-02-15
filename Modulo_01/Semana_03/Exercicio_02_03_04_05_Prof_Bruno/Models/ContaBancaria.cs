using Exercicio_02_03_04_05.Functions;
using System.ComponentModel;

namespace Exercicio_02_03_04_05.Models
{
    public class ContaBancaria
    {
        // Atributo de controle
        public int id;
        
        // Atributos necessários dos exercícios
        private long numeroDaConta;
        private int agencia;
        private string nomeDoTitular;
        private double saldo;
        private TipoConta tipoDeConta;
        
        // Atributo extra
        private string senha;

        // Construtor para popular as contas
        public ContaBancaria(int id,long numeroDaConta, int agencia, string nomeDoTitular, TipoConta tipoDeConta, double saldo, string senha)
        {
            this.id = id;
            this.numeroDaConta = numeroDaConta;
            this.agencia = agencia;
            this.nomeDoTitular = nomeDoTitular;
            this.tipoDeConta = tipoDeConta;
            this.saldo = saldo;
            this.senha = senha;
        }
        
        // Construtor digitando todos os dados
        public ContaBancaria(int id, long numeroDaConta, int agencia, string nomeDoTitular, TipoConta tipoDeConta) {
            this.id = id;
            this.numeroDaConta = numeroDaConta;
            this.agencia = agencia;
            this.nomeDoTitular = nomeDoTitular;
            this.tipoDeConta = tipoDeConta;
            saldo = 0;
            DefinirSenha();
        }

        // Construtor com numero de conta aleatorio
        public ContaBancaria(int id, int agencia, string nomeDoTitular, TipoConta tipoDeConta)
        {
            this.id = id;
            numeroDaConta = Math.Abs(new Random().Next(0000, 9999));
            this.agencia = agencia;
            this.nomeDoTitular = nomeDoTitular;
            this.tipoDeConta = tipoDeConta;
            saldo = 0;
            DefinirSenha();
        }

        // Construtor com numero/agencia aleatorios
        public ContaBancaria(int id, string nomeDoTitular, TipoConta tipoDeConta)
        {
            this.id = id;
            numeroDaConta = Math.Abs(new Random().Next(0000, 9999));
            agencia = Math.Abs(new Random().Next(0000, 9999));
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

        public void Depositar(double valor, TipoDeposito tipoDeposito)
        {
            saldo += valor;

            if(tipoDeposito == TipoDeposito.comum) { 
                Console.WriteLine("Deposito efetuado com sucesso!");
                Console.WriteLine($"Seu saldo atual é de: {saldo}");
            }
        }

        public Boolean Sacar(double valor)
        {
            
            
                if (valor > saldo)
                {
                    Console.WriteLine("Saldo indisponível.");
                    return false;
                }
                else
                {
                    saldo -= valor;
                    Console.WriteLine($"Saldo restante {saldo}");
                    return true;
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

        public string ListarConta()
        {
            return $"Id: {id} - Conta: {numeroDaConta} - Agencia: {agencia}";
        }

        internal bool testaSenha(string senha)
        {
            if (this.senha != this.senha)
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            } else
            {
                return true;
            }
        }

        public void Transferir(ContaBancaria contaDestino, double valor)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor,TipoDeposito.transferencia);
                Console.WriteLine($"Depósito efetuado com sucesso na conta {contaDestino.numeroDaConta}");
            };
        }

        public long GetNumeroDaConta()
        {
            return numeroDaConta;
        }

        public enum TipoDeposito
        {
            [Description("comum")]
            comum,
            [Description("transferencia")]
            transferencia
        }
    }
}
