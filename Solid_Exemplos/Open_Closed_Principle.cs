
namespace Solid_Exemplos
{
    //The wrong way
    public enum TipoFuncionario_ww
    {
        ContratoClt_wrong_way,
        Estagio_wrong_way
    }

    public class Funcionario_ww
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public decimal Salario { get; set; }
        public decimal BolsaAuxilio { get; set; }
        public TipoFuncionario_ww TipoFuncionario { get; set; }
    }

    public class ContratoClt_wrong_way
    {
        public decimal Salario()
        {
            decimal salario = 1200.00M;
            Funcionario_ww funcionario = new Funcionario_ww();
            funcionario.Salario = salario;
            return salario;
        }
    }

    public class Estagio_wrong_way
    {
        public decimal BolsaAuxilio()
        {
            decimal bolsa = 600.00M;
            Funcionario_ww funcionario = new Funcionario_ww();
            funcionario.BolsaAuxilio = bolsa;
            return bolsa;
        }
    }

    public class FolhaDePagamento_wrong_way
    {
        protected decimal saldo;
        protected Funcionario_ww funcionario;
    
        public void calcular(Funcionario_ww funcionario)
        {
            if (funcionario.TipoFuncionario == TipoFuncionario_ww.ContratoClt_wrong_way) 
            {
                ContratoClt_wrong_way clt = new ContratoClt_wrong_way();
                saldo = clt.Salario();
            } 
            else if (funcionario.TipoFuncionario == TipoFuncionario_ww.Estagio_wrong_way) 
            {
                Estagio_wrong_way estagio = new Estagio_wrong_way();
                saldo = estagio.BolsaAuxilio();
            }
        }
    }

    //The right way
    public class Funcionario
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public decimal Salario { get; set; }
    }

    public interface IRemuneravel
    {
        public decimal Remuneracao(Funcionario funcionario);
    }

    public class ContratoClt : IRemuneravel
    {
        public decimal Remuneracao(Funcionario funcionario)
        {
            decimal salario = 1200.00M;
            funcionario.Salario = salario;
            return salario;
        }
    }

    public class Estagio : IRemuneravel
    {
        public decimal Remuneracao(Funcionario funcionario)
        {
            decimal salario = 600.00M;
            funcionario.Salario = salario;
            return salario;
        }
    }

    public class FolhaDePagamento
    {
        protected decimal saldo;
        IRemuneravel remuneravel;

        public void Calcular(Funcionario funcionario)
        {
            saldo = remuneravel.Remuneracao(funcionario);
        }
    }
}
