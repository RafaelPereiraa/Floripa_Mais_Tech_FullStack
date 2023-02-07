using Semana_01_Exercicio_01.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01_Exercicio_01.exercicios
{
    public class SepararParImpar
    {

        public static void Executar()
        {


            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            int quantidade = 10;

            for (int i = 1; i <= quantidade; i++)
            {
                MeuConsole.Write("Digite o " + i + "ª número:", true);
                int numero = int.Parse(MeuConsole.ReadLine());
                if (testaPar(numero))
                {
                    pares.Add(numero);
                }
                else
                {
                    impares.Add(numero);
                };

            }

            bool testaPar(int numero)
            {
                if (numero % 2 == 0) { return true; }
                return false;
            }

            pares.Sort();
            impares.Sort();

            MeuConsole.WriteLine($"Quantidade de números pares: {pares.Count()} -- Soma dos números: {pares.Sum()}!");
            MeuConsole.WriteLine($"Quantidade de números ímpares: {impares.Count()} -- Soma dos números: {impares.Sum()}!");

        }
    }
}