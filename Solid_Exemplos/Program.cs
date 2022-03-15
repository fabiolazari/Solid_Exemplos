using System;
using System.Data.SqlClient;

namespace Solid_Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single responsible principle
            Order order = new Order();
            order.AddItem(1);

            OrderRepository repository = new OrderRepository();
            repository.Save(order);

            OrderViewer orderViewer = new OrderViewer();
            orderViewer.ShowOrder(order);


            //Open-closed Principle
            Funcionario funcionario = new Funcionario();
            FolhaDePagamento FolhaDePagamento = new FolhaDePagamento();
            FolhaDePagamento.Calcular(funcionario);



            //Liskov Substitution Principle
            var objeto1 = new A();
            var objeto2 = new B();

            Executa executa = new Executa();
            Console.WriteLine(executa.ImprimeNome(objeto1)); // Meu nome é A
            Console.WriteLine(executa.ImprimeNome(objeto2)); // Meu nome é B

            Papagaio papagaio = new Papagaio();
            papagaio.Renderizar();
            papagaio.SetAltitude(2000);
            papagaio.SetLocalizacao(2454, 3000);

            Pinguim pinguim = new Pinguim();
            pinguim.Renderizar();
            pinguim.SetLocalizacao(2454, 3000);


            //Dependency Inversion Principle
            SqlConnection dbConnection = new SqlConnection();
            PasswordReminder passwordReminder = new PasswordReminder(dbConnection);


            Console.ReadKey();
        }
    }
}
