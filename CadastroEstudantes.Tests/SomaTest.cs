using Xunit;

namespace CadastroEstudantes.Tests;
public class SomaTest
{
    [Fact]
    public void SomaCorreta()
    {
        var result = Soma(2, 2);
        Assert.Equal(4, result);
    }

    [Fact]
    public void SomaIncorreta()
    {
        var result = Soma(2, 2);
        Assert.NotEqual(6, result);
    }

    public int Soma(int valor1, int valor2)
    {
        return valor1 + valor2;
    }
}