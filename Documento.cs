using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class Documento
    {
        public string Titolo { get; }
        public string autoreNome;
        public string autoreCognome;
        public int Anno { get; }
        public string[] settore = { "economia", "storia", "filosofia", "matematica" };
        public bool disponibile = true;
        public string posizioneScaffale;

        public Documento(string titolo, int anno, string autoreNome, string autoreCognome)
        {
            this.Titolo = titolo;
            this.Anno = anno;
            this.autoreNome = autoreNome;
            this.autoreCognome = autoreCognome;
        }

        public override string ToString()
        {
            return "\n" + "Titolo: " + this.Titolo + "\n" + "Nome autore: " + this.autoreNome + "\n" + "Cognome autore: " + this.autoreCognome + "\n" + "Anno: " + this.Anno;
        }
    }
}
