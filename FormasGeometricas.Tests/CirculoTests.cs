using FormasGeometricas;
using Xunit;

namespace FormasGeometricas.Tests;

public class CirculoTests
{
    [Fact]
    public void RetanguloDeveTer3DeAlturaE4DeBaseERetornar6()
    {
        //Arrange
        Forma circulo = new Circulo(2);
        //Act
        double area = circulo.CalcularArea();
        //Assert
        Assert.Equal(Math.PI * 4, area, precision: 3);
    }
}