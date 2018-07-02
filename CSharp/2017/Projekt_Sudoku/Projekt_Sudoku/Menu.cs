using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Projekt_Sudoku
{
    class Menu
    {
        public Button nowaGra = new Button();
        public static bool rozgrywka = false;
        public Button kontynuacja = new Button();
        public Button kreator = new Button();
        public Button autorzy = new Button();
        public Button wyjscie = new Button();
        Label PT = new Label();
        Label sudoku = new Label();
        public CheckBox autozapis = new CheckBox();
        public CheckBox muzyka = new CheckBox();
        public static ComboBox poziomyTrudnosci = new ComboBox();
        public static Button generuj = new Button();
        public static Button zapisz = new Button();
        public static Button klawiszologia = new Button();
        private Control.ControlCollection RefControl;
        private static Rectangle RefClientSize;
        List<Control> opcjeMenu = new List<Control>();
        List<Control> opcjeRozgrywki= new List<Control>();
        enum Operacja { Wlacz,Wylacz}

        private void Akcja(List<Control> kontrolki, Operacja operacja)
        {
            try
            {
                switch (operacja)
                {
                    case Operacja.Wlacz:
                        {
                            for (int i = 0; i < kontrolki.Count; i++) kontrolki[i].Visible = true;
                            break;
                        }
                    case Operacja.Wylacz:
                        {
                            for (int i = 0; i < kontrolki.Count; i++) kontrolki[i].Visible = false;
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception) { }
        }
        public static Rectangle getRefClientSize() { return RefClientSize; }

        private void PokazPlansze()
        {
            Akcja(opcjeRozgrywki, Operacja.Wlacz);
            Akcja(opcjeMenu, Operacja.Wylacz);
        }
        private void NowaGra_Click(object sender, EventArgs e)
        {
            if (poziomyTrudnosci.SelectedIndex > -1)
            {
                Gra.logika.GenerujPlansze();
                rozgrywka = true;
                PokazPlansze(); 
            }
            else MessageBox.Show("Nie wybrano poziomu trudności");
        }
        private void Kontynuacja_Click(object sender, EventArgs e)
        {
            try
            {
                Gra.OdczytajPlansze(new StreamReader("zap.txt"),
                        new StreamReader("flagi.txt"), new StreamReader("pt.txt"));
                PokazPlansze();
            }
            catch (Exception)
            {
                MessageBox.Show("Struktura pliku z danymi została uszkodzona.\n Należy przywrócić dane z plików do poprzedniego stanu lub uruchomić nową grę ");
                return;
            }
        }
        private void UstawPrzyciski()
        {
            opcjeMenu.AddRange(new Control[] { nowaGra, kontynuacja, autozapis, muzyka, poziomyTrudnosci, PT, sudoku, autorzy, wyjscie });
            opcjeRozgrywki.AddRange(new Control[] { Gra.plansza, generuj, zapisz, klawiszologia });
            poziomyTrudnosci.Items.AddRange(new string[] { "Łatwy","Średni","Trudny" });

            nowaGra.Size = new Size()
            {
                Width = Convert.ToInt32(RefClientSize.Width * 0.3),
                Height = Convert.ToInt32(RefClientSize.Height * 0.15)
            };
            nowaGra.Location = new Point()
            {
                X = (RefClientSize.Width - nowaGra.Width) / 2 - 3,
                Y = Convert.ToInt32(RefClientSize.Height * 0.2) - 3
            };

            kontynuacja.Size = new Size(nowaGra.Width, 35);
            kontynuacja.Location = new Point()
            {
                X = nowaGra.Location.X,
                Y = 10 + nowaGra.Location.Y + nowaGra.Height - 3
            };

            generuj.Size = new Size(100, 50);
            generuj.Location = new Point(30, Gra.plansza.Height + 470);
            zapisz.Size = generuj.Size;
            zapisz.Location = new Point(generuj.Location.X+105, generuj.Location.Y);
            klawiszologia.Size = new Size(100, 25);
            klawiszologia.Location = new Point(RefClientSize.Size.Width - klawiszologia.Width - 15, RefClientSize.Size.Height - 50);

            autozapis.Size = new Size(73,25);
            autozapis.Location = new Point(kontynuacja.Location.X+60, kontynuacja.Location.Y + 50);

            muzyka.Size = autozapis.Size;
            muzyka.Location = new Point(autozapis.Location.X , autozapis.Location.Y + 30);

            poziomyTrudnosci.Size = new Size(90, 25);
            poziomyTrudnosci.Location = new Point(autozapis.Location.X-12, autozapis.Location.Y+80);

            PT.Text = "Poziom trudności";
            PT.Size = poziomyTrudnosci.Size;
            PT.Location = new Point(muzyka.Location.X-10, muzyka.Location.Y + 35);
            sudoku.Text= "Sudoku";
            sudoku.Size = new Size(350, 110);
            sudoku.Font = new Font(new FontFamily("Forte"), 60, FontStyle.Bold);
            sudoku.Location = new Point(nowaGra.Location.X - 50, 25);

            autorzy.Size = wyjscie.Size =kontynuacja.Size;
            autorzy.Location = new Point(kontynuacja.Location.X, poziomyTrudnosci.Location.Y + 45);
            wyjscie.Location = new Point(autorzy.Location.X, autorzy.Location.Y + autorzy.Height + 2);

        }

        public static int offX = 20, offY = 5;
        public Menu(Rectangle ClientSize, Control.ControlCollection ObjControl)
        {
            RefControl = ObjControl;
            RefClientSize = ClientSize;
            RefControl.Add(Gra.plansza);
            nowaGra.Text = "Nowa Gra";
            kontynuacja.Text = "Kontynuuj";
            generuj.Text = "Generuj do PDF'a";
            autozapis.Text = "Autozapis";
            muzyka.Text = "Muzyka";
            autorzy.Text = "Autorzy";
            wyjscie.Text = "Wyjscie";
            zapisz.Text = "Zapisz stan gry";
            klawiszologia.Text = "Klawiszologia";
            
            UstawPrzyciski();
            
            Gra.plansza.Location = new Point(offX,offY);
            Gra.plansza.Size = new Size(600,600);
            for (int i = 0; i < 9; ++i)
                Gra.plansza.Rows[i].Height = Gra.plansza.Columns[i].Width 
                    = Gra.plansza.Width / 9;
            Gra.plansza.AllowUserToResizeColumns = false;
            Gra.plansza.AllowUserToResizeRows = false;
            ObjControl.AddRange(new Control[] { nowaGra, kontynuacja, generuj, autozapis, muzyka, poziomyTrudnosci, PT, sudoku, autorzy, wyjscie, zapisz, klawiszologia});
            nowaGra.Click += new EventHandler(NowaGra_Click);
            kontynuacja.Click += new EventHandler(Kontynuacja_Click);
            poziomyTrudnosci.SelectedIndex = 0;
            autorzy.Click += Autorzy_Click;
            wyjscie.Click += Wyjscie_Click;
            muzyka.CheckedChanged += Muzyka_CheckedChanged;

            Akcja(opcjeRozgrywki, Operacja.Wylacz);
            Akcja(opcjeMenu, Operacja.Wlacz);
        }

        private void Muzyka_CheckedChanged(object sender, EventArgs e)
        {
            if (muzyka.Checked) Muzyka.MenuStart();
            else Muzyka.MenuStop();
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Autorzy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    Implementacja i algorytmy:\n\tKamil Szulc\n\tAdam Bachorz\n\n\tMuzyka:\n               Łukasz Wnęk");
        }
    }
}
