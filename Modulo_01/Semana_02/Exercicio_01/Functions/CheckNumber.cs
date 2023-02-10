namespace Exercicio_03_04_05_06.Functions
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
                if (number < 0)
                {
                    while (!double.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                }
                else
                {
                    return number;
                }
            }
            return number;
        }
    }
}
