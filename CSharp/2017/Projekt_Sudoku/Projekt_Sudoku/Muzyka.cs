using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
namespace Projekt_Sudoku
{
    class Muzyka
    {
        private static WindowsMediaPlayer menu = new WindowsMediaPlayer();
        private static WindowsMediaPlayer latwy = new WindowsMediaPlayer();
        private static WindowsMediaPlayer sredni = new WindowsMediaPlayer();
        private static WindowsMediaPlayer trudny = new WindowsMediaPlayer();
        public static void MenuStart()
        {
            menu.URL = "Morning_rest.mp3";
            menu.settings.playCount = 30;
            menu.controls.play();
        }
        public static void MenuStop()
        {
            menu.controls.stop();
        }

        public static void Graj(Logika.POZIOM_TRUDNOSCI poziomTrudnosci)
        {
            switch (poziomTrudnosci)
            {
                case Logika.POZIOM_TRUDNOSCI.Latwy:
                    latwy.controls.play();
                    break;
                case Logika.POZIOM_TRUDNOSCI.Sredni:
                    sredni.controls.play();
                    break;
                case Logika.POZIOM_TRUDNOSCI.Trudny:
                    trudny.controls.play();
                    break;
                default:
                    break;
            }
            
        }
        public static void ZatrzymajMuzyke(Logika.POZIOM_TRUDNOSCI poziomTrudnosci)
        {
            switch (poziomTrudnosci)
            {
                case Logika.POZIOM_TRUDNOSCI.Latwy:
                    latwy.controls.stop();
                    break;
                case Logika.POZIOM_TRUDNOSCI.Sredni:
                    sredni.controls.stop();
                    break;
                case Logika.POZIOM_TRUDNOSCI.Trudny:
                    trudny.controls.stop();
                    break;
                default:
                    break;
            }
        }

        public static void MenuNaGra(Logika.POZIOM_TRUDNOSCI poziomTrudnosci)
        {
            menu.controls.stop();
            Graj(poziomTrudnosci);
        }
        public static void GraNaMenu(Logika.POZIOM_TRUDNOSCI poziomTrudnosci)
        {
            ZatrzymajMuzyke(poziomTrudnosci);
            menu.controls.stop();
        }
        
    }
}
