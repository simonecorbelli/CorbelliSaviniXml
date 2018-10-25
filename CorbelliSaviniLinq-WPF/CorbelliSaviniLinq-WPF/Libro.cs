using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorbelliSaviniLinq_WPF
{
    class Libro
    {
        public string CodiceScheda { get; set; }
        public string CodiceDewey { get; set; }
        public string Cognome { get; set; }
        public string Genere { get; set; }
        public string Abstract { get; set; }

        static List<Libro> libri;

        public static List<Libro> LoadfromXml()
        {
            return libri;
        }

        

    }
}
