namespace csharp_biblioteca_db
{
    using System.Data.SqlClient;

    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Console.WriteLine("**** BIBLIOTECA ****");
            Console.WriteLine("Digita il numero corrispondente all'azione");
            Console.WriteLine("1-Registrazione");
            Console.WriteLine("2-Login");
            string risposta = Console.ReadLine();

            if (risposta == "1")
            {
                biblioteca.Registrazione();
                Console.WriteLine("Riefettuare il login");
            }
            else
            {
                biblioteca.Login();
                Console.WriteLine("Digita il numero corrispondente");
                Console.WriteLine("1-Noleggia libro");
                Console.WriteLine("2-Cerca libro");
                risposta = Console.ReadLine();

                if(risposta == "1")
                {
                    biblioteca.addPrestito();
                }
                else
                {
                    biblioteca.RicercaLibro();
                }
            }


        }
    }
}