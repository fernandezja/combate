namespace Combate.App.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void DebeSumar1mas1Yresultado2()
        {
            var suma = 1 + 1;

            Assert.Equal(expected: 2, 
                         actual: suma);
        }
    }
}
