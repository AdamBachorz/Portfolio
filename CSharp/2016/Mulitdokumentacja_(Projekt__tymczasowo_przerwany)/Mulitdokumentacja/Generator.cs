using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Mulitdokumentacja
{
    class Generator
    {
       private TextBox imie, nazwisko, PESEL, kodPocztowy, miasto, adres;
        private RodzajDokumentu rodzajDokumentu = new RodzajDokumentu();

        public void PrzydzielRodzaj(string rodzaj)
        {
            switch (rodzaj)
            {
                case "JakiśTam":
                    rodzajDokumentu = RodzajDokumentu.JakisTam;
                    break;
                default:
                    break;
            }
        }
       public Generator(Control[] kontrolki)
        {
            imie = (TextBox)kontrolki[0];
            nazwisko = (TextBox)kontrolki[1];
            PESEL = (TextBox)kontrolki[2];
            adres = (TextBox)kontrolki[3];
            kodPocztowy = (TextBox)kontrolki[4];
            miasto = (TextBox)kontrolki[5];
        }

        
        private Font czcionka(byte rozmiar, byte rodzaj)
        {
            return new Font(BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED), rozmiar, rodzaj);
        }

        private string Offset(byte dlugosc)
        {
            string offset = String.Empty;
            for (byte i = 0; i < dlugosc; i++) offset += " ";
            return offset;
        }

        private List<Paragraph> Raport (RodzajDokumentu rd)
        {
            List<Paragraph> raport = new List<Paragraph>();
            const byte maxDlugoscWiersza = 184;
            //byte offset;
            switch (rd)
            {
                case RodzajDokumentu.JakisTam:
                    raport.Add(new Paragraph(".........................................................................................." + Offset(73) + "Września, " + DateTime.Now.ToString("dd.MM.yyyy") + "r."
                        , czcionka(10,0)));

                    raport.Add(new Paragraph("    (pieczątka jednostki prowadzącej konsultację psychologiczną)" + Offset(132) + "(miejscowość, data)"
                        , czcionka(7,0)));
                    raport.Add(new Paragraph("\n\n\n"));

                    raport.Add(new Paragraph(Offset(44) + "W wyniku przeprowadzonej konsultacji psychologicznej"
                        , czcionka(12, 1)));
                    raport.Add(new Paragraph("\n\n\n"));

                    raport.Add(new Paragraph("Pana / Pani " + Offset((byte)((maxDlugoscWiersza - 12 - imie.Text.Length + nazwisko.Text.Length) / 2)) + imie.Text + " " + nazwisko.Text
                        , czcionka(10, 0)));

                    raport.Add(new Paragraph(Offset((byte)((maxDlugoscWiersza - imie.Text.Length + nazwisko.Text.Length - 18 + 5) * 0.9)) + " (imię i nazwisko)" 
                        , czcionka(7, 0))); // 18- dlugość końcówki; 5- offset              // DO SPRAWDZENIA   

                    raport.Add(new Paragraph("numer PESEL (w przypadku osoby nieposiadającej numeru PESEL podać nazwę i numer dokumentu", czcionka(10, 0)));
                    raport.Add(new Paragraph("potwierdzającego tożsamość)" + Offset(36) + PESEL.Text
                        , czcionka(10, 0)));

                    raport.Add(new Paragraph("zam." + Offset((byte)((maxDlugoscWiersza - 5 - kodPocztowy.Text.Length + miasto.Text.Length + adres.Text.Length - 20) / 2)) 
                        + kodPocztowy.Text + " " + miasto.Text + ", " + adres.Text
                        , czcionka(10, 0))); //20- offset

                    raport.Add(new Paragraph(Offset((byte)(maxDlugoscWiersza - 5 - kodPocztowy.Text.Length + miasto.Text.Length + adres.Text.Length - 45 - 15)) 
                        + " (miejscowość, ulica, nr domu, nr mieszkania)"
                        , czcionka(7, 0))); //45- dlugość poniższego znaku; 15- offset
                    raport.Add(new Paragraph("\n\n"));

                    raport.Add(new Paragraph("stwierdzam       BRAK PRZECIWWSKAZAŃ PSYCHOLOGICZNYCH DO WYKONYWANIA PRACY NA STANOWISKU OPERATORA SUWNICY."
                        , czcionka(10, 0)));
                    raport.Add(new Paragraph("\n\n\n"));

                    raport.Add(new Paragraph("UWAGI:         ZACHOWAĆ SZCZEGÓLNĄ OSTROŻNOŚĆ PODCZAS WYKONYWANIA PRACY W WARUNKACH PRESJI CZASOWEJ.", czcionka(10, 0)));
                    raport.Add(new Paragraph("\n\n"));

                    raport.Add(new Paragraph("Termin następnego badania:   wg wskazań lekarza medycyny pracy."
                        , czcionka(9, 0)));
                    raport.Add(new Paragraph("\n\n\n\n\n"));

                    raport.Add(new Paragraph("...................................................................." + Offset(70) + "......................................................."
                        , czcionka(10, 0)));

                    raport.Add(new Paragraph("    (pieczątka osoby skierowanej na konsultację)" + Offset(132) + "(podpis i pieczątka psychologa)"
                        , czcionka(7, 0)));

                    break;
                default:
                    break;
            }
            return raport; 
        }

       public void Generuj()
        {
            try
            {
                SaveFileDialog svd = new SaveFileDialog(); string sciezka;
                if (svd.ShowDialog() == DialogResult.OK) sciezka = svd.FileName;
                else
                {
                    MessageBox.Show("Nie wskazano lokalizacji");
                    return;
                }

                Document doc = new Document(PageSize.A4, 15, 15, 45, 0);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sciezka + ".pdf", FileMode.Create));
                doc.Open();
                List<Paragraph> zawartosc = Raport(RodzajDokumentu.JakisTam);
                for (int i = 0; i < zawartosc.Count; i++) doc.Add(zawartosc[i]); 
                doc.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            MessageBox.Show("Generowanie dokumentu zakończone sukcesem");
        }
    }
}
