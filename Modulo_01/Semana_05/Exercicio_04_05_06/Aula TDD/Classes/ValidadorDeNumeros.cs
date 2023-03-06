using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04.Classes
{
    public static class ValidadorDeNumeros
    {
       
        public static bool EhNumeroPrimo(int numero)
        {
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
        }

        public static bool ParOuImpar(int numero)
        {
            return numero % 2 == 0;
        }

        public static bool EhDivisivelPor(int numeroUM, int numeroDois)
        {
            return numeroUM % numeroDois == 0;
        }

    }
}
