using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chinczyk
{
    public partial class Form1 : Form
    {
        int i;
        Bitmap pusta = new Bitmap("pk.png");
        Bitmap o1 = new Bitmap("1.png");
        Bitmap o2 = new Bitmap("2.png");
        Bitmap o3 = new Bitmap("3.png");
        Bitmap o4 = new Bitmap("4.png");
        Bitmap o5 = new Bitmap("5.png");
        Bitmap o6 = new Bitmap("6.png");
        Random los = new Random();
        int oczka;
        public struct pole
        {
            public string tyt;
            public int p, pocz;
            public bool WBazie;
            public bool BliskoMety;
            public bool Kolko;
        }
        int kolejka=1;
        pole czerwony = new pole(); //1
        pole niebieski = new pole(); //2
        pole zielony = new pole(); //3
        pole fioletowy = new pole(); //4

        public Form1()
        {
            InitializeComponent();
        }
        public void mix()
        {
            button_los.Image = o1;
            button_los.Image = o2;
            button_los.Image = o3;
            button_los.Image = o4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (i = 0; i < 5; i++) mix();
        }

        private void button_los_Click(object sender, EventArgs e)
        {
            button_los.Enabled = false;
            this.timer1.Start();
            this.timer1.Stop();
            button_los.Enabled = true;
            oczka = los.Next(5, 7);
            switch(oczka)
            {
                case 1:
                    {
                        oczka = 1;
                        kos.Image = o1;
                        break;
                    }

                case 2:
                    {
                        oczka = 2;
                        kos.Image = o2;
                        break;
                    }

                case 3:
                    {
                        oczka = 3;
                        kos.Image = o3;
                        break;
                    }

                case 4:
                    {
                        oczka = 4;
                        kos.Image = o4;
                        break;
                    }

                case 5:
                    {
                        oczka = 5;
                        kos.Image = o5;
                        break;
                    }

                case 6:
                    {
                        oczka = 6;
                        kos.Image = o6;
                        break;
                    }
            }
            ruch.Enabled = true;
if ((kolejka == 1 && czerwony.WBazie == true) || (kolejka == 2 && niebieski.WBazie == true) || (kolejka == 3 && zielony.WBazie == true) || (kolejka == 4 && fioletowy.WBazie == true)) button_los.Enabled = true;
            else button_los.Enabled = false;
        }

        private void ruch_Click(object sender, EventArgs e)
        {
            krok();
            ruch.Enabled = false;
        }

        public void krok()
        {
            switch (kolejka)
            {
                case 1: //czerwony
                    {
                        if (czerwony.WBazie == true && oczka == 6)
                        {
                            czerwony.p = czerwony.pocz;
                            if (czerwony.p == niebieski.p)
                            {
                                this.Controls["p" + niebieski.p].Text = pionek;
                                this.Controls["p" + niebieski.p].ForeColor = Color.Red;
                                niebieski.p = baza;
                                this.bn.Text = pionek; // BAZA !!!
                            }
                            if (czerwony.p == zielony.p)
                            {
                                this.Controls["p" + zielony.p].Text = pionek;
                                this.Controls["p" + zielony.p].ForeColor = Color.Red;
                                zielony.p = baza;
                                this.bz.Text = pionek; // BAZA !!!
                            }
                            if (czerwony.p == fioletowy.p)
                            {
                                this.Controls["p" + fioletowy.p].Text = pionek;
                                this.Controls["p" + fioletowy.p].ForeColor = Color.Red;
                                fioletowy.p = baza;
                                this.bf.Text = pionek; // BAZA !!!
                            }
                            this.Controls["p" + czerwony.p].Text = pionek;
                            this.Controls["p" + czerwony.p].ForeColor = Color.Red;
                            this.bc.Text = ""; // BAZA !!!
                            czerwony.WBazie = false;
                            button_los.Enabled = true;
                            break;
                        }
                        if (czerwony.WBazie == false)
                        {
                            for (i = 0; i < mp; i++)
                            {
                                if (this.Controls["p" + i].ForeColor == Color.Red)
                                {
                                    czerwony.p = i;
                                    break;
                                }
                            }
                            this.Controls["p" + czerwony.p].Text = pionek;
                            this.Controls["p" + czerwony.p].ForeColor = Color.Red;

                            if (czerwony.p + oczka > mp - 1)
                            {
                                this.Controls["p" + czerwony.p].Text = "";
                                this.Controls["p" + czerwony.p].ForeColor = Color.Black;
                                czerwony.p = (czerwony.p+oczka)-mp;
                                if (czerwony.p >=3)
                                {
                                    //for (i = 0; i < 3; i++) this.Controls["pc" + i].Text = "";
                                    this.Controls["pc" + niebieski.p].Text = "";
                                    this.pc3.Text = pionek; // KONIEC !!!
                                    //for (i = 0; i < mp; i++) this.Controls["p" + i].Text = "";
                                    this.button5.Text = ":-D";
                                    MessageBox.Show("Wygrał "+czerwony.tyt);
                                    button_los.Enabled = false;
                                    ruch.Enabled = false;
                                    break;
                                }
                                this.Controls["pc"+czerwony.p].Text = pionek;
                                button_los.Enabled = true;
                                czerwony.BliskoMety = true;
                            }
                            else
                            {
                                this.Controls["p" + czerwony.p].Text = "";
                                this.Controls["p" + czerwony.p].ForeColor = Color.Black;
                                czerwony.p += oczka;
                                if (czerwony.BliskoMety==true && czerwony.p + oczka >= 3)
                                {
                                    for (i = 0; i < 3; i++) this.Controls["pc" + i].Text = "";
                                    this.pc3.Text = pionek; // KONIEC !!!
                                    for (i = 0; i < mp; i++) this.Controls["p" + i].Text = "";
                                    this.button5.Text = ":-D";
                                    MessageBox.Show("Wygrał " + czerwony.tyt);
                                    button_los.Enabled = false;
                                    ruch.Enabled = false;
                                    break;
                                }
                                if (czerwony.p == niebieski.p)
                                {
                                    this.Controls["p" + niebieski.p].Text = pionek;
                                    this.Controls["p" + niebieski.p].ForeColor = Color.Red;
                                    niebieski.p = baza;
                                    this.bn.Text = pionek; // BAZA !!!
                                }
                                if (czerwony.p == zielony.p)
                                {
                                    this.Controls["p" + zielony.p].Text = pionek;
                                    this.Controls["p" + zielony.p].ForeColor = Color.Red;
                                    zielony.p = baza;
                                    this.bz.Text = pionek; // BAZA !!!
                                }
                                if (czerwony.p == fioletowy.p)
                                {
                                    this.Controls["p" + fioletowy.p].Text = pionek;
                                    this.Controls["p" + fioletowy.p].ForeColor = Color.Red;
                                    fioletowy.p = baza;
                                    this.bf.Text = pionek; // BAZA !!!
                                }

                                this.Controls["p" + czerwony.p].Text = pionek;
                                this.Controls["p" + czerwony.p].ForeColor = Color.Red;
                            }
                        }
                        button_los.Enabled = true;
                        kolejka = 2;
                        KtoTeraz.ForeColor = Color.Blue;
                        break;
                        //czer koniec
                    }

                case 2: //niebieski
                    {
                        if (niebieski.WBazie == true && oczka == 6)
                        {
                            niebieski.p = niebieski.pocz;
                            if (niebieski.p == czerwony.p)
                            {
                                this.Controls["p" + czerwony.p].Text = pionek;
                                this.Controls["p" + czerwony.p].ForeColor = Color.Blue;
                                czerwony.p = baza;
                                this.bn.Text = pionek; // BAZA !!!
                            }
                            if (niebieski.p == zielony.p)
                            {
                                this.Controls["p" + zielony.p].Text = pionek;
                                this.Controls["p" + zielony.p].ForeColor = Color.Blue;
                                zielony.p = baza;
                                this.bz.Text = pionek; // BAZA !!!
                            }
                            if (niebieski.p == fioletowy.p)
                            {
                                this.Controls["p" + fioletowy.p].Text = pionek;
                                this.Controls["p" + fioletowy.p].ForeColor = Color.Blue;
                                fioletowy.p = baza;
                                this.bf.Text = pionek; // BAZA !!!
                            }
                            this.Controls["p" + niebieski.p].Text = pionek;
                            this.Controls["p" + niebieski.p].ForeColor = Color.Blue;
                            this.bn.Text = ""; // BAZA !!!
                            niebieski.WBazie = false;
                            niebieski.Kolko = false;
                            button_los.Enabled = true;
                            break;
                        }

                        if (niebieski.WBazie == false)
                        {
                            this.Controls["p" + niebieski.p].Text = pionek;
                            this.Controls["p" + niebieski.p].ForeColor = Color.Blue;
                            this.Controls["p" + niebieski.p].Text = "";
                            this.Controls["p" + niebieski.p].ForeColor = Color.Black;

                            niebieski.p += oczka;
                            if (niebieski.p > mp)
                            {
                                niebieski.p -= mp;
                                niebieski.Kolko = true;
                                Controls["p" + niebieski.p].Text = pionek;
                                Controls["p" + niebieski.p].ForeColor = Color.Blue;
                            }
                            else
                            {

                                if (niebieski.Kolko == true && niebieski.p > mp / 4 - 1)
                                {
                                    this.Controls["p" + niebieski.p].Text = "";
                                    this.Controls["p" + niebieski.p].ForeColor = Color.Black;
                                    niebieski.p = niebieski.p - mp / 4;
                                    if (niebieski.Kolko == true && niebieski.p >= 3)
                                    {
                                        //for (i = 0; i < 3; i++) this.Controls["pc" + i].Text = "";
                                        this.Controls["pn" + niebieski.p].Text = "";
                                        this.pn3.Text = pionek; // KONIEC !!!
                                        //for (i = 0; i < mp; i++) this.Controls["p" + i].Text = "";
                                        this.button5.Text = ":-D";
                                        MessageBox.Show("Wygrał " + niebieski.tyt); //error
                                        button_los.Enabled = false;
                                        ruch.Enabled = false;
                                        break;
                                    }
                                    this.Controls["pn" + niebieski.p].Text = pionek;
                                    button_los.Enabled = true;
                                    niebieski.BliskoMety = true;
                                }
                                else
                                {
                                    Controls["p" + niebieski.p].Text = "";
                                    Controls["p" + niebieski.p].ForeColor = Color.Black;
                                    //niebieski.p += oczka;
                                    if (niebieski.Kolko == true && niebieski.BliskoMety == true && niebieski.p >= 3)
                                    {
                                        //for (i = 0; i < 3; i++) this.Controls["pc" + i].Text = "";
                                        this.Controls["pn" + niebieski.p].Text = "";
                                        this.pn3.Text = pionek; // KONIEC !!!
                                        //for (i = 0; i < mp; i++) this.Controls["p" + i].Text = "";
                                        this.button5.Text = ":-D";
                                        MessageBox.Show("Wygrał " + niebieski.tyt);
                                        button_los.Enabled = false;
                                        ruch.Enabled = false;
                                        break;
                                    }
                                    if (niebieski.p == czerwony.p)
                                    {
                                        this.Controls["p" + czerwony.p].Text = pionek;
                                        this.Controls["p" + czerwony.p].ForeColor = Color.Blue;
                                        czerwony.p = baza;
                                        this.bc.Text = pionek; // BAZA !!!
                                    }
                                    if (niebieski.p == zielony.p)
                                    {
                                        this.Controls["p" + zielony.p].Text = pionek;
                                        this.Controls["p" + zielony.p].ForeColor = Color.Blue;
                                        zielony.p = baza;
                                        this.bz.Text = pionek; // BAZA !!!
                                    }
                                    if (niebieski.p == fioletowy.p)
                                    {
                                        this.Controls["p" + fioletowy.p].Text = pionek;
                                        this.Controls["p" + fioletowy.p].ForeColor = Color.Blue;
                                        fioletowy.p = baza;
                                        this.bf.Text = pionek; // BAZA !!!
                                    }

                                    this.Controls["p" + niebieski.p].Text = pionek;
                                    this.Controls["p" + niebieski.p].ForeColor = Color.Blue;
                                }
                            }
                        }
                        button_los.Enabled = true;
                        kolejka = 3;
                        KtoTeraz.ForeColor = Color.Green;
                        break;
                        //nieb koniec
                    }

                case 3: //zielony
                    {
                        if (zielony.WBazie == true && oczka == 6)
                        {
                            zielony.p = zielony.pocz;
                            if (zielony.p == czerwony.p)
                            {
                                this.Controls["p" + czerwony.p].Text = pionek;
                                this.Controls["p" + czerwony.p].ForeColor = Color.Green;
                                czerwony.p = baza;
                                this.bz.Text = pionek; // BAZA !!!
                            }
                            if (zielony.p == niebieski.p)
                            {
                                this.Controls["p" + niebieski.p].Text = pionek;
                                this.Controls["p" + niebieski.p].ForeColor = Color.Green;
                                niebieski.p = baza;
                                this.bn.Text = pionek; // BAZA !!!
                            }
                            if (zielony.p == fioletowy.p)
                            {
                                this.Controls["p" + fioletowy.p].Text = pionek;
                                this.Controls["p" + fioletowy.p].ForeColor = Color.Green;
                                fioletowy.p = baza;
                                this.bf.Text = pionek; // BAZA !!!
                            }
                            this.Controls["p" + zielony.p].Text = pionek;
                            this.Controls["p" + zielony.p].ForeColor = Color.Green;
                            this.bz.Text = ""; // BAZA !!!
                            zielony.WBazie = false;
                            zielony.Kolko = false;
                            button_los.Enabled = true;
                            break;
                        }
                        if (zielony.WBazie == false)
                        {
                            this.Controls["p" + zielony.p].Text = pionek;
                            this.Controls["p" + zielony.p].ForeColor = Color.Green;
                            this.Controls["p" + zielony.p].Text = "";
                            this.Controls["p" + zielony.p].ForeColor = Color.Black;

                            zielony.p += oczka;
                            if (zielony.p > mp)
                            {
                                zielony.p -= mp;
                                zielony.Kolko = true;
                                Controls["p" + zielony.p].Text = pionek;
                                Controls["p" + zielony.p].ForeColor = Color.Green;
                            }
                            else
                            {

                                if (zielony.Kolko == true && zielony.p > mp / 2 - 1)
                                {
                                    this.Controls["p" + zielony.p].Text = "";
                                    this.Controls["p" + zielony.p].ForeColor = Color.Black;
                                    zielony.p = zielony.p - mp / 2;
                                    if (zielony.Kolko == true && zielony.p >= 3)
                                    {
                                        //for (i = 0; i < 3; i++) this.Controls["pc" + i].Text = "";
                                        this.Controls["pz" + zielony.p].Text = "";
                                        this.pz3.Text = pionek; // KONIEC !!!
                                        //for (i = 0; i < mp; i++) this.Controls["p" + i].Text = "";
                                        this.button5.Text = ":-D";
                                        MessageBox.Show("Wygrał " + zielony.tyt);
                                        button_los.Enabled = false;
                                        ruch.Enabled = false;
                                        break;
                                    }
                                    this.Controls["pz" + zielony.p].Text = pionek;
                                    button_los.Enabled = true;
                                    zielony.BliskoMety = true;
                                }
                                else
                                {
                                    Controls["p" + zielony.p].Text = "";
                                    Controls["p" + zielony.p].ForeColor = Color.Black;
                                    //zielony.p += oczka;
                                    if (zielony.Kolko == true && zielony.BliskoMety == true && zielony.p >= 3)
                                    {
                                        //for (i = 0; i < 3; i++) this.Controls["pc" + i].Text = "";
                                        this.Controls["pz" + niebieski.p].Text = "";
                                        this.pz3.Text = pionek; // KONIEC !!!
                                        //for (i = 0; i < mp; i++) this.Controls["p" + i].Text = "";
                                        this.button5.Text = ":-D";
                                        MessageBox.Show("Wygrał " + zielony.tyt);
                                        button_los.Enabled = false;
                                        ruch.Enabled = false;
                                        break;
                                    }
                                    if (zielony.p == czerwony.p)
                                    {
                                        this.Controls["p" + czerwony.p].Text = pionek;
                                        this.Controls["p" + czerwony.p].ForeColor = Color.Green;
                                        czerwony.p = baza;
                                        this.bc.Text = pionek; // BAZA !!!
                                    }
                                    if (zielony.p == niebieski.p)
                                    {
                                        this.Controls["p" + niebieski.p].Text = pionek;
                                        this.Controls["p" + niebieski.p].ForeColor = Color.Green;
                                        niebieski.p = baza;
                                        this.bn.Text = pionek; // BAZA !!!
                                    }
                                    if (zielony.p == fioletowy.p)
                                    {
                                        this.Controls["p" + fioletowy.p].Text = pionek;
                                        this.Controls["p" + fioletowy.p].ForeColor = Color.Green;
                                        fioletowy.p = baza;
                                        this.bf.Text = pionek; // BAZA !!!
                                    }

                                    this.Controls["p" + zielony.p].Text = pionek;
                                    this.Controls["p" + zielony.p].ForeColor = Color.Green;
                                }
                            }
                        }
                        button_los.Enabled = true;
                        kolejka = 4;
                        KtoTeraz.ForeColor = Color.Purple;
                        break;
                        //ziel koniec
                    }

                case 4: //fioletowy
                    {
                        if (fioletowy.WBazie == true && oczka == 6)
                        {
                            fioletowy.p = fioletowy.pocz;
                            if (fioletowy.p == czerwony.p)
                            {
                                this.Controls["p" + czerwony.p].Text = pionek;
                                this.Controls["p" + czerwony.p].ForeColor = Color.Purple;
                                czerwony.p = baza;
                                this.bz.Text = pionek; // BAZA !!!
                            }
                            if (fioletowy.p == niebieski.p)
                            {
                                this.Controls["p" + niebieski.p].Text = pionek;
                                this.Controls["p" + niebieski.p].ForeColor = Color.Purple;
                                niebieski.p = baza;
                                this.bn.Text = pionek; // BAZA !!!
                            }
                            if (fioletowy.p == zielony.p)
                            {
                                this.Controls["p" + zielony.p].Text = pionek;
                                this.Controls["p" + zielony.p].ForeColor = Color.Purple;
                                zielony.p = baza;
                                this.bz.Text = pionek; // BAZA !!!
                            }
                            this.Controls["p" + fioletowy.p].Text = pionek;
                            this.Controls["p" + fioletowy.p].ForeColor = Color.Purple;
                            this.bf.Text = ""; // BAZA !!!
                            fioletowy.WBazie = false;
                            fioletowy.Kolko = false;
                            button_los.Enabled = true;
                            break;
                        }
                        if (fioletowy.WBazie == false)
                        {
                            this.Controls["p" + fioletowy.p].Text = pionek;
                            this.Controls["p" + fioletowy.p].ForeColor = Color.Purple;
                            this.Controls["p" + fioletowy.p].Text = "";
                            this.Controls["p" + fioletowy.p].ForeColor = Color.Black;

                            fioletowy.p += oczka;
                            if (fioletowy.p > mp)
                            {
                                fioletowy.p -= mp;
                                fioletowy.Kolko = true;
                                Controls["p" + fioletowy.p].Text = pionek;
                                Controls["p" + fioletowy.p].ForeColor = Color.Purple;
                            }
                            else
                            {

                                if (fioletowy.Kolko == true && fioletowy.p > 29) //(0.75*mp)-1
                                {
                                    this.Controls["p" + fioletowy.p].Text = "";
                                    this.Controls["p" + fioletowy.p].ForeColor = Color.Black;
                                    fioletowy.p = fioletowy.p - 29; //(0.75*mp)
                                    if (fioletowy.Kolko == true && fioletowy.p >= 3)
                                    {
                                        //for (i = 0; i < 3; i++) this.Controls["pc" + i].Text = "";
                                        this.Controls["pf" + fioletowy.p].Text = "";
                                        fioletowy.p = niebo;
                                        this.pf3.Text = pionek; // KONIEC !!!
                                        //for (i = 0; i < mp; i++) this.Controls["p" + i].Text = "";
                                        this.button5.Text = ":-D";
                                        MessageBox.Show("Wygrał " + fioletowy.tyt);
                                        button_los.Enabled = false;
                                        ruch.Enabled = false;
                                        break;
                                    }
                                    this.Controls["pf" + fioletowy.p].Text = pionek;
                                    button_los.Enabled = true;
                                    fioletowy.BliskoMety = true;
                                }
                                else
                                {
                                    Controls["p" + fioletowy.p].Text = "";
                                    Controls["p" + fioletowy.p].ForeColor = Color.Black;
                                    //fioletowy.p += oczka;
                                    if (fioletowy.Kolko == true && fioletowy.BliskoMety == true && fioletowy.p >= 3)
                                    {
                                        //for (i = 0; i < 3; i++) this.Controls["pc" + i].Text = "";
                                        this.Controls["pf" + niebieski.p].Text = "";
                                        this.pf3.Text = pionek; // KONIEC !!!
                                        //for (i = 0; i < mp; i++) this.Controls["p" + i].Text = "";
                                        this.button5.Text = ":-D";
                                        MessageBox.Show("Wygrał " + fioletowy.tyt);
                                        button_los.Enabled = false;
                                        ruch.Enabled = false;
                                        break;
                                    }
                                    if (fioletowy.p == czerwony.p)
                                    {
                                        this.Controls["p" + czerwony.p].Text = pionek;
                                        this.Controls["p" + czerwony.p].ForeColor = Color.Purple;
                                        czerwony.p = baza;
                                        this.bc.Text = pionek; // BAZA !!!
                                    }
                                    if (fioletowy.p == niebieski.p)
                                    {
                                        this.Controls["p" + niebieski.p].Text = pionek;
                                        this.Controls["p" + niebieski.p].ForeColor = Color.Purple;
                                        niebieski.p = baza;
                                        this.bn.Text = pionek; // BAZA !!!
                                    }
                                    if (fioletowy.p == zielony.p)
                                    {
                                        this.Controls["p" + zielony.p].Text = pionek;
                                        this.Controls["p" + zielony.p].ForeColor = Color.Purple;
                                        zielony.p = baza;
                                        this.bz.Text = pionek; // BAZA !!!
                                    }

                                    this.Controls["p" + fioletowy.p].Text = pionek;
                                    this.Controls["p" + fioletowy.p].ForeColor = Color.Purple;
                                }
                            }
                        }
                        button_los.Enabled = true;
                        kolejka = 1;
                        KtoTeraz.ForeColor = Color.Red;
                        break;
                        //fiol koniec
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Controls["button" + a].Text = "X";
            this.KtoTeraz.Text = pionek;
            this.KtoTeraz.ForeColor = Color.Red;

            czerwony.tyt = "czerwony";
            niebieski.tyt = "niebieski";
            zielony.tyt = "zielony";
            fioletowy.tyt = "fioletowy";

            czerwony.WBazie = true;
            niebieski.WBazie = true;
            zielony.WBazie = true;
            fioletowy.WBazie = true;

            czerwony.BliskoMety = false;
            niebieski.BliskoMety = false;
            zielony.BliskoMety = false;
            fioletowy.BliskoMety = false;

            niebieski.Kolko = false;
            zielony.Kolko = false;
            fioletowy.Kolko = false;

            czerwony.pocz = 0;
            niebieski.pocz = 10;
            zielony.pocz = 20;
            fioletowy.pocz = 30;

            czerwony.p = baza;
            niebieski.p = baza;
            zielony.p = baza;
            fioletowy.p = baza;

            this.bc.Text = pionek;
            this.bn.Text = pionek;
            this.bz.Text = pionek;
            this.bf.Text = pionek;
            this.kos.Image = pusta;
        }
    }
}
