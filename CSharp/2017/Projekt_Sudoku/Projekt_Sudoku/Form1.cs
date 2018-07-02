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

namespace Projekt_Sudoku
{
    public partial class Form1 : Form
    {
        public static byte rezerwa = Byte.MaxValue-1;
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(650, 430 + rezerwa);
            Icon = Properties.Resources.favicon;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Gra.menu = new Menu(ClientRectangle, Controls);
            Width -= 3; Height -= 3;
            if (Gra.menu.muzyka.Checked) Muzyka.MenuStart();
            Generator.Deleguj(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Projekt_Sudoku.Menu.rozgrywka)
            {
                if (Gra.menu.autozapis.Checked)
                    Gra.ZapiszPlansze(new StreamWriter("zap.txt"),
                        new StreamWriter("flagi.txt"), new StreamWriter("pt.txt"));
                else
                {
                    if (Projekt_Sudoku.Menu.zapisz.Enabled)
                    {
                        var komunikat = MessageBox.Show("Czy chcesz zapisać stan gry przed wyjściem ?", "Komunikat zapisu", MessageBoxButtons.YesNoCancel);
                        if (komunikat.Equals(DialogResult.Cancel)) e.Cancel = true;
                        if (komunikat.Equals(DialogResult.Yes))
                            Gra.ZapiszPlansze(new StreamWriter("zap.txt"),
                            new StreamWriter("flagi.txt"), new StreamWriter("pt.txt"));
                    }
                } 
            }
        }
    }
}
