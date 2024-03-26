using Programas;

namespace MaiorMenorTest;

public class ProdutosMaiorMenorUnitTest
{
    [Fact]
    public void OrdemDecrescente()
    {
        CarrinhoDeCompras carrinho = new();
        carrinho.Adiciona(new Produto("Geladeira", 450.0M));
        carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
        carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));

        MaiorMenor algoritmo = new MaiorMenor();
        algoritmo.Encontra(carrinho);

        Assert.Equal("Jogo de pratos", algoritmo.Menor.Nome);
        Assert.Equal("Geladeira", algoritmo.Maior.Nome);
    }

    [Fact]
    public void OrdemCrescente()
    {
        CarrinhoDeCompras carrinho = new();
        carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));
        carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
        carrinho.Adiciona(new Produto("Geladeira", 450.0M));

        MaiorMenor algoritmo = new MaiorMenor();
        algoritmo.Encontra(carrinho);

        Assert.Equal("Jogo de pratos", algoritmo.Menor.Nome);
        Assert.Equal("Geladeira", algoritmo.Maior.Nome);
    }

    [Fact]
    public void OrdemAleatorio()
    {
        CarrinhoDeCompras carrinho = new();
        carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
        carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));
        carrinho.Adiciona(new Produto("Geladeira", 450.0M));

        MaiorMenor algoritmo = new();
        algoritmo.Encontra(carrinho);

        Assert.Equal("Jogo de pratos", algoritmo.Menor.Nome);
        Assert.Equal("Geladeira", algoritmo.Maior.Nome);
    }

    [Fact]
    public void ApenasUmProduto()
    {
        CarrinhoDeCompras carrinho = new();
        carrinho.Adiciona(new Produto("Geladeira", 450.0M));

        MaiorMenor algoritmo = new();
        algoritmo.Encontra(carrinho);

        Assert.Equal("Geladeira", algoritmo.Maior.Nome);
        Assert.Equal("Geladeira", algoritmo.Menor.Nome);
    }
}