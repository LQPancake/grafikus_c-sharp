namespace grafika1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SzamInput1 = new System.Windows.Forms.TextBox();
            this.SzamInput2 = new System.Windows.Forms.TextBox();
            this.Szam1 = new System.Windows.Forms.Label();
            this.Szam2 = new System.Windows.Forms.Label();
            this.Szoroz = new System.Windows.Forms.Button();
            this.Osszead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Eredmeny = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SzamInput1
            // 
            this.SzamInput1.BackColor = System.Drawing.Color.White;
            this.SzamInput1.Location = new System.Drawing.Point(314, 189);
            this.SzamInput1.Name = "SzamInput1";
            this.SzamInput1.Size = new System.Drawing.Size(100, 20);
            this.SzamInput1.TabIndex = 0;
            this.SzamInput1.TextChanged += new System.EventHandler(this.SzamInput1_TextChanged);
            // 
            // SzamInput2
            // 
            this.SzamInput2.Location = new System.Drawing.Point(314, 245);
            this.SzamInput2.Name = "SzamInput2";
            this.SzamInput2.Size = new System.Drawing.Size(100, 20);
            this.SzamInput2.TabIndex = 1;
            this.SzamInput2.TextChanged += new System.EventHandler(this.SzamInput2_TextChanged);
            // 
            // Szam1
            // 
            this.Szam1.AutoSize = true;
            this.Szam1.Location = new System.Drawing.Point(273, 196);
            this.Szam1.Name = "Szam1";
            this.Szam1.Size = new System.Drawing.Size(39, 13);
            this.Szam1.TabIndex = 2;
            this.Szam1.Text = "Szam1";
            this.Szam1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Szam2
            // 
            this.Szam2.AutoSize = true;
            this.Szam2.Location = new System.Drawing.Point(273, 248);
            this.Szam2.Name = "Szam2";
            this.Szam2.Size = new System.Drawing.Size(39, 13);
            this.Szam2.TabIndex = 3;
            this.Szam2.Text = "Szam2";
            // 
            // Szoroz
            // 
            this.Szoroz.Location = new System.Drawing.Point(266, 216);
            this.Szoroz.Name = "Szoroz";
            this.Szoroz.Size = new System.Drawing.Size(75, 23);
            this.Szoroz.TabIndex = 4;
            this.Szoroz.Text = "Szorzás";
            this.Szoroz.UseVisualStyleBackColor = true;
            this.Szoroz.Click += new System.EventHandler(this.Szoroz_Click);
            // 
            // Osszead
            // 
            this.Osszead.Location = new System.Drawing.Point(347, 216);
            this.Osszead.Name = "Osszead";
            this.Osszead.Size = new System.Drawing.Size(75, 23);
            this.Osszead.TabIndex = 5;
            this.Osszead.Text = "Összeadás";
            this.Osszead.UseVisualStyleBackColor = true;
            this.Osszead.Click += new System.EventHandler(this.Osszead_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(177, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nagyon menci számológép:)";
            // 
            // Eredmeny
            // 
            this.Eredmeny.BackColor = System.Drawing.Color.White;
            this.Eredmeny.Location = new System.Drawing.Point(455, 222);
            this.Eredmeny.Name = "Eredmeny";
            this.Eredmeny.ReadOnly = true;
            this.Eredmeny.Size = new System.Drawing.Size(49, 20);
            this.Eredmeny.TabIndex = 9;
            this.Eredmeny.TextChanged += new System.EventHandler(this.Eredmeny_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(607, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(765, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(827, 468);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 468);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Eredmeny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Osszead);
            this.Controls.Add(this.Szoroz);
            this.Controls.Add(this.Szam2);
            this.Controls.Add(this.Szam1);
            this.Controls.Add(this.SzamInput2);
            this.Controls.Add(this.SzamInput1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "elso grafikus progi";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SzamInput1;
        private System.Windows.Forms.TextBox SzamInput2;
        private System.Windows.Forms.Label Szam1;
        private System.Windows.Forms.Label Szam2;
        private System.Windows.Forms.Button Szoroz;
        private System.Windows.Forms.Button Osszead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox Eredmeny;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

