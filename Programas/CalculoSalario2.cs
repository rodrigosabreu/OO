namespace CalculoSalario2;

public class CalculadoraDeSalario
{
    public double CalculaSalario(Funcionario funcionario)
    {
        return funcionario.Cargo.Regra.Calcula(funcionario);
    }
}

public interface IRegraDeCalculo { double Calcula(Funcionario f); }

public class DezOuVintePorCento : IRegraDeCalculo
{
    public double Calcula(Funcionario funcionario)
    {
        if (funcionario.Salario > 3000)
        {
            return funcionario.Salario * 0.8;
        }
        return funcionario.Salario * 0.9;
    }
}

public class QuinzeOuVinteCincoPorCento : IRegraDeCalculo
{
    public double Calcula(Funcionario funcionario)
    {
        if (funcionario.Salario < 2500)
        {
            return funcionario.Salario * 0.85;
        }
        return funcionario.Salario * 0.75;
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

public class Cargo
{
    public static Cargo DESENVOLVEDOR
    { get { return new Cargo(new DezOuVintePorCento()); } }
    public static Cargo DBA
    { get { return new Cargo(new QuinzeOuVinteCincoPorCento()); } }
    public static Cargo QA
    { get { return new Cargo(new QuinzeOuVinteCincoPorCento()); } }
    public IRegraDeCalculo Regra { get; private set; }

    public Cargo(IRegraDeCalculo regra)
    {
        this.Regra = regra;
    }
}
