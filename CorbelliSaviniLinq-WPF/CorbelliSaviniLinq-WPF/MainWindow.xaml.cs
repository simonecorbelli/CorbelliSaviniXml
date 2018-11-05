using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace CorbelliSaviniLinq_WPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        XDocument xmlDocument = XDocument.Load(@"..\..\libri.xml");
        private void btn_Crea_Click_1(object sender, RoutedEventArgs e)
        {
            string autore;

            autore = txt_Autore.Text;

            autore.Trim();
            if (autore == "")
                MessageBox.Show("Inserire un autore adeguato");
            else
            {
                IEnumerable<string> libri = from Biblioteca in xmlDocument.Descendants("wiride")

                                            where (string)Biblioteca.Element("autore").Element("cognome") == autore

                                            select Biblioteca.Element("titolo").Value;


                

                foreach (string nomi in libri)
                    lst_Output.Items.Add(nomi);
            }
            //xmlDoc.Save(@"C:\Users\simone.corbelli\Desktop\newlibri.xml");
        }

        private void btnFile_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_Load_Click(object sender, RoutedEventArgs e)
        {
            //xmlDocument = XDocument.Load(@"..\..\libri.xml");
        }

        private void lst_Output_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_Conta_Click(object sender, RoutedEventArgs e)
        {
            string titolo;

            titolo = txt_Testo.Text;

            titolo.Trim();
            if (titolo == "")
                MessageBox.Show("Inserire un titolo adeguato");

            else
            {
                IEnumerable<string> libri = from Biblioteca in xmlDocument.Descendants("wiride")

                                            where (string)Biblioteca.Element("titolo") == titolo

                                            select Biblioteca.Element("titolo").Value;

                int cont = 0;

                foreach (string titoli in libri)
                    cont++;

                lbl_titolo.Content = "Numero di copie: " + cont;
            }
        }

        private void btn_Romanzo_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<string> libri = from Biblioteca in xmlDocument.Descendants("wiride")

                                        select Biblioteca.Element("genere").Value;

            int cont = 0;

            foreach (string romanzo in libri)
            {
                if (romanzo.Contains("romanzo"))
                    cont++;
            }

            MessageBox.Show("Numero di romanzi: " + cont);
        }

        private void btn_Abstract_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Sicuro di voler eliminare il tag abstract?", "AVVISO DI ELIMINAZIONE", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                xmlDocument.Nodes().OfType<XElement>().Elements("wiride").Elements("abstract").Remove();

                xmlDocument.Save(@"..\..\libri.xml");

                MessageBox.Show("Tag abstract elimintao");
            }
        }

        private void btn_NewFile_Click(object sender, RoutedEventArgs e)
        {
            // codice scheda
            // titolo 
            // cognome
            // dichiarazione
            // wiride -> libro




            

                    



            IEnumerable<string> codice = from Biblioteca in xmlDocument.Descendants("wiride")

                                         select Biblioteca.Element("codice_scheda").Value;

            IEnumerable<string> titolo = from Biblioteca in xmlDocument.Descendants("wiride")

                                         select Biblioteca.Element("titolo").Value;

            IEnumerable<string> cognome = from Biblioteca in xmlDocument.Descendants("wiride")

                                          select Biblioteca.Element("autore").Element("cognome").Value;


            Libro.LoadList(codice, titolo, cognome);


            XDocument newXmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Creazione di un nuovo file xml"),
                    new XElement("Biblioteca",
                                 from Libro in Libro.GetAllBooks()
                                 select new XElement("Libro", new XElement("Codice", Libro.CodiceScheda),
                                        new XElement("Titolo", Libro.Titolo),
                                        new XElement("Autore", Libro.Cognome))));


            newXmlDocument.Save(@"..\..\libriShort.xml");

            



        } 

        private void btn_Sostituisci_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txt_searchTitolo.Text;
            string genere = txt_newGenere.Text;

            titolo.Trim();
            genere.Trim();
            if (genere == "" || titolo == "")
                MessageBox.Show("Inserire parametri adeguati");
            else
                xmlDocument.Element("Biblioteca").Elements("wiride").Where(x => x.Attribute("titolo").Value == titolo).FirstOrDefault().SetElementValue("genere", genere);
        }
    }
}

