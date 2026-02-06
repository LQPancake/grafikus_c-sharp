namespace grafika2
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
            this.checkboxKavekrem = new System.Windows.Forms.CheckBox();
            this.checkboxTejszin = new System.Windows.Forms.CheckBox();
            this.checkboxTejpor = new System.Windows.Forms.CheckBox();
            this.espresso = new System.Windows.Forms.RadioButton();
            this.duplaKave = new System.Windows.Forms.RadioButton();
            this.hosszuKave = new System.Windows.Forms.RadioButton();
            this.cukorSok = new System.Windows.Forms.RadioButton();
            this.cukorKeves = new System.Windows.Forms.RadioButton();
            this.cukorMentes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tea = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonFizetes = new System.Windows.Forms.Button();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.checkboxCitrom = new System.Windows.Forms.CheckBox();
            this.hozzavalok = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOsszesenAr = new System.Windows.Forms.TextBox();
            this.textBoxCukorAr = new System.Windows.Forms.TextBox();
            this.textBoxHozzavaloAr = new System.Windows.Forms.TextBox();
            this.textBoxItalAr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonBankkartya = new System.Windows.Forms.Button();
            this.ButtonKp = new System.Windows.Forms.Button();
            this.textBoxEgyenleg = new System.Windows.Forms.TextBox();
            this.buttonPenzBedob = new System.Windows.Forms.Button();
            this.groupBoxKpFizet = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.hozzavalok.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxKpFizet.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkboxKavekrem
            // 
            this.checkboxKavekrem.AutoSize = true;
            this.checkboxKavekrem.Location = new System.Drawing.Point(13, 13);
            this.checkboxKavekrem.Name = "checkboxKavekrem";
            this.checkboxKavekrem.Size = new System.Drawing.Size(73, 17);
            this.checkboxKavekrem.TabIndex = 0;
            this.checkboxKavekrem.Text = "kávékrém";
            this.checkboxKavekrem.UseVisualStyleBackColor = true;
            this.checkboxKavekrem.CheckedChanged += new System.EventHandler(this.checkboxKavekrem_CheckedChanged);
            // 
            // checkboxTejszin
            // 
            this.checkboxTejszin.AutoSize = true;
            this.checkboxTejszin.Location = new System.Drawing.Point(13, 36);
            this.checkboxTejszin.Name = "checkboxTejszin";
            this.checkboxTejszin.Size = new System.Drawing.Size(57, 17);
            this.checkboxTejszin.TabIndex = 1;
            this.checkboxTejszin.Text = "tejszín";
            this.checkboxTejszin.UseVisualStyleBackColor = true;
            this.checkboxTejszin.CheckedChanged += new System.EventHandler(this.checkboxTejszin_CheckedChanged);
            // 
            // checkboxTejpor
            // 
            this.checkboxTejpor.AutoSize = true;
            this.checkboxTejpor.Location = new System.Drawing.Point(13, 59);
            this.checkboxTejpor.Name = "checkboxTejpor";
            this.checkboxTejpor.Size = new System.Drawing.Size(52, 17);
            this.checkboxTejpor.TabIndex = 2;
            this.checkboxTejpor.Text = "tejpor";
            this.checkboxTejpor.UseVisualStyleBackColor = true;
            this.checkboxTejpor.CheckedChanged += new System.EventHandler(this.checkboxTejpor_CheckedChanged);
            // 
            // espresso
            // 
            this.espresso.AutoSize = true;
            this.espresso.Location = new System.Drawing.Point(14, 14);
            this.espresso.Name = "espresso";
            this.espresso.Size = new System.Drawing.Size(67, 17);
            this.espresso.TabIndex = 3;
            this.espresso.TabStop = true;
            this.espresso.Text = "espresso";
            this.espresso.UseVisualStyleBackColor = true;
            this.espresso.CheckedChanged += new System.EventHandler(this.espresso_CheckedChanged);
            // 
            // duplaKave
            // 
            this.duplaKave.AutoSize = true;
            this.duplaKave.Location = new System.Drawing.Point(14, 38);
            this.duplaKave.Name = "duplaKave";
            this.duplaKave.Size = new System.Drawing.Size(78, 17);
            this.duplaKave.TabIndex = 4;
            this.duplaKave.TabStop = true;
            this.duplaKave.Text = "dupla kávé";
            this.duplaKave.UseVisualStyleBackColor = true;
            this.duplaKave.CheckedChanged += new System.EventHandler(this.duplaKave_CheckedChanged);
            // 
            // hosszuKave
            // 
            this.hosszuKave.AutoSize = true;
            this.hosszuKave.Location = new System.Drawing.Point(14, 60);
            this.hosszuKave.Name = "hosszuKave";
            this.hosszuKave.Size = new System.Drawing.Size(85, 17);
            this.hosszuKave.TabIndex = 5;
            this.hosszuKave.TabStop = true;
            this.hosszuKave.Text = "hosszú kávé";
            this.hosszuKave.UseVisualStyleBackColor = true;
            this.hosszuKave.CheckedChanged += new System.EventHandler(this.hosszuKave_CheckedChanged);
            // 
            // cukorSok
            // 
            this.cukorSok.AutoSize = true;
            this.cukorSok.Location = new System.Drawing.Point(24, 14);
            this.cukorSok.Name = "cukorSok";
            this.cukorSok.Size = new System.Drawing.Size(72, 17);
            this.cukorSok.TabIndex = 6;
            this.cukorSok.Text = "sok cukor";
            this.cukorSok.UseVisualStyleBackColor = true;
            this.cukorSok.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cukorKeves
            // 
            this.cukorKeves.AutoSize = true;
            this.cukorKeves.Location = new System.Drawing.Point(24, 37);
            this.cukorKeves.Name = "cukorKeves";
            this.cukorKeves.Size = new System.Drawing.Size(84, 17);
            this.cukorKeves.TabIndex = 7;
            this.cukorKeves.Text = "kevés cukor";
            this.cukorKeves.UseVisualStyleBackColor = true;
            this.cukorKeves.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cukorMentes
            // 
            this.cukorMentes.AutoSize = true;
            this.cukorMentes.Location = new System.Drawing.Point(24, 60);
            this.cukorMentes.Name = "cukorMentes";
            this.cukorMentes.Size = new System.Drawing.Size(83, 17);
            this.cukorMentes.TabIndex = 8;
            this.cukorMentes.Text = "cukor nélkül";
            this.cukorMentes.UseVisualStyleBackColor = true;
            this.cukorMentes.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tea);
            this.groupBox1.Controls.Add(this.hosszuKave);
            this.groupBox1.Controls.Add(this.duplaKave);
            this.groupBox1.Controls.Add(this.espresso);
            this.groupBox1.Location = new System.Drawing.Point(278, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kávéféleségek";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tea
            // 
            this.tea.AutoSize = true;
            this.tea.Location = new System.Drawing.Point(14, 83);
            this.tea.Name = "tea";
            this.tea.Size = new System.Drawing.Size(40, 17);
            this.tea.TabIndex = 6;
            this.tea.TabStop = true;
            this.tea.Text = "tea";
            this.tea.UseVisualStyleBackColor = true;
            this.tea.CheckedChanged += new System.EventHandler(this.tea_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cukorMentes);
            this.groupBox2.Controls.Add(this.cukorKeves);
            this.groupBox2.Controls.Add(this.cukorSok);
            this.groupBox2.Location = new System.Drawing.Point(78, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 106);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cukor";
            // 
            // ButtonFizetes
            // 
            this.ButtonFizetes.Location = new System.Drawing.Point(78, 258);
            this.ButtonFizetes.Name = "ButtonFizetes";
            this.ButtonFizetes.Size = new System.Drawing.Size(152, 38);
            this.ButtonFizetes.TabIndex = 11;
            this.ButtonFizetes.Text = "Fizetés";
            this.ButtonFizetes.UseVisualStyleBackColor = true;
            this.ButtonFizetes.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Location = new System.Drawing.Point(14, 40);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(83, 13);
            this.labelEredmeny.TabIndex = 12;
            this.labelEredmeny.Text = "Nincs eredmény";
            this.labelEredmeny.Click += new System.EventHandler(this.labelEredmeny_Click);
            // 
            // checkboxCitrom
            // 
            this.checkboxCitrom.AutoSize = true;
            this.checkboxCitrom.Enabled = false;
            this.checkboxCitrom.Location = new System.Drawing.Point(13, 82);
            this.checkboxCitrom.Name = "checkboxCitrom";
            this.checkboxCitrom.Size = new System.Drawing.Size(55, 17);
            this.checkboxCitrom.TabIndex = 13;
            this.checkboxCitrom.Text = "Citrom";
            this.checkboxCitrom.UseVisualStyleBackColor = true;
            this.checkboxCitrom.CheckedChanged += new System.EventHandler(this.checkboxCitrom_CheckedChanged);
            // 
            // hozzavalok
            // 
            this.hozzavalok.Controls.Add(this.checkboxCitrom);
            this.hozzavalok.Controls.Add(this.checkboxTejpor);
            this.hozzavalok.Controls.Add(this.checkboxTejszin);
            this.hozzavalok.Controls.Add(this.checkboxKavekrem);
            this.hozzavalok.Location = new System.Drawing.Point(78, 21);
            this.hozzavalok.Name = "hozzavalok";
            this.hozzavalok.Size = new System.Drawing.Size(125, 119);
            this.hozzavalok.TabIndex = 14;
            this.hozzavalok.TabStop = false;
            this.hozzavalok.Text = "Hozzávalók";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOsszesenAr);
            this.groupBox3.Controls.Add(this.textBoxCukorAr);
            this.groupBox3.Controls.Add(this.textBoxHozzavaloAr);
            this.groupBox3.Controls.Add(this.textBoxItalAr);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(278, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 106);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fizetés";
            // 
            // textBoxOsszesenAr
            // 
            this.textBoxOsszesenAr.Location = new System.Drawing.Point(68, 86);
            this.textBoxOsszesenAr.Name = "textBoxOsszesenAr";
            this.textBoxOsszesenAr.ReadOnly = true;
            this.textBoxOsszesenAr.Size = new System.Drawing.Size(53, 20);
            this.textBoxOsszesenAr.TabIndex = 6;
            // 
            // textBoxCukorAr
            // 
            this.textBoxCukorAr.Location = new System.Drawing.Point(67, 64);
            this.textBoxCukorAr.Name = "textBoxCukorAr";
            this.textBoxCukorAr.ReadOnly = true;
            this.textBoxCukorAr.Size = new System.Drawing.Size(53, 20);
            this.textBoxCukorAr.TabIndex = 5;
            // 
            // textBoxHozzavaloAr
            // 
            this.textBoxHozzavaloAr.Location = new System.Drawing.Point(67, 39);
            this.textBoxHozzavaloAr.Name = "textBoxHozzavaloAr";
            this.textBoxHozzavaloAr.ReadOnly = true;
            this.textBoxHozzavaloAr.Size = new System.Drawing.Size(53, 20);
            this.textBoxHozzavaloAr.TabIndex = 4;
            // 
            // textBoxItalAr
            // 
            this.textBoxItalAr.Location = new System.Drawing.Point(67, 16);
            this.textBoxItalAr.Name = "textBoxItalAr";
            this.textBoxItalAr.ReadOnly = true;
            this.textBoxItalAr.Size = new System.Drawing.Size(53, 20);
            this.textBoxItalAr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Összesen:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cukor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ital:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hozzávaló:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ButtonBankkartya
            // 
            this.ButtonBankkartya.Location = new System.Drawing.Point(246, 258);
            this.ButtonBankkartya.Name = "ButtonBankkartya";
            this.ButtonBankkartya.Size = new System.Drawing.Size(86, 38);
            this.ButtonBankkartya.TabIndex = 16;
            this.ButtonBankkartya.Text = "Bankkártya";
            this.ButtonBankkartya.UseVisualStyleBackColor = true;
            this.ButtonBankkartya.Visible = false;
            this.ButtonBankkartya.Click += new System.EventHandler(this.ButtonBankkartya_Click);
            // 
            // ButtonKp
            // 
            this.ButtonKp.Location = new System.Drawing.Point(328, 258);
            this.ButtonKp.Name = "ButtonKp";
            this.ButtonKp.Size = new System.Drawing.Size(86, 38);
            this.ButtonKp.TabIndex = 17;
            this.ButtonKp.Text = "Készpénz";
            this.ButtonKp.UseVisualStyleBackColor = true;
            this.ButtonKp.Visible = false;
            this.ButtonKp.Click += new System.EventHandler(this.ButtonKp_Click);
            // 
            // textBoxEgyenleg
            // 
            this.textBoxEgyenleg.Location = new System.Drawing.Point(17, 17);
            this.textBoxEgyenleg.Name = "textBoxEgyenleg";
            this.textBoxEgyenleg.Size = new System.Drawing.Size(82, 20);
            this.textBoxEgyenleg.TabIndex = 19;
            // 
            // buttonPenzBedob
            // 
            this.buttonPenzBedob.Location = new System.Drawing.Point(105, 17);
            this.buttonPenzBedob.Name = "buttonPenzBedob";
            this.buttonPenzBedob.Size = new System.Drawing.Size(75, 23);
            this.buttonPenzBedob.TabIndex = 20;
            this.buttonPenzBedob.Text = "Bedob";
            this.buttonPenzBedob.UseVisualStyleBackColor = true;
            this.buttonPenzBedob.Click += new System.EventHandler(this.buttonPenzBedob_Click);
            // 
            // groupBoxKpFizet
            // 
            this.groupBoxKpFizet.Controls.Add(this.buttonPenzBedob);
            this.groupBoxKpFizet.Controls.Add(this.textBoxEgyenleg);
            this.groupBoxKpFizet.Controls.Add(this.labelEredmeny);
            this.groupBoxKpFizet.Location = new System.Drawing.Point(227, 302);
            this.groupBoxKpFizet.Name = "groupBoxKpFizet";
            this.groupBoxKpFizet.Size = new System.Drawing.Size(198, 59);
            this.groupBoxKpFizet.TabIndex = 21;
            this.groupBoxKpFizet.TabStop = false;
            this.groupBoxKpFizet.Text = "KP Fizetés";
            this.groupBoxKpFizet.Visible = false;
            this.groupBoxKpFizet.Enter += new System.EventHandler(this.groupBoxKpFizet_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 359);
            this.Controls.Add(this.groupBoxKpFizet);
            this.Controls.Add(this.ButtonKp);
            this.Controls.Add(this.ButtonBankkartya);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.hozzavalok);
            this.Controls.Add(this.ButtonFizetes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ital automata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.hozzavalok.ResumeLayout(false);
            this.hozzavalok.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxKpFizet.ResumeLayout(false);
            this.groupBoxKpFizet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxKavekrem;
        private System.Windows.Forms.CheckBox checkboxTejszin;
        private System.Windows.Forms.CheckBox checkboxTejpor;
        private System.Windows.Forms.RadioButton espresso;
        private System.Windows.Forms.RadioButton duplaKave;
        private System.Windows.Forms.RadioButton hosszuKave;
        private System.Windows.Forms.RadioButton cukorSok;
        private System.Windows.Forms.RadioButton cukorKeves;
        private System.Windows.Forms.RadioButton cukorMentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonFizetes;
        private System.Windows.Forms.Label labelEredmeny;
        private System.Windows.Forms.CheckBox checkboxCitrom;
        private System.Windows.Forms.GroupBox hozzavalok;
        private System.Windows.Forms.RadioButton tea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOsszesenAr;
        private System.Windows.Forms.TextBox textBoxCukorAr;
        private System.Windows.Forms.TextBox textBoxHozzavaloAr;
        private System.Windows.Forms.TextBox textBoxItalAr;
        private System.Windows.Forms.Button ButtonBankkartya;
        private System.Windows.Forms.Button ButtonKp;
        private System.Windows.Forms.TextBox textBoxEgyenleg;
        private System.Windows.Forms.Button buttonPenzBedob;
        private System.Windows.Forms.GroupBox groupBoxKpFizet;
    }
}

