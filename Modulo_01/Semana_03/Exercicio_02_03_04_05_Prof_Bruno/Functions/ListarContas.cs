// Lista as contas cadastradas

using Exercicio_02_03_04_05.Models;

namespace Exercicio_02_03_04_05.Functions
{
    internal class ListarContas
    {

        public static void Listar(List<ContaBancaria> contas)
        {
            foreach (ContaBancaria conta in contas)
            {
                Console.WriteLine(conta.ListarConta());
            }
        }
    }
}
