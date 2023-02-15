using Exercicio_02_03_04_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02_03_04_05.Data
{
    internal class MockUpContas
    {
        public static List<ContaBancaria> Gerar()
        {
            List<ContaBancaria> contas = new List<ContaBancaria>() {
                new ContaBancaria(0,344,863,"Kirird Kadfn",TipoConta.corrente,5078.06,"1"),
                new ContaBancaria(1,3544,8363,"Bondy Kulicke",TipoConta.corrente,597078.06,"1"),
                new ContaBancaria(2,5756,7804,"Lay Hathaway",TipoConta.corrente,579485.26,"1"),
                new ContaBancaria(3,6523,4876,"Vinny Aizikowitz",TipoConta.corrente,401657.87,"1"),
                new ContaBancaria(4,6974,8005,"Verna Plevin",TipoConta.poupanca,773007.51,"1"),
                new ContaBancaria(5,8923,9212,"Lola Forsyth",TipoConta.poupanca,167686.21,"1"),
                new ContaBancaria(6,6894,9907,"Susanetta Males",TipoConta.corrente,78028.35,"1"),
                new ContaBancaria(7,2946,625,"Heida Smardon",TipoConta.poupanca,779777.71,"1"),
                new ContaBancaria(8,7480,5743,"Dulcea Norssister",TipoConta.corrente,377021.9,"1"),
                new ContaBancaria(9,1837,8,"Bari Nannizzi",TipoConta.poupanca,640320.0,"1"),
                new ContaBancaria(10,7862,9836,"Abra Jindrak",TipoConta.corrente,140066.28,"1")
            };
            return contas;
        }
    }
}
