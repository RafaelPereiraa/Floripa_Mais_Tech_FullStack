using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01_Exercicio_01.utils
{
    public class MeuConsole
    {
        public static void WriteLine(String texto)
        {
            SetPosition();
            Console.WriteLine(texto);
            SetPosition();
        }

        public static void Write(String texto, bool align = false)
        {
            if (align)
            {
                SetPosition(3,Console.CursorTop);
            }
            Console.Write(texto);
            SetPosition(3, Console.CursorTop + 1);

        }

        public static string? ReadLine()
        {
            return Console.ReadLine();
        }

        public static void ReadKey(Boolean read)
        {
            Console.ReadKey(read);
            SetPosition();
        }

        public static void CursorVisible(Boolean visible)
        {
            Console.CursorVisible = visible;
            SetPosition();
        }

        public static void Clear()
        {
            Console.Clear();
            SetPosition();
        }

        public static void SetPosition(int posX = 3, int posY = -10)
        {
            if (posY == -10)
            {
                posY = Console.CursorTop;
            }
            Console.SetCursorPosition(posX, posY);
        }

        public static void WriteTitle(String title)
        {
            UtilidadesMenu.CentralizarTexto(title, 1);
            Console.WriteLine(title);
            UtilidadesMenu.CentralizarTexto(title, 3);
        }

    }
}
