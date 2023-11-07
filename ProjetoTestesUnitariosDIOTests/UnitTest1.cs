using ProjetoTestesUnitariosDIO.Services;

namespace ProjetoTestesUnitariosDIOTests
{
    public class UnitTest1
    {
        private readonly Tabuada _tabuada;

        public UnitTest1()
        {
            _tabuada = new Tabuada();    
        }

        [Theory]
        [InlineData(5, "+")]
        [InlineData(3, "-")]
        [InlineData(8, "*")]
        [InlineData(6, "/")]
        public void TestaTabuadaDe2(int num, string operacao)
        {
            //Arrange
            float resultaEsperado = 0;
            switch (operacao)
            {
                case "+":
                    resultaEsperado = num + 2;
                    break;
                case "-":
                    resultaEsperado = num - 2;
                    break;
                case "*":
                    resultaEsperado = num * 2;
                    break;
                case "/":
                    resultaEsperado = num / 2;
                    break;
                default:
                    break;
            }

            //Act
            var resultado = _tabuada.Tabuada2(num, operacao);

            //Assert
            Assert.Equal(resultado, resultaEsperado);


        }


        [Theory]
        [InlineData(5, "+")]
        [InlineData(3, "-")]
        [InlineData(8, "*")]
        [InlineData(6, "/")]
        public void TestaTabuadaDe3(int num, string operacao)
        {
            //Arrange
            float resultaEsperado = 0;
            switch (operacao)
            {
                case "+":
                    resultaEsperado = num + 3;
                    break;
                case "-":
                    resultaEsperado = num - 3;
                    break;
                case "*":
                    resultaEsperado = num * 3;
                    break;
                case "/":
                    resultaEsperado = num / 3;
                    break;
                default:
                    break;
            }

            //Act
            var resultado = _tabuada.Tabuada3(num, operacao);

            //Assert
            Assert.Equal(resultado, resultaEsperado);


        }

        [Theory]
        [InlineData(5, "+")]
        [InlineData(3, "-")]
        [InlineData(8, "*")]
        [InlineData(6, "/")]
        public void TestaTabuadaDe4(int num, string operacao)
        {
            //Arrange
            float resultaEsperado = 0;
            switch (operacao)
            {
                case "+":
                    resultaEsperado = num + 4;
                    break;
                case "-":
                    resultaEsperado = num - 4;
                    break;
                case "*":
                    resultaEsperado = num * 4;
                    break;
                case "/":
                    resultaEsperado = num / 4;
                    break;
                default:
                    break;
            }

            //Act
            var resultado = _tabuada.Tabuada4(num, operacao);

            //Assert
            Assert.Equal(resultado, resultaEsperado);


        }

        [Theory]
        [InlineData(5, "+")]
        [InlineData(3, "-")]
        [InlineData(8, "*")]
        [InlineData(6, "/")]
        public void TestaTabuadaDe5(int num, string operacao)
        {
            //Arrange
            float resultaEsperado = 0;
            switch (operacao)
            {
                case "+":
                    resultaEsperado = num + 5;
                    break;
                case "-":
                    resultaEsperado = num - 5;
                    break;
                case "*":
                    resultaEsperado = num * 5;
                    break;
                case "/":
                    resultaEsperado = num / 5;
                    break;
                default:
                    break;
            }

            //Act
            var resultado = _tabuada.Tabuada5(num, operacao);

            //Assert
            Assert.Equal(resultado, resultaEsperado);


        }
    }
}