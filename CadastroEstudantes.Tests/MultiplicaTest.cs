
using Xunit;

namespace CadastroEstudantes.Tests;
public class MultiplicaTest
{
    public int Mutiplica(int valor1, int valor2)
    {
        // Assert.True(true);
        return valor1 * valor2;
    }

    [Fact]
    public void MultiplicaCorreta()
    {
        var result = Mutiplica(2, 2);
        Assert.Equal(4, result);
    }

    [Fact]
    public void MultiplicacaoIncorreta()
    {
        var result = Mutiplica(5, 5);
        Assert.NotEqual(20, result);
    }
}