
namespace Solid_Exemplos
{
    //The wrong way
    public interface Aves_wrong
    {
        public void SetLocalizacao(long longitude, long latitude);
        public void SetAltitude(long altitude);
        public void Renderizar();
    }

    public class Papagaio_wrong : Aves_wrong
    {
        public void Renderizar()
        {
            //Faz alguma coisa
        }

        public void SetAltitude(long altitude)
        {
            //Faz alguma coisa
        }

        public void SetLocalizacao(long longitude, long latitude)
        {
            //Faz alguma coisa
        }
    }

    public class Pinguim_wrong : Aves_wrong
    {
        public void Renderizar()
        {
            //Faz alguma coisa
        }

        // A Interface Aves está forçando a Classe Pinguim a implementar esse método.
        // Isso viola o príncipio ISP
        public void SetAltitude(long altitude)
        {
            //Faz alguma coisa
        }

        public void SetLocalizacao(long longitude, long latitude)
        {
            //Faz alguma coisa
        }
    }

    //The right way
    public interface Aves
    {
        public void SetLocalizacao(long longitude, long latitude);
        public void Renderizar();
    }

    public interface AvesQueVoam : Aves
    {
        public void SetAltitude(long altitude);
    }

    public class Papagaio : AvesQueVoam
    {
        public void Renderizar()
        {
            //Faz alguma coisa
        }

        //Com esse principio, nesse exemplo somente quem herda da interface AvesQueVoam implementarão esse método
        public void SetAltitude(long altitude)
        {
            //Faz alguma coisa
        }

        public void SetLocalizacao(long longitude, long latitude)
        {
            //Faz alguma coisa
        }
    }

    public class Pinguim : Aves
    {
        public void Renderizar()
        {
            //Faz alguma coisa
        }

        public void SetLocalizacao(long longitude, long latitude)
        {
            //Faz alguma coisa
        }
    }
}
