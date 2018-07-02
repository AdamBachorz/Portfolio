using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Mulitdokumentacja
{
    public partial class Formularz : Form
    {
        Generator generator;
        public static string dlugoscWiersza;
        public Formularz()
        {
            InitializeComponent();
            comboBox_RodzajDokumentu.Items.AddRange(new string[] { "Jakiś tam" });
            generator = new Generator(new Control[] { textBox_Imie, textBox_Nazwisko, textBox_Pesel, textBox_Adres, textBox_KodPocztowy, textBox_Miasto});
        }

        private bool NieWszystkieKontrolkiUzupelnione()
        {
            return textBox_Imie.Text == String.Empty ||
                textBox_Nazwisko.Text == String.Empty ||
                textBox_Pesel.Text == String.Empty ||
                textBox_KodPocztowy.Text == String.Empty ||
                textBox_Miasto.Text == String.Empty ||
                textBox_Adres.Text == String.Empty;
        }

        private void CzyscKontrolki()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_RodzajDokumentu.SelectedIndex >= 0)
            {
                if (NieWszystkieKontrolkiUzupelnione())
                {
                    var komunikat = MessageBox.Show("Część pól nie została uzupełniona. Czy chcesz kontynuowac mimo to ?", "Komunikat", MessageBoxButtons.YesNo);
                    if (komunikat.Equals(DialogResult.Yes)) generator.Generuj();
                    else return;
                }
                else generator.Generuj();
            }
            else MessageBox.Show("Nie wybrano rodzaju dokumentu !");
        }

        private void comboBox_RodzajDokumentu_SelectedIndexChanged(object sender, EventArgs e)
        {
            generator.PrzydzielRodzaj(comboBox_RodzajDokumentu.SelectedText);
        }

        private void button_Czysc_Click(object sender, EventArgs e)
        {
            var komunikat = MessageBox.Show("Czy na pewno chcesz wyczyścić wszystkie wpisane dane ?", "Komunikat", MessageBoxButtons.YesNo);
            if (komunikat.Equals(DialogResult.Yes))
            {
                textBox_Imie.Text = textBox_Nazwisko.Text = textBox_Pesel.Text = textBox_KodPocztowy.Text = textBox_Miasto.Text = textBox_Adres.Text = String.Empty;
            }
            else return;
        }
    }
}
