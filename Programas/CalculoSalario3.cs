namespace CalculoSalario3;

public class CalculadoraDeSalario
{
    public double CalculaSalario(Funcionario funcionario)
    {
        return funcionario.Cargo.Regra.Calcula(funcionario);
    }
}

public abstract class RegraDeCalculo
{
    public double Calcula(Funcionario funcionario)
    {
        if (funcionario.Salario > Limite())
        {
            return funcionario.Salario * PorcentagemAcimaDoLimite();
        }
        return funcionario.Salario * PorcentagemBase();
    }
    protected abstract int Limite();
    protected abstract double PorcentagemAcimaDoLimite();
    protected abstract double PorcentagemBase();
}

public class DezOuVintePorCento : RegraDeCalculo
{
    protected override double PorcentagemBase()
    {
        return 0.9;
    }
    protected override double PorcentagemAcimaDoLimite()
    {
        return 0.8;
    }
    protected override int Limite()
    {
        return 3000;
    }
}

public class QuinzeOuVinteCincoPorCento : RegraDeCalculo
{
    protected override double PorcentagemBase()
    {
        return 0.75;
    }
    protected override double PorcentagemAcimaDoLimite()
    {
        return 0.85;
    }
    protected override int Limite()
    {
        return 2500;
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
    public RegraDeCalculo Regra { get; private set; }
    public Cargo(RegraDeCalculo regra)
    {
        this.Regra = regra;
    }
}