using Exercicio_04.Classes;
using NuGet.Frameworks;

namespace Auta_TDD_test
{
    public class TesteCalculadora
    {
        public static TheoryData<dynamic, dynamic, dynamic> DataSoma =>
            new()
            {
                {1, 2, 3},
                {2.5, 3.2, 5.7},
                {10.0f, 20.0f, 30.0f},
                {1000L, 2000L, 3000L},
                {10.5M, 20.7M, 31.2M}
            };

        public static TheoryData<dynamic, dynamic, dynamic> DataSubtracao =>
            new()
            {
                {3, 2, 1},
                {3.5, 2.5, 1.0},
                {22.5f, 20.5f, 2.0f},
                {1515L, 1015L, 500L},
                {22.5M, 20.3M, 2.2M}
            };

        public static TheoryData<dynamic, dynamic, dynamic> DataMultiplicacao =>
            new()
            {
                {3, 3, 9},
                {3.5, 2.0, 7},
                {22.5f, 20f, 450.0f},
                {1515L, 1015L, 1537725L},
                {22.5M, 2.0M, 45.00M}
            };

        public static TheoryData<dynamic, dynamic, dynamic> DataDivisao =>
            new()
            {
                {3, 3, 1},
                {6.5, 2.0, 3.25},
                {22.5f, 3.2f, 7.03125f},
                {1515L, 15L, 101L},
                {22.5M, 6.4M, 3.515625M}
            };

        [Theory]
        [MemberData(nameof(DataSoma))] 
        public void TestarSoma(dynamic numeroUm, dynamic numeroDois, dynamic resultado)
        {            
            Assert.Equal(resultado, Calculadora.Somar(numeroUm, numeroDois));
        }

        [Theory]
        [MemberData(nameof(DataSubtracao))]
        public void TestarSubtracao(dynamic numeroUm, dynamic numeroDois, dynamic resultado)
        {                   
            Assert.Equal(resultado, Calculadora.Subtrair(numeroUm, numeroDois));
        }

        [Theory]
        [MemberData(nameof(DataMultiplicacao))]
        public void TestarMultiplicacao(dynamic numeroUm, dynamic numeroDois, dynamic resultado)
        {
            Assert.Equal(resultado, Calculadora.Multiplicar(numeroUm, numeroDois));
        }

        [Theory]
        [MemberData(nameof(DataDivisao))]
        public void TestarDivisao(dynamic numeroUm, dynamic numeroDois, dynamic resultado)
        {
            Assert.Equal(resultado, Calculadora.Dividir(numeroUm, numeroDois));
        }

    }
}