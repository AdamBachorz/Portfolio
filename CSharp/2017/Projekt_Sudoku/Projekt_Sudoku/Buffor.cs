using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Projekt_Sudoku
{
    class Buffor //klasa pomocnicza do wstawiania liczb do datagridu i bufforu
    {
        public enum ZAPIS { DO_BUFORU, DO_BUFORU_I_PLANSZY };
        private byte[,] Pamiec_Podreczna = new byte[9, 9]; //buffor do obliczeń dla alg. bruteforce
        public byte[,,] Liczby_w_Kwadratach = new byte[3, 3, 9]; 
        /*  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
         *  tab. zawierająca ilość wystąpień liczb 1-9 w każdym z kwadratów
         *  2 pierwsze wymiary opisują współrzędne dużego kawdrata
         *  index ostatniego wymiaru reprezentuje liczbę w kwadracie zmniejszoną o 1
        */ 
        
        //zwraca komórki w wierszu w którch liczby się powtórzyły
        public void PobierzZleKomorkiWWierszach(ref List<Point> zleKomorki)
        {
            for (byte i = 0; i < 9; ++i) //wiersze
            {
                List<Point>[] licznikWystapieniaLiczb = new List<Point>[9];
                for (byte n = 0; n < licznikWystapieniaLiczb.Length; ++n)
                    licznikWystapieniaLiczb[n] = new List<Point>();

                for (byte j = 0; j < 9; ++j) //komórki
                {
                    if (this[j, i] != 0)
                        // jeżeli wartość komórki jest różna od 0, to znaczy, że jest w niej jakaś liczba 
                        licznikWystapieniaLiczb[this[j, i] - 1].Add(new Point(j, i));
                }
                foreach (var liczba in licznikWystapieniaLiczb)
                {
                    if (liczba.Count > 1) // jeżeli dana liczba występuje więcej niż 1 raz, to ta liczba powtarza się 
                    {
                        foreach (var numerKomorki in liczba)
                            zleKomorki.Add(numerKomorki);
                    }
                }
            }
        }
        public void getZleKomorkiWKolumnach(ref List<Point> zleKomorki)
        {
            for (byte i = 0; i < 9; ++i)        //wiersze
            {
                List<Point>[] licznikWystapienLiczb = new List<Point>[9];
                for (byte n = 0; n < licznikWystapienLiczb.Length; ++n)
                    licznikWystapienLiczb[n] = new List<Point>();
                for (byte j = 0; j < 9; ++j) //komórki
                {
                    if (this[i, j] != 0)
                        licznikWystapienLiczb[this[i, j] - 1].Add(new Point(i, j));
                }
                foreach (var liczba in licznikWystapienLiczb)
                {
                    if (liczba.Count > 1)
                    {
                        foreach (var numerKomorki in liczba)
                            zleKomorki.Add(numerKomorki);
                    }
                }
            }
        }
        public Point[] ZliczPusteKomorki()
        {
            List<Point> PusteKomorki = new List<Point>();
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                    if (Pamiec_Podreczna[j, i] == 0) PusteKomorki.Add(new Point(j, i));
            }
            return PusteKomorki.ToArray();
        }
        public List<byte> PobierzLiczby_w_Kwadracie(int Indeks_Kolumna, int Index_Wiersz) //arg. to indeksy komórki(wiersz, kolumna)
        {
            List<byte> ziarnaWKwadracie = new List<byte>();
            Indeks_Kolumna /= 3; Index_Wiersz /= 3; // przejście index'u planszy w index kwadracika
            //jezeli liczba jeszcze nie wystapila w kwadracie to dodajemy ją do mozliwych do rozpatrzenia
            for (byte i = 0; i < 9; ++i) // 'i' oznacza liczbę, która może być w komórce
                if (Liczby_w_Kwadratach[Indeks_Kolumna, Index_Wiersz, i] == 0) ziarnaWKwadracie.Add(i);
            return ziarnaWKwadracie;
        }
        public byte[] PobierzLiczby_w_Kolumnie(int INDEX_KOLUMNA)
        {
            //zliczamy ile dokładnie razy wystąpiła dana liczba w kolumnie
            byte[] Liczby_w_Kolumnie = new byte[9];
            for (byte y = 0; y < 9; ++y) // 'y' reprezentuje możliwą liczbę do wpisania zmniejszoną o 1
            {
                byte wartoscKomorki = Pamiec_Podreczna[INDEX_KOLUMNA, y];
                if (wartoscKomorki != 0)  //zliczamy tylko niepuste komorki w kolumnie
                    //zwiększamy liczbę wystąpień liczby (pod zmienną 'wartoscKomorki')
                    ++Liczby_w_Kolumnie[--wartoscKomorki];
            }
            return Liczby_w_Kolumnie;
        }
        public byte[] PobierzLiczby_w_Wierszu(int INDEX_WIERSZ)
        {
            //zliczamy ile dokładnie razy wystąpiła dana liczba w wierszu
            byte[] Liczby_w_Wierszu = new byte[9];
            for (byte x = 0; x < 9; ++x)
            {
                byte wartoscKomorki = Pamiec_Podreczna[x, INDEX_WIERSZ];
                if (wartoscKomorki != 0)
                    ++Liczby_w_Wierszu[--wartoscKomorki]; //zliczmy tylko niepuste komorki w kolumnie 
            }
            return Liczby_w_Wierszu;
        }
        private void getZleKomorkiWKwadracie(int X, int Y, ref List<Point> zleKomorki) //zwraca komórki w kwadratach w których liczby się powtórzyły
        {
            // 'X' i 'Y' reprezentują index'y dużych kwardatów
            List<byte> liczbyPowtorzone = new List<byte>();
            for (byte i = 0; i < 9; ++i)
                if (Liczby_w_Kwadratach[X, Y, i] > 1) liczbyPowtorzone.Add((byte)(i + 1));
            //jeżeli jakaś cyfra się powtórzyłą w kw. więcej niż raz to dodaj ją do listy 'powtórzonych liczb'
            Y *= 3; X *= 3; //przeliczamy na indeksy konkretnych komórek
            //przelatujemy przez cały kwadrat
            for (int y = Y; y < Y + 3; ++y) // wiersze
            {
                for (int x = X; x < X + 3; ++x) // kolumny
                {
                    foreach (byte liczbaPowtorzona in liczbyPowtorzone)
                    //jeżeli liczba w komórce jest równa  l. która się powtarza to dodaj jej współrzędne  do listy BadCells
                    {
                        if (this[x, y] == liczbaPowtorzona) zleKomorki.Add(new Point(x, y));
                        break;
                    }
                }
            }
        }
        public void getZleKomorkiWKwadratach(ref List<Point> zleKomorki)
        {
            //przelatujemy przez wszytkie kwadraty w planszy
            for (byte Y = 0; Y < 3; ++Y)
            {
                for (byte X = 0; X < 3; ++X)
                    getZleKomorkiWKwadracie(X, Y, ref zleKomorki);
            }
        }
        public byte this[int kolumna, int wiersz, ZAPIS typZapisu = ZAPIS.DO_BUFORU] //przeciążony operator indeksowania
        {
            set
            {
                if (value == 0) //zerowanie komórki
                {
                    //gdy komórka którą chcemy wymazać zawiera liczbę, wtedy zmniejszamy jej iterator w konkretnym kwadracie
                    if (Pamiec_Podreczna[kolumna, wiersz] != 0)
                        // jeżeli chcemy zerować daną komórkę, to ilość wystąpień liczby wcześniejszej musimy zdekrementować
                        --Liczby_w_Kwadratach[kolumna / 3, wiersz / 3, --Pamiec_Podreczna[kolumna, wiersz]];
                    if (typZapisu == ZAPIS.DO_BUFORU_I_PLANSZY)
                    {
                        Gra.plansza[kolumna, wiersz].Value = null;
                        Gra.plansza[kolumna, wiersz].Style.BackColor = SystemColors.WindowFrame;
                    }
                }
                else //gdy chcemy zapisać wart. do komórki
                {
                    //gdy nadpisujemy komórkę która zawiera już liczbę wtedy zmniejszamy iterator l. która już się znajduje w komórce 
                    if (Pamiec_Podreczna[kolumna, wiersz] != 0)
                        // jeżeli chcemy nadpisać daną komórkę, to ilość wystąpień liczby wcześniejszej musimy zdekrementować
                        --Liczby_w_Kwadratach[kolumna / 3, wiersz / 3, --Pamiec_Podreczna[kolumna, wiersz]]; 
                    //zwiększamy iterator liczby w kw. którą chcemy zapisać
                    ++Liczby_w_Kwadratach[kolumna / 3, wiersz / 3, value - 1]; //ilość wystąpień nowej wartości musimy zinkrementować
                    if (typZapisu == ZAPIS.DO_BUFORU_I_PLANSZY)
                    {
                        Gra.plansza[kolumna, wiersz].Value = value;
                        Gra.logika.UstawKolorKomorki(value, kolumna, wiersz);
                        if (!Gra.plansza[kolumna, wiersz].ReadOnly)
                            Gra.plansza[kolumna, wiersz].Style.BackColor = Color.BurlyWood;
                    }
                }
                Pamiec_Podreczna[kolumna, wiersz] = value;
            }
            get
            {
                return Pamiec_Podreczna[kolumna, wiersz];
            }
        }
        public void KopiujDoPlanszy()
        {
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    if (this[j, i] != 0)
                    {
                        Gra.plansza[j, i].Value = this[j, i];
                        Gra.logika.UstawKolorKomorki(this[j, i], j, i);
                    }
                }
            }
        }
        public void Wyczysc()
        {
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                    this[j, i, ZAPIS.DO_BUFORU_I_PLANSZY] = 0;
            }
        }
    }
}
