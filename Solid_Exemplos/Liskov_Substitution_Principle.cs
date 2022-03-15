using System;
using System.IO;

namespace Solid_Exemplos
{
    //The wrong way
    public interface IContratoDeTrabalho
    {
    }

    // Sobrescrevendo um método que não faz nada...
    public class Voluntario : IContratoDeTrabalho
    {
        public void Remuneracao()
        {
            // não faz nada
        }
    }

    //Lançando uma exceção inesperada...
    public class MusicPlay
    {
        public void Play(Stream file)
        {
            // toca a música   
        }
    }

    public class Mp3MusicPlay : MusicPlay
    {
        public void Play(Stream file)
        {
            string arquivo = "C:\\Users\\fulano\\Desktop\\arq01.txt";
            
            if (Path.GetExtension(arquivo) != "mp3")
            {
                throw new Exception();
            }

            // toca a música
        }
    }

    // Retornando valores de tipos diferentes...
    public class Auth
    {
        public bool CheckCredentials(string login, string password)
        {
            // faz alguma coisa

            return true;
        }
    }

    public class AuthApi : Auth
    {
        public new bool CheckCredentials(string login, string password)
        {
            // faz alguma coisa
            // No C# não é possível retornar valor de tipos diferentes
            return ("auth" == "true" && "status" == "200");
        }
    }

    //The right way
    public class A
    {
        protected string Nome;

        public A()
        {
            Nome = "A";
        }

        public string GetNome()
        {
            return $"Meu nome é {Nome}";
        }
    }

    public class B : A
    {
        public B()
        {
            Nome = "B";
        }
    }

    public class Executa
    {
        public string ImprimeNome(A objeto)
        {
            return objeto.GetNome();
        }
    }
}
