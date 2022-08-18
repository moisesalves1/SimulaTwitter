using System;

namespace SimulaTwitter
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagem = "Promoção iPhone 5 apenas R$1400,00";
            // Programe para uma interface
            // Encapsule o que muda
            IRedeSocial redeSocial = new Twitter();
            redeSocial.autenticar("moises", "moises");
            redeSocial.post(mensagem);
            Console.ReadLine();
        }
    }

    class RedeSocial
    {
        private Twitter twitter = new Twitter();
        private bool estaAutenticado;
        public void autenticar(string userName, string password)
        {
            twitter.estaAutenticado = userName == password;
        }

        public void post(string mensagem)
        {
            // simulando envio de um post para o Twitter
            if (twitter.estaAutenticado)
                twitter.post(mensagem);
        }
    }

    class Twitter : IRedeSocial
    {
        public bool estaAutenticado;
        public void autenticar(string userName, string password)
        {
            estaAutenticado = userName == password;
        }

        public void post(string mensagem)
        {
            // simulando envio de um post para o Twitter
            if (estaAutenticado)
                Console.WriteLine(mensagem);
        }
    }

}
