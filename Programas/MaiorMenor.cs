namespace Programas;

public class MaiorMenor
{
    public Produto Menor { get; set; }
    public Produto Maior { get; set; }

    public void Encontra(CarrinhoDeCompras carrinho)
    {
        foreach (Produto produto in carrinho.Produtos)
        {
            if (Menor is null || produto.Valor < Menor.Valor)
            {
                Menor = produto;
            }
            if (Maior is null || produto.Valor > Maior.Valor)
            {
                Maior = produto;
            }
        }
    }
}

public class Produto
{
    public Produto(string nome, decimal valor)
    {
        Nome = nome;
        Valor = valor;
    }

    public string Nome { get; set; }
    public decimal Valor { get; set; }
}

public class CarrinhoDeCompras
{
    public List<Produto> Produtos { get; set; }

    public CarrinhoDeCompras()
    {
        Produtos = new List<Produto>();
    }

    public void Adiciona(Produto produto)
    {
        Produtos.Add(produto);
    }
}