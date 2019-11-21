namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Nev = new System.Windows.Forms.Label();
            this.label_Szuleteslabel_Szuletes = new System.Windows.Forms.Label();
            this.label_Nem = new System.Windows.Forms.Label();
            this.label_Feliratkozom = new System.Windows.Forms.Label();
            this.Textbox_nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Szuletesi_Datum = new System.Windows.Forms.DateTimePicker();
            this.radioButton_Ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_Hobbik = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_UjHobbi = new System.Windows.Forms.TextBox();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Hozzaad = new System.Windows.Forms.Button();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.Location = new System.Drawing.Point(40, 54);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(30, 13);
            this.label_Nev.TabIndex = 0;
            this.label_Nev.Tag = "Név";
            this.label_Nev.Text = "Név:";
            // 
            // label_Szuleteslabel_Szuletes
            // 
            this.label_Szuleteslabel_Szuletes.AutoSize = true;
            this.label_Szuleteslabel_Szuletes.Location = new System.Drawing.Point(40, 94);
            this.label_Szuleteslabel_Szuletes.Name = "label_Szuleteslabel_Szuletes";
            this.label_Szuleteslabel_Szuletes.Size = new System.Drawing.Size(84, 13);
            this.label_Szuleteslabel_Szuletes.TabIndex = 1;
            this.label_Szuleteslabel_Szuletes.Tag = "szuletes_datuma";
            this.label_Szuleteslabel_Szuletes.Text = "Születési dátum:";
            // 
            // label_Nem
            // 
            this.label_Nem.AutoSize = true;
            this.label_Nem.Location = new System.Drawing.Point(40, 137);
            this.label_Nem.Name = "label_Nem";
            this.label_Nem.Size = new System.Drawing.Size(32, 13);
            this.label_Nem.TabIndex = 2;
            this.label_Nem.Tag = "nem";
            this.label_Nem.Text = "Nem:";
            // 
            // label_Feliratkozom
            // 
            this.label_Feliratkozom.AutoSize = true;
            this.label_Feliratkozom.Location = new System.Drawing.Point(43, 179);
            this.label_Feliratkozom.Name = "label_Feliratkozom";
            this.label_Feliratkozom.Size = new System.Drawing.Size(69, 13);
            this.label_Feliratkozom.TabIndex = 3;
            this.label_Feliratkozom.Tag = "Feliratkozom";
            this.label_Feliratkozom.Text = "Feliratkozom:";
            // 
            // Textbox_nev
            // 
            this.Textbox_nev.Location = new System.Drawing.Point(133, 47);
            this.Textbox_nev.Name = "Textbox_nev";
            this.Textbox_nev.Size = new System.Drawing.Size(176, 20);
            this.Textbox_nev.TabIndex = 4;
            this.Textbox_nev.Click += new System.EventHandler(this.Csak_betuket_enged);
            // 
            // dateTimePicker_Szuletesi_Datum
            // 
            this.dateTimePicker_Szuletesi_Datum.Location = new System.Drawing.Point(134, 89);
            this.dateTimePicker_Szuletesi_Datum.Name = "dateTimePicker_Szuletesi_Datum";
            this.dateTimePicker_Szuletesi_Datum.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker_Szuletesi_Datum.TabIndex = 5;
            this.dateTimePicker_Szuletesi_Datum.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // radioButton_Ferfi
            // 
            this.radioButton_Ferfi.AutoSize = true;
            this.radioButton_Ferfi.Location = new System.Drawing.Point(133, 133);
            this.radioButton_Ferfi.Name = "radioButton_Ferfi";
            this.radioButton_Ferfi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_Ferfi.Size = new System.Drawing.Size(31, 17);
            this.radioButton_Ferfi.TabIndex = 6;
            this.radioButton_Ferfi.TabStop = true;
            this.radioButton_Ferfi.Tag = "Ferfi";
            this.radioButton_Ferfi.Text = "F";
            this.radioButton_Ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(233, 133);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_No.Size = new System.Drawing.Size(33, 17);
            this.radioButton_No.TabIndex = 7;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Tag = "No";
            this.radioButton_No.Text = "N";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Tag = "igen";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_Hobbik
            // 
            this.label_Hobbik.AutoSize = true;
            this.label_Hobbik.Location = new System.Drawing.Point(461, 23);
            this.label_Hobbik.Name = "label_Hobbik";
            this.label_Hobbik.Size = new System.Drawing.Size(44, 13);
            this.label_Hobbik.TabIndex = 9;
            this.label_Hobbik.Tag = "Hobbik";
            this.label_Hobbik.Text = "Hobbik:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(462, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 199);
            this.listBox1.TabIndex = 10;
            // 
            // textBox_UjHobbi
            // 
            this.textBox_UjHobbi.Location = new System.Drawing.Point(462, 274);
            this.textBox_UjHobbi.Name = "textBox_UjHobbi";
            this.textBox_UjHobbi.Size = new System.Drawing.Size(199, 20);
            this.textBox_UjHobbi.TabIndex = 11;
            this.textBox_UjHobbi.Tag = "UjHobbi";
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(133, 375);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(174, 31);
            this.button_Mentes.TabIndex = 12;
            this.button_Mentes.Tag = "Mentes";
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            // 
            // button_Hozzaad
            // 
            this.button_Hozzaad.Location = new System.Drawing.Point(462, 323);
            this.button_Hozzaad.Name = "button_Hozzaad";
            this.button_Hozzaad.Size = new System.Drawing.Size(199, 31);
            this.button_Hozzaad.TabIndex = 13;
            this.button_Hozzaad.Tag = "Hozzaad";
            this.button_Hozzaad.Text = "Hozzáad";
            this.button_Hozzaad.UseVisualStyleBackColor = true;
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.Location = new System.Drawing.Point(462, 375);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(199, 31);
            this.button_Betoltes.TabIndex = 14;
            this.button_Betoltes.Tag = "Betoltes";
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.button_Hozzaad);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.textBox_UjHobbi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_Hobbik);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton_No);
            this.Controls.Add(this.radioButton_Ferfi);
            this.Controls.Add(this.dateTimePicker_Szuletesi_Datum);
            this.Controls.Add(this.Textbox_nev);
            this.Controls.Add(this.label_Feliratkozom);
            this.Controls.Add(this.label_Nem);
            this.Controls.Add(this.label_Szuleteslabel_Szuletes);
            this.Controls.Add(this.label_Nev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.Label label_Szuleteslabel_Szuletes;
        private System.Windows.Forms.Label label_Nem;
        private System.Windows.Forms.Label label_Feliratkozom;
        private System.Windows.Forms.TextBox Textbox_nev;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletesi_Datum;
        private System.Windows.Forms.RadioButton radioButton_Ferfi;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_Hobbik;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_UjHobbi;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Button button_Hozzaad;
        private System.Windows.Forms.Button button_Betoltes;
    }
}

