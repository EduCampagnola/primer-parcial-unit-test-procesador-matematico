using primer_parcial_unit_test_procesador_matematico;
using Xunit;

namespace ProcesadorMatematicoTest
{
    public class UnitTest1
    {
        [Fact]
        public void Suma_ConValoresValidos_DevuelveSuma()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            int resultadoEsperado = 10;

            //Act
            int resultadoReal = procesadorMatematico.Sumar(5, 5);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        [Fact]
        public void Suma_ConValoresInvalidos_Devuelve0()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            int resultadoEsperado = 0;

            //Act
            int resultadoReal = procesadorMatematico.Sumar(5, -5);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }
    }
}