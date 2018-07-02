namespace Mulitdokumentacja
{
    partial class Formularz
    {
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
            this.button_Generuj = new System.Windows.Forms.Button();
            this.textBox_Imie = new System.Windows.Forms.TextBox();
            this.textBox_Nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_Pesel = new System.Windows.Forms.TextBox();
            this.textBox_KodPocztowy = new System.Windows.Forms.TextBox();
            this.textBox_Miasto = new System.Windows.Forms.TextBox();
            this.textBox_Adres = new System.Windows.Forms.TextBox();
            this.comboBox_RodzajDokumentu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Czysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Generuj
            // 
            this.button_Generuj.Location = new System.Drawing.Point(325, 238);
            this.button_Generuj.Name = "button_Generuj";
            this.button_Generuj.Size = new System.Drawing.Size(82, 29);
            this.button_Generuj.TabIndex = 2;
            this.button_Generuj.Text = "Generuj raport";
            this.button_Generuj.UseVisualStyleBackColor = true;
            this.button_Generuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Imie
            // 
            this.textBox_Imie.Location = new System.Drawing.Point(36, 64);
            this.textBox_Imie.Name = "textBox_Imie";
            this.textBox_Imie.Size = new System.Drawing.Size(100, 20);
            this.textBox_Imie.TabIndex = 3;
            // 
            // textBox_Nazwisko
            // 
            this.textBox_Nazwisko.Location = new System.Drawing.Point(142, 64);
            this.textBox_Nazwisko.Name = "textBox_Nazwisko";
            this.textBox_Nazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nazwisko.TabIndex = 4;
            // 
            // textBox_Pesel
            // 
            this.textBox_Pesel.Location = new System.Drawing.Point(142, 100);
            this.textBox_Pesel.Name = "textBox_Pesel";
            this.textBox_Pesel.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pesel.TabIndex = 5;
            // 
            // textBox_KodPocztowy
            // 
            this.textBox_KodPocztowy.Location = new System.Drawing.Point(73, 196);
            this.textBox_KodPocztowy.Name = "textBox_KodPocztowy";
            this.textBox_KodPocztowy.Size = new System.Drawing.Size(63, 20);
            this.textBox_KodPocztowy.TabIndex = 7;
            // 
            // textBox_Miasto
            // 
            this.textBox_Miasto.Location = new System.Drawing.Point(142, 196);
            this.textBox_Miasto.Name = "textBox_Miasto";
            this.textBox_Miasto.Size = new System.Drawing.Size(100, 20);
            this.textBox_Miasto.TabIndex = 8;
            // 
            // textBox_Adres
            // 
            this.textBox_Adres.Location = new System.Drawing.Point(142, 135);
            this.textBox_Adres.Name = "textBox_Adres";
            this.textBox_Adres.Size = new System.Drawing.Size(100, 20);
            this.textBox_Adres.TabIndex = 6;
            // 
            // comboBox_RodzajDokumentu
            // 
            this.comboBox_RodzajDokumentu.FormattingEnabled = true;
            this.comboBox_RodzajDokumentu.Location = new System.Drawing.Point(343, 64);
            this.comboBox_RodzajDokumentu.Name = "comboBox_RodzajDokumentu";
            this.comboBox_RodzajDokumentu.Size = new System.Drawing.Size(121, 21);
            this.comboBox_RodzajDokumentu.TabIndex = 9;
            this.comboBox_RodzajDokumentu.SelectedIndexChanged += new System.EventHandler(this.comboBox_RodzajDokumentu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "    Imię/Imiona                    Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kod pocztowy        Miasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "PESEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adres i nr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rodzaj dokumentu";
            // 
            // button_Czysc
            // 
            this.button_Czysc.Location = new System.Drawing.Point(102, 244);
            this.button_Czysc.Name = "button_Czysc";
            this.button_Czysc.Size = new System.Drawing.Size(75, 23);
            this.button_Czysc.TabIndex = 16;
            this.button_Czysc.Text = "Czyść";
            this.button_Czysc.UseVisualStyleBackColor = true;
            this.button_Czysc.Click += new System.EventHandler(this.button_Czysc_Click);
            // 
            // Formularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 368);
            this.Controls.Add(this.button_Czysc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_RodzajDokumentu);
            this.Controls.Add(this.textBox_Adres);
            this.Controls.Add(this.textBox_Miasto);
            this.Controls.Add(this.textBox_KodPocztowy);
            this.Controls.Add(this.textBox_Pesel);
            this.Controls.Add(this.textBox_Nazwisko);
            this.Controls.Add(this.textBox_Imie);
            this.Controls.Add(this.button_Generuj);
            this.Name = "Formularz";
            this.Text = "Formularz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Generuj;
        private System.Windows.Forms.TextBox textBox_Imie;
        private System.Windows.Forms.TextBox textBox_Nazwisko;
        private System.Windows.Forms.TextBox textBox_Pesel;
        private System.Windows.Forms.TextBox textBox_KodPocztowy;
        private System.Windows.Forms.TextBox textBox_Miasto;
        private System.Windows.Forms.TextBox textBox_Adres;
        private System.Windows.Forms.ComboBox comboBox_RodzajDokumentu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Czysc;
    }
}

