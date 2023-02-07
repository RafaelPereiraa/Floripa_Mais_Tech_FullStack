using Semana_01_Exercicio_01.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01_Exercicio_01.exercicios
{
    public class OrdenaFrutas
    {

        public static void Executar()
        {


            List<string> frutas = new List<string>();
            int quantidade = 3;

            for (int i = 1; i <= quantidade; i++)
            {
                MeuConsole.WriteLine("Digite a " + i + "ª fruta:");
                frutas.Add(MeuConsole.ReadLine());
            }

            frutas.Sort();

            MeuConsole.WriteLine("Lista ordenada!");
            foreach (string fruta in frutas)
            {
                MeuConsole.WriteLine(fruta);
            }
        }
    }
}
