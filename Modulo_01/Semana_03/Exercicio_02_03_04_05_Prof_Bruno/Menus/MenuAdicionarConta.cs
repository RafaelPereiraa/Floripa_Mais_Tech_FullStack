using Exercicio_02_03_04_05.Functions;
using Exercicio_02_03_04_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02_03_04_05.Menus
{
    public class MenuAdicionarConta
    {

        public static ContaBancaria Render(int id, List<ContaBancaria> contas)
        {
            List<string> options = new List<string>() { "1 - Criar conta (Todos os dados)", "2 - Criar conta decidindo agencia", "3 - Criar conta aleatória (apenas nome,tipo e senha)" };
            int escolha = -1;
            ContaBancaria novaConta = null;

            Console.WriteLine("Escolha o método de criação de conta");
            foreach (string opt in options)
            {
                Console.WriteLine(opt);
            }

            while (escolha > 3 ^ escolha < 1)
            {
                escolha = CheckNumber.Check("Escolha a opção desejada: ", false);
                if (escolha <= 3 & escolha > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }


            switch (escolha)
            {
                case 1:
                    novaConta = CriarConta.CriarContaCompleta(contas.Count);
                    break;
                case 2:
                    novaConta = CriarConta.CriarContaComAgencia(contas.Count);
                    break;
                case 3:
                    novaConta = CriarConta.CriarContaAleatoria(contas.Count);
                    break;
            }

            return novaConta;

        }
    }
}
