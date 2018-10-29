using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorbelliSaviniLinq_WPF
{
    class Libro
    {
        public  string CodiceScheda { get; set; }
        public  string Titolo { get; set; }
        public  string Cognome { get; set; }


        static List<Libro> libri = new List<Libro>();

        
        private static Array LoadArray(IEnumerable<string> caricando, string[] caricato)
        {
            int count = 0;

            foreach (string s in caricando)
            {
                caricato[count++] = s;
            }

            return caricato;
        }

        public static void LoadList(IEnumerable<string> codice, IEnumerable<string> titolo, IEnumerable<string> cognome)
        {
            string[] codici = new string[codice.Count()];
            string[] titoli = new string[titolo.Count()];
            string[] cognomi = new string[cognome.Count()];

            LoadArray(codice, codici);
            LoadArray(titolo, titoli);
            LoadArray(cognome, cognomi);

            for (int i = 0; i < codici.Length; i++)
            {
                libri.Add(new Libro { CodiceScheda = codici[i], Titolo = titoli[i], Cognome = cognomi[i] });
            }
        }
        public static List<Libro> GetAllBooks()
        {
            return libri;
        }

        

    }
}
