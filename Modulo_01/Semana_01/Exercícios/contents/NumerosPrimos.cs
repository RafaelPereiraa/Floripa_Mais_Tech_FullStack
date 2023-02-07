using Semana_01_Exercicio_01.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01_Exercicio_01.exercicios
{
    public class NumerosPrimos
    {

        public static void Executar()
        {

            List<int> numeros = new List<int>();
            int quantidade = 5;

            for (int i = 1; i <= quantidade; i++)
            {
                MeuConsole.WriteLine("Digite o " + i + "º número:");
                numeros.Add(int.Parse(MeuConsole.ReadLine()));
            }


            foreach (var item in numeros.Select((valor, posicao) => (valor, posicao)))
            {
                if (testePrimo(item.valor))
                {
                    MeuConsole.WriteLine(item.valor + " é primo!");
                    MeuConsole.WriteLine("Ele é o " + descobrePosicao(item.valor) + "º número primo!");
                }
            }

            bool testePrimo(int numero)
            {

                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0 && numero != 2)
                    {
                        return false;
                    }
                }
                return true;

            }

            int descobrePosicao(int numero)
            {
                int posicao = 0;
                for (int i = 2; i <= numero; i++)
                {
                    if (testePrimo(i))
                    {
                        posicao++;
                    }
                }

                return posicao;
            }

        }
    }
}
