namespace SimulaTwitter
{
    interface IRedeSocial
    {
        void autenticar(string userName, string password);
        void post(string mensagem);
    }
}