using Semana_01_Exercicio_01.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01_Exercicio_01.exercicios
{
    public class SequenciaFibonacci
    {

        public static void Executar()
        {


            MeuConsole.Write("Digite quantos números você deseja apresentar: ", true);
            MeuConsole.Write(sequenciaFibonacci(int.Parse(MeuConsole.ReadLine())), true);

            // Apenas lembrando que o primeiro e o segundo são 1 e ', e não "1 2" ^^'
            static string sequenciaFibonacci(int quantidade)
            {
                string sequencia = "1";
                int a = 0;
                for (int b = 1; quantidade > 1; --quantidade)
                {
                    int c = b + a;
                    sequencia = string.Concat(sequencia, $" {c}");
                    a = b;
                    b = c;
                }

                return sequencia;

            }
        }
    }
}