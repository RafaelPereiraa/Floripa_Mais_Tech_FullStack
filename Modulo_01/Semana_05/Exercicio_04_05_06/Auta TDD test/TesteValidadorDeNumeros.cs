using Exercicio_04.Classes;

namespace Exercicio_04.Classes
{
    public class TesteValidadorDeNumeros
    {
        public static TheoryData<int, bool> DataPrimo =>
            new()
            {
                {2, true},{5, true},{12, false},{13, true },{839, true},{866, false},{883, true },{977, true},{978, false},{979, false}
            };

        public static TheoryData<int, bool> DataParOuImpar =>
            new()
            {
                {2, true},{5, false},{12, true},{13, false},{839, false},{866, true},{883, false},{977, false},{978, true},{979, false}
            };

        public static TheoryData<int, int, bool> DataEhDivisivelPor =>
            new()
            {
                {14, 2, true},{57, 5, false},{32, 8, true},{45,6, false},{838, 419, true}
            };

        [Theory]
        [MemberData(nameof(DataPrimo))]
        public void TestarEhNumeroPrimo(int numero, bool resultado)
        {
            Assert.Equal(resultado, ValidadorDeNumeros.EhNumeroPrimo(numero));
        }

        [Theory]
        [MemberData(nameof(DataParOuImpar))]
        public void TestarParOuImpar(int numero, bool resultado)
        {
            Assert.Equal(resultado, ValidadorDeNumeros.ParOuImpar(numero));
        }

        [Theory]
        [MemberData(nameof(DataEhDivisivelPor))]
        public void TestarEhDivisivelPor(int numeroUM,int numeroDois, bool resultado)
        {
            Assert.Equal(resultado, ValidadorDeNumeros.EhDivisivelPor(numeroUM, numeroDois));
        }
    }
}
