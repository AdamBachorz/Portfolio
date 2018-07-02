using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace Projekt_Sudoku
{
    class Generator
    {
        private static Form1 okno;
        private static PrintDocument dokumentDoDruku = new PrintDocument();
        private static Bitmap bmp;
        public static void Deleguj(Form1 okno)
        {
            Generator.okno = okno;
        }
        public Generator()
        {
            dokumentDoDruku.PrintPage += new PrintPageEventHandler(dokumentDoDruku_PP);
        }
        private static void dokumentDoDruku_PP(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Gra.plansza.Location.X, Gra.plansza.Location.Y);
        }
        
        private void zrzut()
        {
            okno.Show();
            //Gra.plansza.DefaultCellStyle.BackColor = Color.White;
            Graphics graph = okno.CreateGraphics();
            bmp = new Bitmap(Gra.plansza.Width+40,Gra.plansza.Height+10);
            graph = Graphics.FromImage(bmp);
            graph.CopyFromScreen(okno.Location.X+14, okno.Location.Y+30, Gra.plansza.Location.X, Gra.plansza.Location.Y, bmp.Size); //pstryk
        }

        public void Generuj()
        {
            zrzut();
            PrintDialog di = new PrintDialog();
            di.Document = dokumentDoDruku;
            if (di.ShowDialog().Equals(DialogResult.OK))
            {
                dokumentDoDruku.DefaultPageSettings.Landscape = false;
                dokumentDoDruku.Print();
            }
        }
    }
}
