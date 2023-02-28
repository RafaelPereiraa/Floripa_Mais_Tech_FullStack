using System;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {


        double numeroUm = 0;
        double numeroDois = 0;

        try
        {
            Console.Write("Digite o primeiro número: ");
            numeroUm = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            numeroDois = double.Parse(Console.ReadLine());
            try
            {
                if (numeroDois == 0)
                {
                    throw new DividedByZeroException();
                }
                Console.WriteLine(numeroUm / numeroDois);
            }
            catch (DividedByZeroException exception)
            {
                Console.WriteLine($"{exception.Message}", exception);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Somente números podem ser digitados");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{exception.Message}", exception);
            }            
        }
        catch (FormatException exception)
        {
            Console.WriteLine($"Somente números podem ser digitados - {exception.Message}");
        }
        finally
        {
            numeroUm = 0;
            numeroDois = 0;
        }
        Console.WriteLine($"Números ao final: {numeroUm} e {numeroDois}");
    }
}