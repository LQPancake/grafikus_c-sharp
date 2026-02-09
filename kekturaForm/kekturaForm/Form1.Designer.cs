namespace kekturaForm
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
            this.listBoxUtvonalLista = new System.Windows.Forms.ListBox();
            this.labelDarabszam = new System.Windows.Forms.Label();
            this.buttonAdatok = new System.Windows.Forms.Button();
            this.labelKiindulopont = new System.Windows.Forms.Label();
            this.labelVegpont = new System.Windows.Forms.Label();
            this.labelSzakaszHossz = new System.Windows.Forms.Label();
            this.labelEmelkedes = new System.Windows.Forms.Label();
            this.labelLejtes = new System.Windows.Forms.Label();
            this.textBoxKiindulopont = new System.Windows.Forms.TextBox();
            this.textBoxVegpont = new System.Windows.Forms.TextBox();
            this.textBoxSzakaszhossz = new System.Windows.Forms.TextBox();
            this.textBoxEmelkedes = new System.Windows.Forms.TextBox();
            this.textBoxLejtes = new System.Windows.Forms.TextBox();
            this.checkBoxPecsetelohely = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxUtvonalLista
            // 
            this.listBoxUtvonalLista.FormattingEnabled = true;
            this.listBoxUtvonalLista.Location = new System.Drawing.Point(42, 40);
            this.listBoxUtvonalLista.Name = "listBoxUtvonalLista";
            this.listBoxUtvonalLista.Size = new System.Drawing.Size(392, 134);
            this.listBoxUtvonalLista.TabIndex = 0;
            this.listBoxUtvonalLista.SelectedIndexChanged += new System.EventHandler(this.listBoxUtvonalLista_SelectedIndexChanged);
            // 
            // labelDarabszam
            // 
            this.labelDarabszam.AutoSize = true;
            this.labelDarabszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDarabszam.Location = new System.Drawing.Point(402, 177);
            this.labelDarabszam.Name = "labelDarabszam";
            this.labelDarabszam.Size = new System.Drawing.Size(32, 13);
            this.labelDarabszam.TabIndex = 1;
            this.labelDarabszam.Text = "0 db";
            this.labelDarabszam.Click += new System.EventHandler(this.labelDarabszam_Click);
            // 
            // buttonAdatok
            // 
            this.buttonAdatok.Location = new System.Drawing.Point(501, 40);
            this.buttonAdatok.Name = "buttonAdatok";
            this.buttonAdatok.Size = new System.Drawing.Size(141, 37);
            this.buttonAdatok.TabIndex = 2;
            this.buttonAdatok.Text = "Adatok megjelenítése";
            this.buttonAdatok.UseVisualStyleBackColor = true;
            this.buttonAdatok.Click += new System.EventHandler(this.buttonAdatok_Click);
            // 
            // labelKiindulopont
            // 
            this.labelKiindulopont.AutoSize = true;
            this.labelKiindulopont.Location = new System.Drawing.Point(39, 188);
            this.labelKiindulopont.Name = "labelKiindulopont";
            this.labelKiindulopont.Size = new System.Drawing.Size(68, 13);
            this.labelKiindulopont.TabIndex = 3;
            this.labelKiindulopont.Text = "Kiinduló pont";
            // 
            // labelVegpont
            // 
            this.labelVegpont.AutoSize = true;
            this.labelVegpont.Location = new System.Drawing.Point(39, 213);
            this.labelVegpont.Name = "labelVegpont";
            this.labelVegpont.Size = new System.Drawing.Size(47, 13);
            this.labelVegpont.TabIndex = 4;
            this.labelVegpont.Text = "Végpont";
            // 
            // labelSzakaszHossz
            // 
            this.labelSzakaszHossz.AutoSize = true;
            this.labelSzakaszHossz.Location = new System.Drawing.Point(39, 240);
            this.labelSzakaszHossz.Name = "labelSzakaszHossz";
            this.labelSzakaszHossz.Size = new System.Drawing.Size(100, 13);
            this.labelSzakaszHossz.TabIndex = 5;
            this.labelSzakaszHossz.Text = "Szakasz hossz (km)";
            // 
            // labelEmelkedes
            // 
            this.labelEmelkedes.AutoSize = true;
            this.labelEmelkedes.Location = new System.Drawing.Point(39, 263);
            this.labelEmelkedes.Name = "labelEmelkedes";
            this.labelEmelkedes.Size = new System.Drawing.Size(59, 13);
            this.labelEmelkedes.TabIndex = 6;
            this.labelEmelkedes.Text = "Emelkedés";
            // 
            // labelLejtes
            // 
            this.labelLejtes.AutoSize = true;
            this.labelLejtes.Location = new System.Drawing.Point(39, 287);
            this.labelLejtes.Name = "labelLejtes";
            this.labelLejtes.Size = new System.Drawing.Size(35, 13);
            this.labelLejtes.TabIndex = 7;
            this.labelLejtes.Text = "Lejtés";
            // 
            // textBoxKiindulopont
            // 
            this.textBoxKiindulopont.Location = new System.Drawing.Point(113, 185);
            this.textBoxKiindulopont.Name = "textBoxKiindulopont";
            this.textBoxKiindulopont.ReadOnly = true;
            this.textBoxKiindulopont.Size = new System.Drawing.Size(245, 20);
            this.textBoxKiindulopont.TabIndex = 9;
            // 
            // textBoxVegpont
            // 
            this.textBoxVegpont.Location = new System.Drawing.Point(92, 211);
            this.textBoxVegpont.Name = "textBoxVegpont";
            this.textBoxVegpont.ReadOnly = true;
            this.textBoxVegpont.Size = new System.Drawing.Size(180, 20);
            this.textBoxVegpont.TabIndex = 10;
            // 
            // textBoxSzakaszhossz
            // 
            this.textBoxSzakaszhossz.Location = new System.Drawing.Point(145, 240);
            this.textBoxSzakaszhossz.Name = "textBoxSzakaszhossz";
            this.textBoxSzakaszhossz.ReadOnly = true;
            this.textBoxSzakaszhossz.Size = new System.Drawing.Size(72, 20);
            this.textBoxSzakaszhossz.TabIndex = 11;
            // 
            // textBoxEmelkedes
            // 
            this.textBoxEmelkedes.Location = new System.Drawing.Point(104, 260);
            this.textBoxEmelkedes.Name = "textBoxEmelkedes";
            this.textBoxEmelkedes.ReadOnly = true;
            this.textBoxEmelkedes.Size = new System.Drawing.Size(96, 20);
            this.textBoxEmelkedes.TabIndex = 12;
            // 
            // textBoxLejtes
            // 
            this.textBoxLejtes.Location = new System.Drawing.Point(80, 284);
            this.textBoxLejtes.Name = "textBoxLejtes";
            this.textBoxLejtes.ReadOnly = true;
            this.textBoxLejtes.Size = new System.Drawing.Size(95, 20);
            this.textBoxLejtes.TabIndex = 13;
            // 
            // checkBoxPecsetelohely
            // 
            this.checkBoxPecsetelohely.AutoSize = true;
            this.checkBoxPecsetelohely.Enabled = false;
            this.checkBoxPecsetelohely.Location = new System.Drawing.Point(42, 310);
            this.checkBoxPecsetelohely.Name = "checkBoxPecsetelohely";
            this.checkBoxPecsetelohely.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxPecsetelohely.Size = new System.Drawing.Size(92, 17);
            this.checkBoxPecsetelohely.TabIndex = 14;
            this.checkBoxPecsetelohely.Text = "Pecsételőhely";
            this.checkBoxPecsetelohely.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxPecsetelohely);
            this.Controls.Add(this.textBoxLejtes);
            this.Controls.Add(this.textBoxEmelkedes);
            this.Controls.Add(this.textBoxSzakaszhossz);
            this.Controls.Add(this.textBoxVegpont);
            this.Controls.Add(this.textBoxKiindulopont);
            this.Controls.Add(this.labelLejtes);
            this.Controls.Add(this.labelEmelkedes);
            this.Controls.Add(this.labelSzakaszHossz);
            this.Controls.Add(this.labelVegpont);
            this.Controls.Add(this.labelKiindulopont);
            this.Controls.Add(this.buttonAdatok);
            this.Controls.Add(this.labelDarabszam);
            this.Controls.Add(this.listBoxUtvonalLista);
            this.Name = "Form1";
            this.Text = "Kéktúra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUtvonalLista;
        private System.Windows.Forms.Label labelDarabszam;
        private System.Windows.Forms.Button buttonAdatok;
        private System.Windows.Forms.Label labelKiindulopont;
        private System.Windows.Forms.Label labelVegpont;
        private System.Windows.Forms.Label labelSzakaszHossz;
        private System.Windows.Forms.Label labelEmelkedes;
        private System.Windows.Forms.Label labelLejtes;
        private System.Windows.Forms.TextBox textBoxKiindulopont;
        private System.Windows.Forms.TextBox textBoxVegpont;
        private System.Windows.Forms.TextBox textBoxSzakaszhossz;
        private System.Windows.Forms.TextBox textBoxEmelkedes;
        private System.Windows.Forms.TextBox textBoxLejtes;
        private System.Windows.Forms.CheckBox checkBoxPecsetelohely;
    }
}

