using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    internal class Libro : Documento
    {
        public string codiceIsbn;
        public int numeroPagine;

        public Libro(string titolo, int anno, string autoreNome, string autoreCognome, string codiceIsbn, int numeroPagine) : base(titolo, anno, autoreNome, autoreCognome)
        {
            this.codiceIsbn = codiceIsbn;
            this.numeroPagine = numeroPagine;
        }


        public override string ToString()
        {
            return base.ToString() + "\n" + "Codice ISBN: " + this.codiceIsbn + "\n" + "Numero pagine: " + this.numeroPagine + "\n" + "--------------------";
        }

    }
}
