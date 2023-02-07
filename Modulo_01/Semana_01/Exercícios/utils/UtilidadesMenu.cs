using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01_Exercicio_01.utils
{
    public class UtilidadesMenu
    {
        public static void CentralizarTexto(string texto, int posY)
        {
            int posX = ((Console.WindowWidth - texto.Length) / 2);
            Console.SetCursorPosition(posX, posY);
            return;
        }

        public static void EscreverBordasMenu(Boolean rodandoExercicio = false)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            const String menuMensagem = "Escolha o exercício que deseja testar";
            String menuBorda = "";

            Console.Clear();
            Console.SetWindowSize(120, 30);


            for (int i = 0; i < 118; ++i)
            {
                menuBorda = String.Concat(menuBorda, "#");
            }
            Console.SetCursorPosition(1, 0);
            Console.WriteLine(menuBorda);
            if (!rodandoExercicio)
            {
                Console.SetCursorPosition(1, 4);
                Console.WriteLine(menuBorda);
                CentralizarTexto(menuMensagem, 2);
                Console.WriteLine(menuMensagem);
            } else
            {
                Console.SetCursorPosition(1, 2);
                Console.WriteLine(menuBorda);
            }
            Console.SetCursorPosition(1, 28);
            Console.WriteLine(menuBorda);

            for (int i = 1; i < 29; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("#");
                Console.SetCursorPosition(118, i);
                Console.WriteLine("#");
            }

            if (rodandoExercicio)
            {
                Console.SetCursorPosition(3, 3);
            }

        }
        
    }


}
