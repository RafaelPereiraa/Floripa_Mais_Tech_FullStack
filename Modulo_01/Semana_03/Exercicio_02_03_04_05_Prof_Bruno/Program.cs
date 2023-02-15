using Exercicio_02_03_04_05.Data;
using Exercicio_02_03_04_05.Functions;
using Exercicio_02_03_04_05.Menus;
using Exercicio_02_03_04_05.Models;

namespace Exercicio_02_03_04_05;
internal class Program
{
    static void Main(string[] args)
    {
        List<ContaBancaria> contas = MockUpContas.Gerar();
        
        while (int.TryParse("0", out int escolha) || escolha < 7 & escolha > 0)
        {
            MenuInicial.Render();

            while (escolha > 7 ^ escolha < 1)
            {
                escolha = CheckNumber.Check("Escolha a opção desejada: ", false);
                if (escolha < 7 & escolha > 0)
                {
                    contas = Escolhas.Tratar(escolha, contas);
                    break;
                }                
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
        }
    }
}


