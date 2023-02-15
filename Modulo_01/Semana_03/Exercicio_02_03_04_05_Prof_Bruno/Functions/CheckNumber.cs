///Função para testar se os valores digitados durante a execução do programa condizem com os tipos das variáveis que estes são atribuidos.
/// O método "Check(string mensagem, bool limpar = false)" testa as opções de seleção, bem como entrada de atributos da classe ContaBancaria.
/// O parametro "mensagem" exibe a mensagem sobre o que deve ser digitado. O parâmetro limpar, define se deve limpar o console.
/// O Método "CheckDouble" verifica se os valores são positivos e condizem um valor monetário.
/// 
namespace Exercicio_02_03_04_05.Functions
{
    public static class CheckNumber
    {
        public static int Check(string mensagem, bool limpar = false)
        {
            Console.WriteLine(mensagem);
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                if (limpar) { Console.Clear(); }
                Console.WriteLine("Entrada Inválida");
                Console.WriteLine(mensagem);
            }
            return number;
        }

        public static double CheckDouble()
        {
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                while (number <= 0)
                {
                    if (number <= 0)
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    while (!double.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    
                }

                return number;

            }
            else
            {
                Console.WriteLine("Valor inválido.");
                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Valor inválido.");
                }

            }
            return number;
        }
    }
}
