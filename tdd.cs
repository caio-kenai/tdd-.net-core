using Xunit;

public class CalculadoraTests
{
    [Fact]
    public void Soma_DeveRetornarValorCorreto()
    {
        var calc = new Calculadora();
        var resultado = calc.Soma(2, 3);
        Assert.Equal(5, resultado);
    }
}

public class Calculadora
{
    public int Soma(int a, int b) => a + b;
}
