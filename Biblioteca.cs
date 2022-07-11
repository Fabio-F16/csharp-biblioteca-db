using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class Biblioteca
    {
        List<Utente> nuoviUtenti;
        List<Documento> documenti;


        public Biblioteca()
        {
            nuoviUtenti = new List<Utente>();
            documenti = new List<Documento>();
        }

        public void AggiungiUtente(Utente utente)
        {
            this.nuoviUtenti.Add(utente);
        }

        public void AggiungiDocumento(Documento documento)
        {
            this.documenti.Add(documento);
        }

        internal void StampaDocumento()
        {
            Console.WriteLine("Lista articoli:");
            Console.WriteLine();
            foreach (Documento documento in this.documenti)
            {
                Console.WriteLine(documento.GetType().Name);
                Console.WriteLine(documento.ToString());
            }
        }
        internal void StampaUtenti()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Lista utenti:");
            foreach (Utente utente in this.nuoviUtenti)
            {
                Console.WriteLine(utente.ToString());
            }
        }

    }
}
