using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Text;


namespace Projekt_Sudoku
{
    class Gra
    {
        public static Menu menu;
        public static DataGridView plansza = new DataGridView();
        public static Logika logika;
        public static Generator generator = new Generator();
        private static byte maxWartosc = 9;
        public static Buffor.ZAPIS DebugMode = Buffor.ZAPIS.DO_BUFORU_I_PLANSZY;
        
        private static void Grid_Paint(object sender, PaintEventArgs e)
        {
            Point linia1_A = new Point(plansza.Location.X - Menu.offX, (int)(plansza.Location.Y - Menu.offY  + (plansza.Height * 0.33)));
            Point linia1_B = new Point(plansza.Location.X - Menu.offX + plansza.Width, (int)(plansza.Location.Y - Menu.offY + (plansza.Height * 0.33)));

            Point linia2_A = new Point(plansza.Location.X - Menu.offX, (int)(plansza.Location.Y - Menu.offY + (plansza.Height * 0.66)));
            Point linia2_B = new Point(plansza.Location.X - Menu.offX + plansza.Width, (int)(plansza.Location.Y - Menu.offY + (plansza.Height * 0.66)));

            Point linia3_A = new Point((int)(plansza.Location.X - Menu.offX + (plansza.Width * 0.33)), plansza.Location.Y - Menu.offY);
            Point linia3_B = new Point((int)(plansza.Location.X - Menu.offX + (plansza.Width * 0.33)), (int)(plansza.Location.Y - Menu.offY + plansza.Height));


            Point linia4_A = new Point((int)(plansza.Location.X - Menu.offX + (plansza.Width * 0.66)), plansza.Location.Y - Menu.offY);
            Point linia4_B = new Point((int)(plansza.Location.X - Menu.offX + (plansza.Width * 0.66)), (int)(plansza.Location.Y - Menu.offY + plansza.Height));

            e.Graphics.DrawLine(new Pen(Color.Black, 3), linia1_A, linia1_B);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), linia2_A, linia2_B);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), linia3_A, linia3_B);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), linia4_A, linia4_B);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4), new Rectangle(plansza.Location.X - Menu.offX,
                plansza.Location.Y - Menu.offY, plansza.Size.Width - 3, plansza.Size.Height - 3));
        }

        private static void Generuj_Click(object sender, EventArgs e)
        {
            generator.Generuj();
        }

        static Gra()
        {
            logika = new Logika();
            //logika.GenerujPlansze();
            plansza.ColumnCount = 9;
            plansza.RowCount = 9;
            plansza.ColumnHeadersVisible = false;
            plansza.RowHeadersVisible = false;
            plansza.Visible = false;
            plansza.BorderStyle = BorderStyle.None;
            plansza.MultiSelect = false;
            plansza.SelectionMode = DataGridViewSelectionMode.CellSelect;
            plansza.EditMode = DataGridViewEditMode.EditProgrammatically;
            plansza.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            plansza.DefaultCellStyle.BackColor = Color.Gray;
            plansza.DefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold);
            plansza.Paint += new PaintEventHandler(Grid_Paint);
            Menu.generuj.Click += new EventHandler(Generuj_Click);
            Menu.zapisz.Click += Zapisz_Click;
            Menu.klawiszologia.Click += Klawiszologia_Click;
        }

        private static void Klawiszologia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("M- wyjście do menu głównego \nH- podpowiedź \nSpacja- czyszczenie komórki");
        }

        private static void Zapisz_Click(object sender, EventArgs e)
        {
            ZapiszPlansze(new StreamWriter("zap.txt"),
                    new StreamWriter("flagi.txt"), new StreamWriter("pt.txt"));
            Menu.zapisz.Enabled = false;
        }

        public static void ZapiszPlansze(StreamWriter swZapis, StreamWriter swFlagi, StreamWriter swPT)
        {
            for (int i = 0; i < maxWartosc; i++)
            {
                for (int j = 0; j < maxWartosc; j++)
                {
                    if (j.Equals(maxWartosc - 1))
                    {
                        /*
                         * Zapisywane są w tym miejscu wartości liczbowe ze wszsytkich
                         * komórek pola do pliku tekstowego 
                         * */
                        try
                        {
                            swZapis.WriteLine(plansza[j, i].Value.ToString());
                        }
                        catch (NullReferenceException)
                        {
                            swZapis.WriteLine("N");
                        }
                        /*
                         * Oprócz tego, do pliku zapisywane są dla każdej komórki 
                         * tzw. flagi, za pomocą których będzie można 
                         * określić, czy daną komórkę będzie można modyfikować 
                         * czy też nie. 
                         * Flagi:
                         * S- wartość stała- nie można modyfikować
                         * Z- wartość zmienna- można modyfikować
                         * */
                        if (!plansza[j, i].ReadOnly) swFlagi.WriteLine("Z");
                        else swFlagi.WriteLine("S");
                    }
                    else
                    {
                        /* Analogicznie jak wyżej tylko z przecinkami */
                        try
                        {
                            swZapis.Write(plansza[j, i].Value.ToString() + ",");
                        }
                        catch (NullReferenceException)
                        {
                            swZapis.Write("N,");
                        }

                        if (!plansza[j, i].ReadOnly) swFlagi.Write("Z,");
                        else swFlagi.Write("S,");
                    }
                }
            }
            swZapis.Close();
            swFlagi.Close();
            swPT.WriteLine(Logika.poziomTrudnosci.ToString()); //zapisuje poziom trudności bieżącej rozgrywki
            swPT.Close();
        }
        public static void OdczytajPlansze(StreamReader srZap, StreamReader srFlag, StreamReader srPT)
        {
            string[] wiersz = new string[maxWartosc];
            string[] wierszFlag = new string[maxWartosc];
            char[] separatory = { ',' };
            /*
             * Z pliku odczytywane są wszystkie wiesze po kolei
             * Analogicznie w przypadku pliku z flagami
             * */
            for (int i = 0; i < wiersz.Length; i++)
            {
                wiersz[i] = srZap.ReadLine();
                wierszFlag[i] = srFlag.ReadLine();
            }
            srZap.Close();
            srFlag.Close();
            logika.UstawPoziomTrudnosci(srPT.ReadLine());
            srPT.Close();
            string[][] poleOdcz = new string[maxWartosc][];
            string[][] flagi = new string[maxWartosc][];
            for (int i = 0; i < wiersz.Length; i++)
            {
                /*
                 * Następnie odczytane wiersze dzieli się na części 
                 * elementarne (wartości liczbowe i flagi). W efekcie powstaje
                 * zagnieżdżona tablica, w której indeks zewnętrzny reprezentuje 
                 * wiersz, a wewnętrzny element tego wiersza. Analogicznie w przypadku
                 * flag.
                 * */
                poleOdcz[i] = wiersz[i].Split(separatory, StringSplitOptions.RemoveEmptyEntries);
                flagi[i] = wierszFlag[i].Split(separatory, StringSplitOptions.RemoveEmptyEntries);
            }
            for (int i = 0; i < maxWartosc; i++)
            {
                for (int j = 0; j < maxWartosc; j++)
                {
                    /* Wpisywanie odczytanych wartości do zmiennych */
                    if (poleOdcz[i][j].Equals("N")) logika.getBuffor()[j, i,DebugMode] = 0;
                    else logika.getBuffor()[j, i,DebugMode] = Byte.Parse(poleOdcz[i][j]);
                    if (flagi[i][j].Equals("S")) plansza[j, i].ReadOnly = true;
                    else plansza[j, i].ReadOnly = false;
                }
            }
        }

        public static void K_ZaladujPlansze()
        {
            string[] Rows = new string[maxWartosc];
            string[] Flagi = new string[maxWartosc];
            using (StreamReader srZap = new StreamReader("zap.txt"))
            {
                uint i = 0;
                do Rows[i++] = srZap.ReadLine();
                while (!srZap.EndOfStream);
                srZap.Close();
            }

            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    if (Rows[i][j].Equals('N')) plansza[j, i].Value = null;
                    else plansza[j, i].Value = Rows[i][j];
                }
            }

            using (StreamReader srFlag = new StreamReader("flagi.txt"))
            {
                uint i = 0;
                do Flagi[i++] = srFlag.ReadLine();
                while (!srFlag.EndOfStream);
                srFlag.Close();
            }

            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    if (Flagi[i][j].Equals('Z')) plansza[j,i].ReadOnly = false;
                    else plansza[j,i].ReadOnly = true;
                }
            }
        }
        public static void K_ZapiszPlansze()
        {
            using (StreamWriter swZap = new StreamWriter("zap.txt", false))
            {
                for (int i = 0; i < maxWartosc; i++)
                {
                    for (int j = 0; j < maxWartosc; j++)
                    {
                        try
                        {
                            if (j.Equals(maxWartosc - 1))
                                swZap.WriteLine(plansza[j, i].Value.ToString());
                            else swZap.Write(plansza[j, i].Value.ToString());
                        }
                        catch (NullReferenceException)
                        {
                            if (j.Equals(maxWartosc - 1)) swZap.WriteLine('N');
                            else swZap.Write('N');
                        }
                    }
                }
                swZap.Close();
            }
            using (StreamWriter swFlag = new StreamWriter("flagi.txt", false))
            {
                for (int i = 0; i < maxWartosc; i++)
                {
                    for (int j = 0; j < maxWartosc; j++)
                    {
                        if (j.Equals(maxWartosc - 1))
                        {
                            if (plansza[j,i].ReadOnly) swFlag.WriteLine('S');
                            else swFlag.WriteLine('Z');
                        }
                        else
                        {
                            if (plansza[j,i].ReadOnly) swFlag.Write('S');
                            else swFlag.Write('Z');
                        }
                    }
                }
                swFlag.Close();
            }
        }
        
    }
}
