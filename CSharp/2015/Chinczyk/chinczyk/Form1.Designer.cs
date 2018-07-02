namespace chinczyk
{
    partial class Form1
    {
        const string pionek = "@";
        const int mp = 40; //maksymaalna liczba pól
        const int baza = mp + 1; //koordynat bazy
        const int niebo = 999; //koordynat końcowy
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p0 = new System.Windows.Forms.Button();
            this.p8 = new System.Windows.Forms.Button();
            this.p9 = new System.Windows.Forms.Button();
            this.p7 = new System.Windows.Forms.Button();
            this.p6 = new System.Windows.Forms.Button();
            this.p5 = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Button();
            this.p10 = new System.Windows.Forms.Button();
            this.p11 = new System.Windows.Forms.Button();
            this.p12 = new System.Windows.Forms.Button();
            this.p14 = new System.Windows.Forms.Button();
            this.p13 = new System.Windows.Forms.Button();
            this.p15 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Button();
            this.pc3 = new System.Windows.Forms.Button();
            this.pz3 = new System.Windows.Forms.Button();
            this.pf3 = new System.Windows.Forms.Button();
            this.pn3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bn = new System.Windows.Forms.Button();
            this.bz = new System.Windows.Forms.Button();
            this.bf = new System.Windows.Forms.Button();
            this.kos = new System.Windows.Forms.PictureBox();
            this.button_los = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ruch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KtoTeraz = new System.Windows.Forms.Label();
            this.pf0 = new System.Windows.Forms.Button();
            this.pf1 = new System.Windows.Forms.Button();
            this.pf2 = new System.Windows.Forms.Button();
            this.pn0 = new System.Windows.Forms.Button();
            this.pn1 = new System.Windows.Forms.Button();
            this.pn2 = new System.Windows.Forms.Button();
            this.pc2 = new System.Windows.Forms.Button();
            this.pc1 = new System.Windows.Forms.Button();
            this.pc0 = new System.Windows.Forms.Button();
            this.pz0 = new System.Windows.Forms.Button();
            this.pz1 = new System.Windows.Forms.Button();
            this.pz2 = new System.Windows.Forms.Button();
            this.p22 = new System.Windows.Forms.Button();
            this.p21 = new System.Windows.Forms.Button();
            this.p20 = new System.Windows.Forms.Button();
            this.p19 = new System.Windows.Forms.Button();
            this.p18 = new System.Windows.Forms.Button();
            this.p17 = new System.Windows.Forms.Button();
            this.p16 = new System.Windows.Forms.Button();
            this.p28 = new System.Windows.Forms.Button();
            this.p29 = new System.Windows.Forms.Button();
            this.p30 = new System.Windows.Forms.Button();
            this.p31 = new System.Windows.Forms.Button();
            this.p32 = new System.Windows.Forms.Button();
            this.p33 = new System.Windows.Forms.Button();
            this.p34 = new System.Windows.Forms.Button();
            this.p37 = new System.Windows.Forms.Button();
            this.p36 = new System.Windows.Forms.Button();
            this.p35 = new System.Windows.Forms.Button();
            this.p27 = new System.Windows.Forms.Button();
            this.p26 = new System.Windows.Forms.Button();
            this.p25 = new System.Windows.Forms.Button();
            this.p24 = new System.Windows.Forms.Button();
            this.p23 = new System.Windows.Forms.Button();
            this.p39 = new System.Windows.Forms.Button();
            this.p38 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kos)).BeginInit();
            this.SuspendLayout();
            // 
            // p0
            // 
            this.p0.AllowDrop = true;
            this.p0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p0.ForeColor = System.Drawing.Color.Black;
            this.p0.Location = new System.Drawing.Point(569, 73);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(70, 70);
            this.p0.TabIndex = 0;
            this.p0.UseVisualStyleBackColor = true;
            // 
            // p8
            // 
            this.p8.AllowDrop = true;
            this.p8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p8.ForeColor = System.Drawing.Color.Black;
            this.p8.Location = new System.Drawing.Point(873, 377);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(70, 70);
            this.p8.TabIndex = 1;
            this.p8.UseVisualStyleBackColor = true;
            // 
            // p9
            // 
            this.p9.AllowDrop = true;
            this.p9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p9.ForeColor = System.Drawing.Color.Black;
            this.p9.Location = new System.Drawing.Point(873, 453);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(70, 70);
            this.p9.TabIndex = 2;
            this.p9.UseVisualStyleBackColor = true;
            // 
            // p7
            // 
            this.p7.AllowDrop = true;
            this.p7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p7.ForeColor = System.Drawing.Color.Black;
            this.p7.Location = new System.Drawing.Point(797, 377);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(70, 70);
            this.p7.TabIndex = 3;
            this.p7.UseVisualStyleBackColor = true;
            // 
            // p6
            // 
            this.p6.AllowDrop = true;
            this.p6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p6.ForeColor = System.Drawing.Color.Black;
            this.p6.Location = new System.Drawing.Point(721, 377);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(70, 70);
            this.p6.TabIndex = 4;
            this.p6.UseVisualStyleBackColor = true;
            // 
            // p5
            // 
            this.p5.AllowDrop = true;
            this.p5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p5.ForeColor = System.Drawing.Color.Black;
            this.p5.Location = new System.Drawing.Point(645, 377);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(70, 70);
            this.p5.TabIndex = 5;
            this.p5.UseVisualStyleBackColor = true;
            // 
            // p4
            // 
            this.p4.AllowDrop = true;
            this.p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p4.ForeColor = System.Drawing.Color.Black;
            this.p4.Location = new System.Drawing.Point(569, 377);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(70, 70);
            this.p4.TabIndex = 6;
            this.p4.UseVisualStyleBackColor = true;
            // 
            // p3
            // 
            this.p3.AllowDrop = true;
            this.p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p3.ForeColor = System.Drawing.Color.Black;
            this.p3.Location = new System.Drawing.Point(569, 301);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(70, 70);
            this.p3.TabIndex = 7;
            this.p3.UseVisualStyleBackColor = true;
            // 
            // p10
            // 
            this.p10.AllowDrop = true;
            this.p10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p10.ForeColor = System.Drawing.Color.Black;
            this.p10.Location = new System.Drawing.Point(873, 529);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(70, 70);
            this.p10.TabIndex = 8;
            this.p10.UseVisualStyleBackColor = true;
            // 
            // p11
            // 
            this.p11.AllowDrop = true;
            this.p11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p11.ForeColor = System.Drawing.Color.Black;
            this.p11.Location = new System.Drawing.Point(797, 529);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(70, 70);
            this.p11.TabIndex = 9;
            this.p11.UseVisualStyleBackColor = true;
            // 
            // p12
            // 
            this.p12.AllowDrop = true;
            this.p12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p12.ForeColor = System.Drawing.Color.Black;
            this.p12.Location = new System.Drawing.Point(721, 529);
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(70, 70);
            this.p12.TabIndex = 10;
            this.p12.UseVisualStyleBackColor = true;
            // 
            // p14
            // 
            this.p14.AllowDrop = true;
            this.p14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p14.ForeColor = System.Drawing.Color.Black;
            this.p14.Location = new System.Drawing.Point(569, 529);
            this.p14.Name = "p14";
            this.p14.Size = new System.Drawing.Size(70, 70);
            this.p14.TabIndex = 11;
            this.p14.UseVisualStyleBackColor = true;
            // 
            // p13
            // 
            this.p13.AllowDrop = true;
            this.p13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p13.ForeColor = System.Drawing.Color.Black;
            this.p13.Location = new System.Drawing.Point(645, 529);
            this.p13.Name = "p13";
            this.p13.Size = new System.Drawing.Size(70, 70);
            this.p13.TabIndex = 12;
            this.p13.UseVisualStyleBackColor = true;
            // 
            // p15
            // 
            this.p15.AllowDrop = true;
            this.p15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p15.ForeColor = System.Drawing.Color.Black;
            this.p15.Location = new System.Drawing.Point(569, 605);
            this.p15.Name = "p15";
            this.p15.Size = new System.Drawing.Size(70, 70);
            this.p15.TabIndex = 13;
            this.p15.UseVisualStyleBackColor = true;
            // 
            // p2
            // 
            this.p2.AllowDrop = true;
            this.p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2.ForeColor = System.Drawing.Color.Black;
            this.p2.Location = new System.Drawing.Point(569, 225);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(70, 70);
            this.p2.TabIndex = 14;
            this.p2.UseVisualStyleBackColor = true;
            // 
            // p1
            // 
            this.p1.AllowDrop = true;
            this.p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1.ForeColor = System.Drawing.Color.Black;
            this.p1.Location = new System.Drawing.Point(569, 149);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(70, 70);
            this.p1.TabIndex = 15;
            this.p1.UseVisualStyleBackColor = true;
            // 
            // pc3
            // 
            this.pc3.AllowDrop = true;
            this.pc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pc3.ForeColor = System.Drawing.Color.Red;
            this.pc3.Location = new System.Drawing.Point(493, 377);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(70, 70);
            this.pc3.TabIndex = 16;
            this.pc3.UseVisualStyleBackColor = false;
            // 
            // pz3
            // 
            this.pz3.AllowDrop = true;
            this.pz3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pz3.ForeColor = System.Drawing.Color.Green;
            this.pz3.Location = new System.Drawing.Point(493, 529);
            this.pz3.Name = "pz3";
            this.pz3.Size = new System.Drawing.Size(70, 70);
            this.pz3.TabIndex = 17;
            this.pz3.UseVisualStyleBackColor = false;
            // 
            // pf3
            // 
            this.pf3.AllowDrop = true;
            this.pf3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pf3.ForeColor = System.Drawing.Color.Purple;
            this.pf3.Location = new System.Drawing.Point(417, 453);
            this.pf3.Name = "pf3";
            this.pf3.Size = new System.Drawing.Size(70, 70);
            this.pf3.TabIndex = 18;
            this.pf3.UseVisualStyleBackColor = false;
            // 
            // pn3
            // 
            this.pn3.AllowDrop = true;
            this.pn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pn3.ForeColor = System.Drawing.Color.Blue;
            this.pn3.Location = new System.Drawing.Point(569, 453);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(70, 70);
            this.pn3.TabIndex = 19;
            this.pn3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AllowDrop = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(493, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 20;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // bc
            // 
            this.bc.AllowDrop = true;
            this.bc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bc.ForeColor = System.Drawing.Color.Red;
            this.bc.Location = new System.Drawing.Point(967, 32);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(70, 70);
            this.bc.TabIndex = 21;
            this.bc.UseVisualStyleBackColor = false;
            // 
            // bn
            // 
            this.bn.AllowDrop = true;
            this.bn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bn.ForeColor = System.Drawing.Color.Blue;
            this.bn.Location = new System.Drawing.Point(967, 889);
            this.bn.Name = "bn";
            this.bn.Size = new System.Drawing.Size(70, 70);
            this.bn.TabIndex = 22;
            this.bn.UseVisualStyleBackColor = false;
            // 
            // bz
            // 
            this.bz.AllowDrop = true;
            this.bz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bz.ForeColor = System.Drawing.Color.Green;
            this.bz.Location = new System.Drawing.Point(37, 889);
            this.bz.Name = "bz";
            this.bz.Size = new System.Drawing.Size(70, 70);
            this.bz.TabIndex = 23;
            this.bz.UseVisualStyleBackColor = false;
            // 
            // bf
            // 
            this.bf.AllowDrop = true;
            this.bf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bf.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bf.ForeColor = System.Drawing.Color.Purple;
            this.bf.Location = new System.Drawing.Point(37, 32);
            this.bf.Name = "bf";
            this.bf.Size = new System.Drawing.Size(70, 70);
            this.bf.TabIndex = 24;
            this.bf.UseVisualStyleBackColor = false;
            // 
            // kos
            // 
            this.kos.Image = global::chinczyk.Properties.Resources.pk;
            this.kos.Location = new System.Drawing.Point(1074, 292);
            this.kos.Name = "kos";
            this.kos.Size = new System.Drawing.Size(50, 50);
            this.kos.TabIndex = 25;
            this.kos.TabStop = false;
            // 
            // button_los
            // 
            this.button_los.Location = new System.Drawing.Point(1061, 369);
            this.button_los.Name = "button_los";
            this.button_los.Size = new System.Drawing.Size(75, 23);
            this.button_los.TabIndex = 26;
            this.button_los.Text = "Losuj";
            this.button_los.UseVisualStyleBackColor = true;
            this.button_los.Click += new System.EventHandler(this.button_los_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ruch
            // 
            this.ruch.Enabled = false;
            this.ruch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ruch.Location = new System.Drawing.Point(1042, 438);
            this.ruch.Name = "ruch";
            this.ruch.Size = new System.Drawing.Size(94, 68);
            this.ruch.TabIndex = 27;
            this.ruch.Text = "RUCH";
            this.ruch.UseVisualStyleBackColor = true;
            this.ruch.Click += new System.EventHandler(this.ruch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1052, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Teraz gra:";
            // 
            // KtoTeraz
            // 
            this.KtoTeraz.AutoSize = true;
            this.KtoTeraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KtoTeraz.ForeColor = System.Drawing.Color.Red;
            this.KtoTeraz.Location = new System.Drawing.Point(1063, 650);
            this.KtoTeraz.Name = "KtoTeraz";
            this.KtoTeraz.Size = new System.Drawing.Size(42, 31);
            this.KtoTeraz.TabIndex = 29;
            this.KtoTeraz.Text = "@";
            // 
            // pf0
            // 
            this.pf0.AllowDrop = true;
            this.pf0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pf0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pf0.ForeColor = System.Drawing.Color.Purple;
            this.pf0.Location = new System.Drawing.Point(189, 453);
            this.pf0.Name = "pf0";
            this.pf0.Size = new System.Drawing.Size(70, 70);
            this.pf0.TabIndex = 30;
            this.pf0.UseVisualStyleBackColor = false;
            // 
            // pf1
            // 
            this.pf1.AllowDrop = true;
            this.pf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pf1.ForeColor = System.Drawing.Color.Purple;
            this.pf1.Location = new System.Drawing.Point(265, 453);
            this.pf1.Name = "pf1";
            this.pf1.Size = new System.Drawing.Size(70, 70);
            this.pf1.TabIndex = 31;
            this.pf1.UseVisualStyleBackColor = false;
            // 
            // pf2
            // 
            this.pf2.AllowDrop = true;
            this.pf2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pf2.ForeColor = System.Drawing.Color.Purple;
            this.pf2.Location = new System.Drawing.Point(341, 453);
            this.pf2.Name = "pf2";
            this.pf2.Size = new System.Drawing.Size(70, 70);
            this.pf2.TabIndex = 32;
            this.pf2.UseVisualStyleBackColor = false;
            // 
            // pn0
            // 
            this.pn0.AllowDrop = true;
            this.pn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pn0.ForeColor = System.Drawing.Color.Blue;
            this.pn0.Location = new System.Drawing.Point(797, 453);
            this.pn0.Name = "pn0";
            this.pn0.Size = new System.Drawing.Size(70, 70);
            this.pn0.TabIndex = 33;
            this.pn0.UseVisualStyleBackColor = false;
            // 
            // pn1
            // 
            this.pn1.AllowDrop = true;
            this.pn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pn1.ForeColor = System.Drawing.Color.Blue;
            this.pn1.Location = new System.Drawing.Point(721, 453);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(70, 70);
            this.pn1.TabIndex = 34;
            this.pn1.UseVisualStyleBackColor = false;
            // 
            // pn2
            // 
            this.pn2.AllowDrop = true;
            this.pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pn2.ForeColor = System.Drawing.Color.Blue;
            this.pn2.Location = new System.Drawing.Point(645, 453);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(70, 70);
            this.pn2.TabIndex = 35;
            this.pn2.UseVisualStyleBackColor = false;
            // 
            // pc2
            // 
            this.pc2.AllowDrop = true;
            this.pc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pc2.ForeColor = System.Drawing.Color.Red;
            this.pc2.Location = new System.Drawing.Point(493, 301);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(70, 70);
            this.pc2.TabIndex = 36;
            this.pc2.UseVisualStyleBackColor = false;
            // 
            // pc1
            // 
            this.pc1.AllowDrop = true;
            this.pc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pc1.ForeColor = System.Drawing.Color.Red;
            this.pc1.Location = new System.Drawing.Point(493, 225);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(70, 70);
            this.pc1.TabIndex = 37;
            this.pc1.UseVisualStyleBackColor = false;
            // 
            // pc0
            // 
            this.pc0.AllowDrop = true;
            this.pc0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pc0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pc0.ForeColor = System.Drawing.Color.Red;
            this.pc0.Location = new System.Drawing.Point(493, 149);
            this.pc0.Name = "pc0";
            this.pc0.Size = new System.Drawing.Size(70, 70);
            this.pc0.TabIndex = 38;
            this.pc0.UseVisualStyleBackColor = false;
            // 
            // pz0
            // 
            this.pz0.AllowDrop = true;
            this.pz0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pz0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pz0.ForeColor = System.Drawing.Color.Green;
            this.pz0.Location = new System.Drawing.Point(493, 757);
            this.pz0.Name = "pz0";
            this.pz0.Size = new System.Drawing.Size(70, 70);
            this.pz0.TabIndex = 39;
            this.pz0.UseVisualStyleBackColor = false;
            // 
            // pz1
            // 
            this.pz1.AllowDrop = true;
            this.pz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pz1.ForeColor = System.Drawing.Color.Green;
            this.pz1.Location = new System.Drawing.Point(493, 681);
            this.pz1.Name = "pz1";
            this.pz1.Size = new System.Drawing.Size(70, 70);
            this.pz1.TabIndex = 40;
            this.pz1.UseVisualStyleBackColor = false;
            // 
            // pz2
            // 
            this.pz2.AllowDrop = true;
            this.pz2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pz2.ForeColor = System.Drawing.Color.Green;
            this.pz2.Location = new System.Drawing.Point(493, 605);
            this.pz2.Name = "pz2";
            this.pz2.Size = new System.Drawing.Size(70, 70);
            this.pz2.TabIndex = 41;
            this.pz2.UseVisualStyleBackColor = false;
            // 
            // p22
            // 
            this.p22.AllowDrop = true;
            this.p22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p22.ForeColor = System.Drawing.Color.Black;
            this.p22.Location = new System.Drawing.Point(417, 681);
            this.p22.Name = "p22";
            this.p22.Size = new System.Drawing.Size(70, 70);
            this.p22.TabIndex = 42;
            this.p22.UseVisualStyleBackColor = true;
            // 
            // p21
            // 
            this.p21.AllowDrop = true;
            this.p21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p21.ForeColor = System.Drawing.Color.Black;
            this.p21.Location = new System.Drawing.Point(417, 757);
            this.p21.Name = "p21";
            this.p21.Size = new System.Drawing.Size(70, 70);
            this.p21.TabIndex = 43;
            this.p21.UseVisualStyleBackColor = true;
            // 
            // p20
            // 
            this.p20.AllowDrop = true;
            this.p20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p20.ForeColor = System.Drawing.Color.Black;
            this.p20.Location = new System.Drawing.Point(417, 833);
            this.p20.Name = "p20";
            this.p20.Size = new System.Drawing.Size(70, 70);
            this.p20.TabIndex = 44;
            this.p20.UseVisualStyleBackColor = true;
            // 
            // p19
            // 
            this.p19.AllowDrop = true;
            this.p19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p19.ForeColor = System.Drawing.Color.Black;
            this.p19.Location = new System.Drawing.Point(493, 833);
            this.p19.Name = "p19";
            this.p19.Size = new System.Drawing.Size(70, 70);
            this.p19.TabIndex = 45;
            this.p19.UseVisualStyleBackColor = true;
            // 
            // p18
            // 
            this.p18.AllowDrop = true;
            this.p18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p18.ForeColor = System.Drawing.Color.Black;
            this.p18.Location = new System.Drawing.Point(569, 833);
            this.p18.Name = "p18";
            this.p18.Size = new System.Drawing.Size(70, 70);
            this.p18.TabIndex = 46;
            this.p18.UseVisualStyleBackColor = true;
            // 
            // p17
            // 
            this.p17.AllowDrop = true;
            this.p17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p17.ForeColor = System.Drawing.Color.Black;
            this.p17.Location = new System.Drawing.Point(569, 757);
            this.p17.Name = "p17";
            this.p17.Size = new System.Drawing.Size(70, 70);
            this.p17.TabIndex = 47;
            this.p17.UseVisualStyleBackColor = true;
            // 
            // p16
            // 
            this.p16.AllowDrop = true;
            this.p16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p16.ForeColor = System.Drawing.Color.Black;
            this.p16.Location = new System.Drawing.Point(569, 681);
            this.p16.Name = "p16";
            this.p16.Size = new System.Drawing.Size(70, 70);
            this.p16.TabIndex = 48;
            this.p16.UseVisualStyleBackColor = true;
            // 
            // p28
            // 
            this.p28.AllowDrop = true;
            this.p28.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p28.ForeColor = System.Drawing.Color.Black;
            this.p28.Location = new System.Drawing.Point(113, 527);
            this.p28.Name = "p28";
            this.p28.Size = new System.Drawing.Size(70, 70);
            this.p28.TabIndex = 49;
            this.p28.UseVisualStyleBackColor = true;
            // 
            // p29
            // 
            this.p29.AllowDrop = true;
            this.p29.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p29.ForeColor = System.Drawing.Color.Black;
            this.p29.Location = new System.Drawing.Point(113, 453);
            this.p29.Name = "p29";
            this.p29.Size = new System.Drawing.Size(70, 70);
            this.p29.TabIndex = 50;
            this.p29.UseVisualStyleBackColor = true;
            // 
            // p30
            // 
            this.p30.AllowDrop = true;
            this.p30.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p30.ForeColor = System.Drawing.Color.Black;
            this.p30.Location = new System.Drawing.Point(113, 377);
            this.p30.Name = "p30";
            this.p30.Size = new System.Drawing.Size(70, 70);
            this.p30.TabIndex = 51;
            this.p30.UseVisualStyleBackColor = true;
            // 
            // p31
            // 
            this.p31.AllowDrop = true;
            this.p31.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p31.ForeColor = System.Drawing.Color.Black;
            this.p31.Location = new System.Drawing.Point(189, 377);
            this.p31.Name = "p31";
            this.p31.Size = new System.Drawing.Size(70, 70);
            this.p31.TabIndex = 52;
            this.p31.UseVisualStyleBackColor = true;
            // 
            // p32
            // 
            this.p32.AllowDrop = true;
            this.p32.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p32.ForeColor = System.Drawing.Color.Black;
            this.p32.Location = new System.Drawing.Point(265, 377);
            this.p32.Name = "p32";
            this.p32.Size = new System.Drawing.Size(70, 70);
            this.p32.TabIndex = 53;
            this.p32.UseVisualStyleBackColor = true;
            // 
            // p33
            // 
            this.p33.AllowDrop = true;
            this.p33.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p33.ForeColor = System.Drawing.Color.Black;
            this.p33.Location = new System.Drawing.Point(341, 377);
            this.p33.Name = "p33";
            this.p33.Size = new System.Drawing.Size(70, 70);
            this.p33.TabIndex = 54;
            this.p33.UseVisualStyleBackColor = true;
            // 
            // p34
            // 
            this.p34.AllowDrop = true;
            this.p34.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p34.ForeColor = System.Drawing.Color.Black;
            this.p34.Location = new System.Drawing.Point(417, 377);
            this.p34.Name = "p34";
            this.p34.Size = new System.Drawing.Size(70, 70);
            this.p34.TabIndex = 55;
            this.p34.UseVisualStyleBackColor = true;
            // 
            // p37
            // 
            this.p37.AllowDrop = true;
            this.p37.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p37.ForeColor = System.Drawing.Color.Black;
            this.p37.Location = new System.Drawing.Point(417, 149);
            this.p37.Name = "p37";
            this.p37.Size = new System.Drawing.Size(70, 70);
            this.p37.TabIndex = 56;
            this.p37.UseVisualStyleBackColor = true;
            // 
            // p36
            // 
            this.p36.AllowDrop = true;
            this.p36.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p36.ForeColor = System.Drawing.Color.Black;
            this.p36.Location = new System.Drawing.Point(417, 225);
            this.p36.Name = "p36";
            this.p36.Size = new System.Drawing.Size(70, 70);
            this.p36.TabIndex = 57;
            this.p36.UseVisualStyleBackColor = true;
            // 
            // p35
            // 
            this.p35.AllowDrop = true;
            this.p35.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p35.ForeColor = System.Drawing.Color.Black;
            this.p35.Location = new System.Drawing.Point(417, 301);
            this.p35.Name = "p35";
            this.p35.Size = new System.Drawing.Size(70, 70);
            this.p35.TabIndex = 58;
            this.p35.UseVisualStyleBackColor = true;
            // 
            // p27
            // 
            this.p27.AllowDrop = true;
            this.p27.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p27.ForeColor = System.Drawing.Color.Black;
            this.p27.Location = new System.Drawing.Point(189, 527);
            this.p27.Name = "p27";
            this.p27.Size = new System.Drawing.Size(70, 70);
            this.p27.TabIndex = 59;
            this.p27.UseVisualStyleBackColor = true;
            // 
            // p26
            // 
            this.p26.AllowDrop = true;
            this.p26.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p26.ForeColor = System.Drawing.Color.Black;
            this.p26.Location = new System.Drawing.Point(265, 527);
            this.p26.Name = "p26";
            this.p26.Size = new System.Drawing.Size(70, 70);
            this.p26.TabIndex = 60;
            this.p26.UseVisualStyleBackColor = true;
            // 
            // p25
            // 
            this.p25.AllowDrop = true;
            this.p25.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p25.ForeColor = System.Drawing.Color.Black;
            this.p25.Location = new System.Drawing.Point(341, 527);
            this.p25.Name = "p25";
            this.p25.Size = new System.Drawing.Size(70, 70);
            this.p25.TabIndex = 61;
            this.p25.UseVisualStyleBackColor = true;
            // 
            // p24
            // 
            this.p24.AllowDrop = true;
            this.p24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p24.ForeColor = System.Drawing.Color.Black;
            this.p24.Location = new System.Drawing.Point(417, 527);
            this.p24.Name = "p24";
            this.p24.Size = new System.Drawing.Size(70, 70);
            this.p24.TabIndex = 62;
            this.p24.UseVisualStyleBackColor = true;
            // 
            // p23
            // 
            this.p23.AllowDrop = true;
            this.p23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p23.ForeColor = System.Drawing.Color.Black;
            this.p23.Location = new System.Drawing.Point(417, 605);
            this.p23.Name = "p23";
            this.p23.Size = new System.Drawing.Size(70, 70);
            this.p23.TabIndex = 63;
            this.p23.UseVisualStyleBackColor = true;
            // 
            // p39
            // 
            this.p39.AllowDrop = true;
            this.p39.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p39.ForeColor = System.Drawing.Color.Black;
            this.p39.Location = new System.Drawing.Point(493, 73);
            this.p39.Name = "p39";
            this.p39.Size = new System.Drawing.Size(70, 70);
            this.p39.TabIndex = 64;
            this.p39.UseVisualStyleBackColor = true;
            // 
            // p38
            // 
            this.p38.AllowDrop = true;
            this.p38.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p38.ForeColor = System.Drawing.Color.Black;
            this.p38.Location = new System.Drawing.Point(417, 73);
            this.p38.Name = "p38";
            this.p38.Size = new System.Drawing.Size(70, 70);
            this.p38.TabIndex = 65;
            this.p38.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 971);
            this.Controls.Add(this.p38);
            this.Controls.Add(this.p39);
            this.Controls.Add(this.p23);
            this.Controls.Add(this.p24);
            this.Controls.Add(this.p25);
            this.Controls.Add(this.p26);
            this.Controls.Add(this.p27);
            this.Controls.Add(this.p35);
            this.Controls.Add(this.p36);
            this.Controls.Add(this.p37);
            this.Controls.Add(this.p34);
            this.Controls.Add(this.p33);
            this.Controls.Add(this.p32);
            this.Controls.Add(this.p31);
            this.Controls.Add(this.p30);
            this.Controls.Add(this.p29);
            this.Controls.Add(this.p28);
            this.Controls.Add(this.p16);
            this.Controls.Add(this.p17);
            this.Controls.Add(this.p18);
            this.Controls.Add(this.p19);
            this.Controls.Add(this.p20);
            this.Controls.Add(this.p21);
            this.Controls.Add(this.p22);
            this.Controls.Add(this.pz2);
            this.Controls.Add(this.pz1);
            this.Controls.Add(this.pz0);
            this.Controls.Add(this.pc0);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pn0);
            this.Controls.Add(this.pf2);
            this.Controls.Add(this.pf1);
            this.Controls.Add(this.pf0);
            this.Controls.Add(this.KtoTeraz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ruch);
            this.Controls.Add(this.button_los);
            this.Controls.Add(this.kos);
            this.Controls.Add(this.bf);
            this.Controls.Add(this.bz);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pn3);
            this.Controls.Add(this.pf3);
            this.Controls.Add(this.pz3);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p15);
            this.Controls.Add(this.p13);
            this.Controls.Add(this.p14);
            this.Controls.Add(this.p12);
            this.Controls.Add(this.p11);
            this.Controls.Add(this.p10);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p0;
        private System.Windows.Forms.Button p8;
        private System.Windows.Forms.Button p9;
        private System.Windows.Forms.Button p7;
        private System.Windows.Forms.Button p6;
        private System.Windows.Forms.Button p5;
        private System.Windows.Forms.Button p4;
        private System.Windows.Forms.Button p3;
        private System.Windows.Forms.Button p10;
        private System.Windows.Forms.Button p11;
        private System.Windows.Forms.Button p12;
        private System.Windows.Forms.Button p14;
        private System.Windows.Forms.Button p13;
        private System.Windows.Forms.Button p15;
        private System.Windows.Forms.Button p2;
        private System.Windows.Forms.Button p1;
        private System.Windows.Forms.Button pc3;
        private System.Windows.Forms.Button pz3;
        private System.Windows.Forms.Button pf3;
        private System.Windows.Forms.Button pn3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bn;
        private System.Windows.Forms.Button bz;
        private System.Windows.Forms.Button bf;
        private System.Windows.Forms.PictureBox kos;
        private System.Windows.Forms.Button button_los;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ruch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KtoTeraz;
        private System.Windows.Forms.Button pf0;
        private System.Windows.Forms.Button pf1;
        private System.Windows.Forms.Button pf2;
        private System.Windows.Forms.Button pn0;
        private System.Windows.Forms.Button pn1;
        private System.Windows.Forms.Button pn2;
        private System.Windows.Forms.Button pc2;
        private System.Windows.Forms.Button pc1;
        private System.Windows.Forms.Button pc0;
        private System.Windows.Forms.Button pz0;
        private System.Windows.Forms.Button pz1;
        private System.Windows.Forms.Button pz2;
        private System.Windows.Forms.Button p22;
        private System.Windows.Forms.Button p21;
        private System.Windows.Forms.Button p20;
        private System.Windows.Forms.Button p19;
        private System.Windows.Forms.Button p18;
        private System.Windows.Forms.Button p17;
        private System.Windows.Forms.Button p16;
        private System.Windows.Forms.Button p28;
        private System.Windows.Forms.Button p29;
        private System.Windows.Forms.Button p30;
        private System.Windows.Forms.Button p31;
        private System.Windows.Forms.Button p32;
        private System.Windows.Forms.Button p33;
        private System.Windows.Forms.Button p34;
        private System.Windows.Forms.Button p37;
        private System.Windows.Forms.Button p36;
        private System.Windows.Forms.Button p35;
        private System.Windows.Forms.Button p27;
        private System.Windows.Forms.Button p26;
        private System.Windows.Forms.Button p25;
        private System.Windows.Forms.Button p24;
        private System.Windows.Forms.Button p23;
        private System.Windows.Forms.Button p39;
        private System.Windows.Forms.Button p38;
    }
}

