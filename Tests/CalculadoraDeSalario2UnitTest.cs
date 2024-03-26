using CalculoSalario2;

namespace CalculadoraDeSalario2Test;

public class CalculadoraDeSalario2UnitTest
{
    [Fact]
    public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
    {
        CalculadoraDeSalario calculadora = new ();
        Cargo DEV = Cargo.DESENVOLVEDOR;

        Funcionario desenvolvedor = new ("Mauricio", 4000.0, DEV);

        double salario = calculadora.CalculaSalario(desenvolvedor);

        Assert.Equal(4000.0 * 0.8, salario, 0.00001);
    }

    [Fact]
    public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
    {
        CalculadoraDeSalario calculadora = new ();
        Cargo DEV = Cargo.DESENVOLVEDOR;

        Funcionario desenvolvedor = new("Mauricio", 2900.0, DEV);
        double salario = calculadora.CalculaSalario(desenvolvedor);

        Assert.Equal(2900.0 * 0.9, salario, 0.00001);
    }

    [Fact]
    public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
    {
        CalculadoraDeSalario calculadora = new ();
        Cargo DBA = Cargo.DBA
            ;
        Funcionario dba = new ("Mauricio", 2000.0, DBA);

        double salario = calculadora.CalculaSalario(dba);

        Assert.Equal(2000.0 * 0.85, salario, 0.00001);
    }

    [Fact]
    public void DeveCalcularSalarioParaDBAsComSalarioAcimaDoLimite()
    {
        CalculadoraDeSalario calculadora = new();
        Cargo DBA = Cargo.DBA
            ;
        Funcionario dba = new("Mauricio", 3000.0, DBA);

        double salario = calculadora.CalculaSalario(dba);

        Assert.Equal(3000.0 * 0.75, salario, 0.00001);
    }
}
