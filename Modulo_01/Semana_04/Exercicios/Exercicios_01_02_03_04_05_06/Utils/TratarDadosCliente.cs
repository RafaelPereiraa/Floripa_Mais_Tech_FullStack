using Exercicios_01_02_03_04_05_06.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercicios_01_02_03_04_05_06.Utils
{
    internal partial class TratarDadosCliente
    {
        public static object Parse(PropertyInfo tipo)
        {

            switch (tipo.PropertyType.Name)
            {
                case nameof(DateTime):
                    while (true)
                    {
                        Console.WriteLine("Data de nascimento (formato 'dd/mm/yyyy')");
                        try
                        {
                            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            return data;
                        }
                        catch
                        {
                            Console.WriteLine("Data inválida");
                        }
                    }
                case nameof(EstadoCivil):
                    string estadoCivil;
                    while (true)
                    {
                        Console.WriteLine("Estado civil (c para casado - s para solteiro)");
                        estadoCivil = Console.ReadLine();
                        if (estadoCivil[0] == 'c' || estadoCivil[0] == 's')
                        {
                            return estadoCivil[0].Equals("c") ? EstadoCivil.casado : EstadoCivil.solteiro;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }                        
                    }
                case nameof(TipoPessoa):
                    string tipoPessoa;
                    while (true)
                    {
                        Console.WriteLine("Tipo de cadastro (f - pessoa física / j - pessoa jurídica)");
                        tipoPessoa = Console.ReadLine();
                        if (tipoPessoa[0] == 'f' || tipoPessoa[0] == 'j')
                        {
                            return tipoPessoa.Equals("f") ? TipoPessoa.fisica : TipoPessoa.juridica;
                        } else
                        {
                            Console.WriteLine("Opção inválida");
                        }
                    }
                default:
                    Console.WriteLine(tipo.Name[0].ToString().ToUpper() + tipo.Name[1..]);
                    return Console.ReadLine();
            }

        }

    }
}
