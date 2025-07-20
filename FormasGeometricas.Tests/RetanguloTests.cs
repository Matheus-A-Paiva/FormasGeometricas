using FormasGeometricas;
using Xunit;

namespace FormasGeometricas.Tests;


public class RetanguloTests
{
    [Fact]
    public void RetanguloDeveTer10DeAlturaE5DeLarguraERetornar50()
    {
        //Arrange
        Forma retangulo = new Retangulo(10, 5);
        //Act
        double area = retangulo.CalcularArea();
        //Assert
        Assert.Equal(50, area);
    }
}