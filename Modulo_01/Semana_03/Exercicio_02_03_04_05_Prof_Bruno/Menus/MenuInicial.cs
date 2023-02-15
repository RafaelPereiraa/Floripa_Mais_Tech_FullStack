using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02_03_04_05.Menus
{
    public class MenuInicial
    {

        public static void Render()
        {
            List<string> Opcoes = new List<string>() { "1 - Nova Conta", "2 - Depositar", "3 - Sacar", "4 - Exibir Saldo", "5 - Listar todas as contas", "6 - Transferir entre contas", "7 - Sair" };

            Console.WriteLine("Que operação deseja realizar?");
            foreach (string opt in Opcoes)
            {
                Console.WriteLine($"{opt}");
            }
        }
    }
}
