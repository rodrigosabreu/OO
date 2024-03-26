using Programas;

namespace CalculadoraDeSalarioTest;

public class CalculadoraDeSalarioUnitTest
{
    [Fact]
    public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
    {
        CalculadoraDeSalario calculadora = new ();

        Funcionario desenvolvedor = new ("Mauricio", 4000.0, Cargo.DESENVOLVEDOR);

        double salario = calculadora.CalculaSalario(desenvolvedor);

        Assert.Equal(4000.0 * 0.8, salario, 0.00001);
    }

    [Fact]
    public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
    {
        CalculadoraDeSalario calculadora = new ();
        Funcionario desenvolvedor = new("Mauricio", 4000.0, Cargo.DESENVOLVEDOR);
        double salario = calculadora.CalculaSalario(desenvolvedor);

        Assert.Equal(4000.0 * 0.8, salario, 0.00001);
    }

    [Fact]
    public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
    {
        CalculadoraDeSalario calculadora = new ();
        Funcionario dba = new ("Mauricio", 500.0, Cargo.DBA);

        double salario = calculadora.CalculaSalario(dba);

        Assert.Equal(500.0 * 0.9, salario, 0.00001);
    }
}
