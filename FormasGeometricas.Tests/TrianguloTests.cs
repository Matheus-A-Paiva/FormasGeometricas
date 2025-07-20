using FormasGeometricas;
using Xunit;

namespace FormasGeometricas.Tests;

public class TrianguloTests
{
    [Fact]
    public void RetanguloDeveTer3DeAlturaE4DeBaseERetornar6()
    {
        //Arrange
        Forma triangulo = new Triangulo(3, 4);
        //Act
        double area = triangulo.CalcularArea();
        //Assert
        Assert.Equal(6, area);
    }
}