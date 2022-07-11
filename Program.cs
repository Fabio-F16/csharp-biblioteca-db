namespace csharp_biblioteca_db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // utente registrazione...?
            Console.WriteLine("Inserisci i dati per accedere");
            Console.WriteLine();
            Console.WriteLine("Inserisci il tuo nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo cognome");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci la tua email");
            string email = Console.ReadLine();

            Utente utente1 = new Utente(nome, cognome, email);

            // libri istanziati
            Libro libro1 = new Libro("Il signore degli anelli", 2002, "Claudio", "Bisio", "544-5-55-44444-4", 212);
            // Console.WriteLine(libro1.ToString());
            Libro libro2 = new Libro("Bibbia", 0000, "Antico", "Scrittore", "544-5-55-44444-4", 1432);
            // Console.WriteLine(libro2.ToString());


            // dvd istanziati
            



            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AggiungiUtente(utente1);
            biblioteca.AggiungiDocumento(libro1);
            biblioteca.AggiungiDocumento(libro2);
        

            biblioteca.StampaDocumento();
            biblioteca.StampaUtenti();
        }
    }
}