using Programas;

namespace NumeroRomanoTest;

public class ConversorNumeroRomanoUnitTest
{
    [Fact]
    public void DeveEntenderOSimboloI()
    {
        ConversorNumeroRomano romano = new();
        int numero = romano.Converte("I");
        Assert.Equal(1, numero);
    }

    [Fact]
    public void DeveEntenderOSimboloV()
    {
        ConversorNumeroRomano romano = new();
        int numero = romano.Converte("V");
        Assert.Equal(5, numero);
    }

    [Fact]
    public void DeveEntenderOSimboloII()
    {
        ConversorNumeroRomano romano = new();
        int numero = romano.Converte("II");
        Assert.Equal(2, numero);
    }

    [Fact]
    public void DeveEntenderOSimboloXXII()
    {
        ConversorNumeroRomano romano = new();
        int numero = romano.Converte("XXII");
        Assert.Equal(22, numero);
    }

    [Fact]
    public void DeveEntenderOSimboloIX()
    {
        ConversorNumeroRomano romano = new();
        int numero = romano.Converte("IX");
        Assert.Equal(9, numero);
    }

    [Fact]
    public void DeveEntenderOSimboloIV()
    {
        ConversorNumeroRomano romano = new();
        int numero = romano.Converte("IV");
        Assert.Equal(4, numero);
    }

    [Fact]
    public void DeveEntenderOSimboloXXIV()
    {
        ConversorNumeroRomano romano = new();
        int numero = romano.Converte("XXIV");
        Assert.Equal(24, numero);
    }
}
