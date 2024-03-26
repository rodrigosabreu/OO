using Programas;

namespace CarrinhoDeComprasTest;

public class CarrinhoDeComprasUnitTests
{
    private CarrinhoDeCompras2 carrinho;

    public CarrinhoDeComprasUnitTests()
    {
        this.carrinho = new();
    }

    [Fact]
    public void DeveRetornarMaiorValorDoItemSeCarrinhoCom1Elemento()
    {
        carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

        Assert.Equal(900.0, carrinho.MaiorValor(), 0.0001);
    }

    [Fact]
    public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
    {
        carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
        carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
        carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

        Assert.Equal(1500.0, carrinho.MaiorValor(), 0.0001);
    }

    [Fact]
    public void DeveRetornarZeroSeCarrinhoVazio()
    {
        Assert.Equal(0.0, carrinho.MaiorValor(), 0.0001);
    }
}
