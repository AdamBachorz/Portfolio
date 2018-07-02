using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace Projekt_Sudoku
{
    class Logika
    {
        private Queue<List<Point>> KolejkaZlychKomorek = new Queue<List<Point>>();
        public enum POZIOM_TRUDNOSCI { Latwy, Sredni, Trudny }
        public static POZIOM_TRUDNOSCI poziomTrudnosci = new POZIOM_TRUDNOSCI();
        private uint LicznikWywolan = 0, maksymalnaLiczbaWywolan; 
        private System.Windows.Forms.Timer mojTimer = new System.Windows.Forms.Timer();
        private Buffor buffor = new Buffor();
        public Buffor getBuffor() { return buffor; } 
        private Random rand = new Random();

        private double WspolczynnikPoziomuTrudnosci()
        {
           switch (poziomTrudnosci)
            {
                case POZIOM_TRUDNOSCI.Latwy:
                    return 0.1;
                case POZIOM_TRUDNOSCI.Sredni:
                    return 0.5;
                case POZIOM_TRUDNOSCI.Trudny:
                    return 0.8;
                default:
                    return 0.3;
            }
        }
        private void UstawPoziomTrudnosci()
        {
            switch(Menu.poziomyTrudnosci.SelectedIndex)
            {
                case 0:
                    {
                        poziomTrudnosci = POZIOM_TRUDNOSCI.Latwy;
                        break;
                    }
                case 1:
                    {
                        poziomTrudnosci = POZIOM_TRUDNOSCI.Sredni;
                        break;
                    }
                case 2:
                    {
                        poziomTrudnosci = POZIOM_TRUDNOSCI.Trudny;
                        break;
                    }
            }
        }
        public void UstawPoziomTrudnosci(string poziom)
        {
            switch (poziom) //ustawianie poziomu trudności na podstawie odczytu z pliku
            {
                case "Latwy":
                    {
                        poziomTrudnosci = POZIOM_TRUDNOSCI.Latwy;
                        break;
                    }
                case "Sredni":
                    {
                        poziomTrudnosci = POZIOM_TRUDNOSCI.Sredni;
                        break;
                    }
                case "Trudny":
                    {
                        poziomTrudnosci = POZIOM_TRUDNOSCI.Trudny;
                        break;
                    }
            }
        }

        private List<byte> PobierzLiczby(int Kolumn_index, int Wiersz_index)
        {// gromadzenie liczb spełniających zasady sudoku
            List<byte> Liczby_w_Kwadracie = buffor.PobierzLiczby_w_Kwadracie(Kolumn_index, Wiersz_index);
            byte[] Liczby_w_Wierszu = buffor.PobierzLiczby_w_Wierszu(Wiersz_index);
            byte[] Liczby_w_Kolumnie = buffor.PobierzLiczby_w_Kolumnie(Kolumn_index);
            for (byte i = 0; i < 9; ++i) // 'i' reprezentuje możliwą liczbę do wpisania zmniejszoną o 1
                if (Liczby_w_Wierszu[i] != 0 || Liczby_w_Kolumnie[i] != 0) Liczby_w_Kwadracie.Remove(i);
            return Liczby_w_Kwadracie;
        } //można ten alg. nazwać metodą elimnacji
        public void UstawKolorKomorki(byte wartosc, int index_Kolumna, int index_Wiersz)
        {
            switch (wartosc)
            {
                case 1:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.Red; break;
                case 2:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.FromKnownColor(KnownColor.Maroon); break;
                case 3:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.CornflowerBlue; break;
                case 4:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.Turquoise; break;
                case 5:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.Coral; break;
                case 6:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.DarkOrange; break;
                case 7:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.Fuchsia; break;
                case 8:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.MediumSeaGreen; break;
                case 9:
                    Gra.plansza[index_Kolumna, index_Wiersz].Style.ForeColor = Color.Black; break;
            }
        }
        public void UstawKolorKomorki(Point komorka)
        {
            byte wartosc = buffor[komorka.X, komorka.Y];
            UstawKolorKomorki(wartosc, komorka.X, komorka.Y);
        } //procedura.... (no shit)
        public void UstawKolorZlejKomorki(Point komorka)  //procedura do ustawiania koloru tła dla komórek gdzie cyfry się powtarzają
        {
            byte wartosc = buffor[komorka.X, komorka.Y];
            switch (wartosc)
            {
                case 1:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.Red; break;
                case 2:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.FromKnownColor(KnownColor.Maroon); break;
                case 3:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.CornflowerBlue; break;
                case 4:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.Turquoise; break;
                case 5:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.Coral; break;
                case 6:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.DarkOrange; break;
                case 7:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.Fuchsia; break;
                case 8:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.MediumSeaGreen; break;
                case 9:
                    Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.White; break;
            }
            Gra.plansza[komorka.X, komorka.Y].Style.ForeColor = Color.Black;
        }
        private bool RozwiazanieSiloweGeneratorMap(ref Point[] pusteKomorki, byte N) // 'N' to index pustej komórki w danym kroku rekurencyjnym
        {// z listy dostępnych liczb losowana jest liczba i jest wstawiana do komórki i od razu jest usuwana z listy możliwych liczb do wstawienia 
            if (++LicznikWywolan == 1 << 21) throw new Exception(); //jak głeboko szukamy 
            List<byte> nasiona = PobierzLiczby(pusteKomorki[N].X, pusteKomorki[N].Y); //pobiera możliwe liczby do wstawienia
            if (N == pusteKomorki.Length - 1) //warunkiem koniecznym jest EmptyCells.Length - 1 && Seed.Count == 1 ale ten jest wystarczjący
            {
                buffor[pusteKomorki[N].X, pusteKomorki[N].Y, Gra.DebugMode] = ++nasiona[0];
                //MessageBox.Show(LicznikWywolan.ToString());
                return true;
            }
            for (byte i = (byte)nasiona.Count; i != 0; --i)  //wyk. tylko wtedy gdy są  dostępne liczby spełniające zasady sudoku 
            {
                byte nasiono = nasiona[rand.Next(nasiona.Count)]; //pobieramy losowo liczbę możliwą do wstawienia i nast. ją usuwamy z listy(tj.Seeds);
                nasiona.Remove(nasiono);
                buffor[pusteKomorki[N].X, pusteKomorki[N].Y, Gra.DebugMode] = ++nasiono;  //nast. wstawiamy ją do buforu zwiękoszoną o jeden (liczby w liscie są od 0-8)
                if (RozwiazanieSiloweGeneratorMap(ref pusteKomorki, (byte)(N + 1))) return true;
            }
            buffor[pusteKomorki[N].X, pusteKomorki[N].Y, Gra.DebugMode] = 0;
            return false;
        }

        private bool RozwiazanieSiloweWskazowka(ref Point[] pusteKomorki, byte N) // 'N' to index pustej komórki w danym kroku rekurencyjnym
        {
            if (++LicznikWywolan == 1 << 21) throw new Exception(); //jak głeboko szukamy 
            List<byte> nasiona = PobierzLiczby(pusteKomorki[N].X, pusteKomorki[N].Y); //pobiera możliwe liczby do wstawienia
            if (N == pusteKomorki.Length - 1) //warunkiem koniecznym jest EmptyCells.Length - 1 && Seed.Count == 1 ale ten jest wystarczjący
            {
                /*
                 * Jesteśmy w ostaniej pustej komórce, a to oznacza, że została ostatnia liczba do wstawienia
                 * */
                buffor[pusteKomorki[N].X, pusteKomorki[N].Y, Gra.DebugMode] = ++nasiona[0];
                MessageBox.Show(LicznikWywolan.ToString());
                return true;
            }

            foreach (byte nasiono in nasiona)  //wyk. tylko wtedy gdy są  dostępne liczby spełniające zasady sudoku 
            {
                buffor[pusteKomorki[N].X, pusteKomorki[N].Y, Gra.DebugMode] = (byte)(nasiono + 1);
                if (RozwiazanieSiloweWskazowka(ref pusteKomorki, (byte)(N + 1))) return true;
            }

            buffor[pusteKomorki[N].X, pusteKomorki[N].Y, Gra.DebugMode] = 0;
            return false;
        }

        public byte Wskazowka(int Column, int Row)
        {
            List<byte> nasiona = PobierzLiczby(Column, Row);
            if (nasiona.Count == 0) throw new Exception(); //kwadrat jest zapełniony lub nie ma żadnych mozliwości do wstawienia
            Point[] PusteKomorki = buffor.ZliczPusteKomorki();
            LicznikWywolan = 0;
            if (buffor[Column, Row] == 0)
            {
                maksymalnaLiczbaWywolan = 1u << 17; // 2^17
                byte rowiazanie = 0;
                try
                {
                    if (RozwiazanieSiloweWskazowka(ref PusteKomorki, 0))
                        rowiazanie = buffor[Column, Row];
                }
                catch (Exception) { }
                foreach (var komorka in PusteKomorki)
                    buffor[komorka.X, komorka.Y, Buffor.ZAPIS.DO_BUFORU_I_PLANSZY] = 0;
                if (rowiazanie != 0) return rowiazanie;
                else throw new Exception("Nie znaleziono rozwiązania lub nie istnieje!");
            }
            else
            {
                maksymalnaLiczbaWywolan = 1u << 13;
                byte wartosc = buffor[Column, Row];
                bool Solution = false;
                for (int i = nasiona.Count; i != 0; --i)
                {
                    byte nasiono = nasiona[rand.Next(nasiona.Count)];
                    nasiona.Remove(nasiono);
                    buffor[Column, Row] = (byte)(nasiono + 1);
                    try
                    {
                        if (RozwiazanieSiloweWskazowka(ref PusteKomorki, 0)) Solution = true;
                    }
                    catch (Exception) { }
                    foreach (var komorka in PusteKomorki)
                        buffor[komorka.X, komorka.Y] = 0;
                    LicznikWywolan = 0;
                    if (Solution) return buffor[Column, Row];
                }
                buffor[Column, Row, Buffor.ZAPIS.DO_BUFORU] = wartosc;
                throw new Exception();
            }
        }
            public void GenerujPlansze()
            {
                UstawPoziomTrudnosci();
                buffor.Wyczysc();
                Point[] plansza = buffor.ZliczPusteKomorki();
                RozwiazanieSiloweGeneratorMap(ref plansza, 0);
                foreach (Point komorka in plansza)
                {
                    if (rand.NextDouble() < WspolczynnikPoziomuTrudnosci())
                    {
                        buffor[komorka.X, komorka.Y,Buffor.ZAPIS.DO_BUFORU_I_PLANSZY] = 0;
                    }
                    else
                    {
                        Gra.plansza[komorka.X, komorka.Y].ReadOnly = true;
                        Gra.plansza[komorka.X, komorka.Y].Style.BackColor = Color.PeachPuff;
                    }
                }
                buffor.KopiujDoPlanszy();
            }
        private void Plansza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Menu.zapisz.Enabled) Menu.zapisz.Enabled = true;
            List<Point> ZleKomorki = new List<Point>();
            int index_Wiersz = Gra.plansza.SelectedCells[0].RowIndex;
            int index_Kolumna = Gra.plansza.SelectedCells[0].ColumnIndex;
            if (e.KeyChar >= '1' && e.KeyChar <= '9' && !Gra.plansza[index_Kolumna, index_Wiersz].ReadOnly)
                buffor[index_Kolumna, index_Wiersz, Buffor.ZAPIS.DO_BUFORU_I_PLANSZY] = Convert.ToByte(e.KeyChar - 48);
            buffor.PobierzZleKomorkiWWierszach(ref ZleKomorki);
            buffor.getZleKomorkiWKolumnach(ref ZleKomorki);
            buffor.getZleKomorkiWKwadratach(ref ZleKomorki);
            if (ZleKomorki.Count != 0) //jeżeli są liczby które łamią zasady sudoku wtedy je wszytskie podświetlamy
            {
                ZleKomorki.Insert(0, new Point(index_Kolumna, index_Wiersz));
                mojTimer.Interval = 1000;
                mojTimer.Tick += MyTimer_Tick;
                mojTimer.Start(); // złe komórki zostaną podświetlone przez sekundę po czym zgasną
                foreach (var komorka in ZleKomorki)
                    UstawKolorZlejKomorki(komorka);
                KolejkaZlychKomorek.Enqueue(ZleKomorki);
            }
            if (buffor.ZliczPusteKomorki().Length.Equals(0) && KolejkaZlychKomorek.Count.Equals(0) && Gra.DebugMode.Equals(Buffor.ZAPIS.DO_BUFORU)) MessageBox.Show("Koniec gry");
        }
        private void Plansza_KeyDown(object sender, KeyEventArgs e)
        {
            int index_Wiersz = Gra.plansza.SelectedCells[0].RowIndex;
            int index_Kolumna = Gra.plansza.SelectedCells[0].ColumnIndex;
            switch (e.KeyCode)
            {
                case Keys.M:
                    {
                        Menu.rozgrywka = false;
                        Application.Restart();
                    }
                    break;
                case Keys.H:
                    {
                        if (!Menu.zapisz.Enabled) Menu.zapisz.Enabled = true;
                        if (!Gra.plansza[index_Kolumna, index_Wiersz].ReadOnly)
                            {
                                try
                                {
                                    buffor[index_Kolumna, index_Wiersz, Buffor.ZAPIS.DO_BUFORU_I_PLANSZY] = Wskazowka(index_Kolumna, index_Wiersz);
                                }
                                catch (Exception) { }
                            }
                    }
                    break;
                case Keys.Space:
                    {//zerowanie komórki wybranej przez gracza
                        if (!Menu.zapisz.Enabled) Menu.zapisz.Enabled = true;
                        if (!Gra.plansza[index_Kolumna, index_Wiersz].ReadOnly)
                            buffor[index_Kolumna, index_Wiersz, Buffor.ZAPIS.DO_BUFORU_I_PLANSZY] = 0;
                    }
                    break;
            }
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            mojTimer.Stop();
            if (KolejkaZlychKomorek.Count == 0) return;
            List<Point> ZleKomorki = KolejkaZlychKomorek.Dequeue();
            foreach (var komorka in ZleKomorki)
            {
                Gra.plansza[komorka.X, komorka.Y].Style.BackColor = (Gra.plansza[komorka.X, komorka.Y].ReadOnly ? Color.PeachPuff : Color.BurlyWood);
                Gra.logika.UstawKolorKomorki(komorka);
            }
            Thread.Sleep(60);
            if (!Gra.plansza[ZleKomorki[0].X, ZleKomorki[0].Y].ReadOnly)
                buffor[ZleKomorki[0].X, ZleKomorki[0].Y, Buffor.ZAPIS.DO_BUFORU_I_PLANSZY] = 0;
        }
        public Logika()
        {
            Gra.plansza.KeyPress += Plansza_KeyPress;
            Gra.plansza.KeyDown += Plansza_KeyDown;
        }


    }
}
