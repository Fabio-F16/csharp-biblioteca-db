using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class Utente

    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int recapitoTelefonico;
        public bool registrato = false;

        public Utente(string nome, string cognome, string email)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Email = email;
        }


        public override string ToString()
        {
            return "\n" + "Nome: " + this.Nome + "\n" + "Cognome: " + this.Cognome + "\n" + "Email: " + this.Email + "\n" + "Utente registrato: " + this.UtenteLoggato();
        }


        public bool UtenteLoggato()
        {
            if (this.Cognome.Length > 0 && this.Nome.Length > 0 && this.Email.Length > 0)
            {
                this.registrato = true;
                return this.registrato;
            }
            else
            {
                return this.registrato = false;
            }
        }
    }
}
