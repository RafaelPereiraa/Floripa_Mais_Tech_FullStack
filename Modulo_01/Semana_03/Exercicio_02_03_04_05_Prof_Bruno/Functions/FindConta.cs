/// Procura nas contas, uma conta com o número correspondente

using Exercicio_02_03_04_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02_03_04_05.Functions
{
    public  class FindConta { 
    public static ContaBancaria Find(List<ContaBancaria> contas, long numeroConta)
        {
            ContaBancaria contaLocalizada = contas.Find(c => c.GetNumeroDaConta() == numeroConta);


        return contaLocalizada == null? null : contaLocalizada;
        }
    }

}
