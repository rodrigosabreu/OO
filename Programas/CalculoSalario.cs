namespace Programas;

public class CalculadoraDeSalario
{
    public double CalculaSalario2(Funcionario funcionario)
    {
        if (funcionario.Salario > 3000)
        {
            return funcionario.Salario * 0.8;
        }
        return funcionario.Salario * 0.9;
    }

    public double CalculaSalario(Funcionario funcionario)
    {
        if (funcionario.Cargo.Equals(Cargo.DESENVOLVEDOR))
        {
            if (funcionario.Salario > 3000)
            {
                return funcionario.Salario * 0.8;
            }
            return funcionario.Salario * 0.9;
        }
        else if (funcionario.Cargo.Equals(Cargo.DBA))
        {
            if (funcionario.Salario < 2500)
            {
                return funcionario.Salario * 0.85;
            }
            return funcionario.Salario * 0.75;
        }
        throw new Exception("Funcionario invalido");
    }
}

public class Funcionario
{
    public String Nome { get; private set; }
    public double Salario { get; private set; }
    public Cargo Cargo { get; private set; }
    public Funcionario(String nome, double salario, Cargo cargo)
    {
        this.Nome = nome;
        this.Salario = salario;
        this.Cargo = cargo;
    }
}

public enum Cargo
{
    DESENVOLVEDOR,
    DBA,
    TESTADOR
}

