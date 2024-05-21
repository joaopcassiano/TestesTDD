using Xunit;
using System;
using TestesTDD;

namespace TesteTDDTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void SomaTeste(int num1, int num2, int resultado)
        {
            Calculadora CalculadoraSoma = new Calculadora();

            int resultadoCalculadora = CalculadoraSoma.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(9, 5, 4)]
        public void SubtrairTeste(int num1, int num2, int resultado)
        {
            Calculadora CalculadoraSubtrair = new Calculadora();

            int resultadoCalculadora = CalculadoraSubtrair.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(9, 2 ,18)]
        public void MultiplicarTeste(int num1, int num2, int resultado)
        {
            Calculadora CalculadoraMultiplicar = new Calculadora();

            int resultadoCalculadora = CalculadoraMultiplicar.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(81, 9, 9)]
        public void DividirTeste(int num1, int num2, int resultado)
        {
            Calculadora CalculadoraDividir = new Calculadora();

            int resultadoCalculadora = CalculadoraDividir.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPor0()
        {
            Calculadora CalculadoraDivisaoPor0 = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => CalculadoraDivisaoPor0.Dividir(3, 0));
        }
    }
}