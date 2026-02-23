namespace blackjack
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
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.labelEgyenleg = new System.Windows.Forms.Label();
            this.textBoxEgyenleg = new System.Windows.Forms.TextBox();
            this.textBoxKartyak = new System.Windows.Forms.TextBox();
            this.buttonPenzFeltolt = new System.Windows.Forms.Button();
            this.textBoxPenzFeltolt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxBlackjack = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxTetOpciok = new System.Windows.Forms.GroupBox();
            this.buttonNagyTet = new System.Windows.Forms.Button();
            this.buttonAlapTet = new System.Windows.Forms.Button();
            this.buttonMinTet = new System.Windows.Forms.Button();
            this.groupBoxBlackjack.SuspendLayout();
            this.groupBoxTetOpciok.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(175, 216);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(116, 43);
            this.buttonHit.TabIndex = 0;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            // 
            // buttonStand
            // 
            this.buttonStand.Location = new System.Drawing.Point(326, 218);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(114, 39);
            this.buttonStand.TabIndex = 1;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = true;
            // 
            // labelEgyenleg
            // 
            this.labelEgyenleg.AutoSize = true;
            this.labelEgyenleg.BackColor = System.Drawing.Color.Transparent;
            this.labelEgyenleg.ForeColor = System.Drawing.Color.White;
            this.labelEgyenleg.Location = new System.Drawing.Point(247, 384);
            this.labelEgyenleg.Name = "labelEgyenleg";
            this.labelEgyenleg.Size = new System.Drawing.Size(54, 13);
            this.labelEgyenleg.TabIndex = 2;
            this.labelEgyenleg.Text = "Egyenleg:";
            // 
            // textBoxEgyenleg
            // 
            this.textBoxEgyenleg.Location = new System.Drawing.Point(298, 381);
            this.textBoxEgyenleg.Name = "textBoxEgyenleg";
            this.textBoxEgyenleg.ReadOnly = true;
            this.textBoxEgyenleg.Size = new System.Drawing.Size(72, 20);
            this.textBoxEgyenleg.TabIndex = 3;
            this.textBoxEgyenleg.TextChanged += new System.EventHandler(this.textBoxEgyenleg_TextChanged_1);
            // 
            // textBoxKartyak
            // 
            this.textBoxKartyak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKartyak.Location = new System.Drawing.Point(222, 181);
            this.textBoxKartyak.Name = "textBoxKartyak";
            this.textBoxKartyak.ReadOnly = true;
            this.textBoxKartyak.Size = new System.Drawing.Size(178, 31);
            this.textBoxKartyak.TabIndex = 4;
            // 
            // buttonPenzFeltolt
            // 
            this.buttonPenzFeltolt.Location = new System.Drawing.Point(223, 419);
            this.buttonPenzFeltolt.Name = "buttonPenzFeltolt";
            this.buttonPenzFeltolt.Size = new System.Drawing.Size(72, 20);
            this.buttonPenzFeltolt.TabIndex = 5;
            this.buttonPenzFeltolt.Text = "Feltöltés";
            this.buttonPenzFeltolt.UseVisualStyleBackColor = true;
            this.buttonPenzFeltolt.Visible = false;
            // 
            // textBoxPenzFeltolt
            // 
            this.textBoxPenzFeltolt.Location = new System.Drawing.Point(298, 419);
            this.textBoxPenzFeltolt.Name = "textBoxPenzFeltolt";
            this.textBoxPenzFeltolt.Size = new System.Drawing.Size(85, 20);
            this.textBoxPenzFeltolt.TabIndex = 6;
            this.textBoxPenzFeltolt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A = 1/11";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "K,Q, J = 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Értékek";
            // 
            // groupBoxBlackjack
            // 
            this.groupBoxBlackjack.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBlackjack.Controls.Add(this.label8);
            this.groupBoxBlackjack.Controls.Add(this.label6);
            this.groupBoxBlackjack.Controls.Add(this.label7);
            this.groupBoxBlackjack.Controls.Add(this.label5);
            this.groupBoxBlackjack.Controls.Add(this.label3);
            this.groupBoxBlackjack.Controls.Add(this.label2);
            this.groupBoxBlackjack.Controls.Add(this.label1);
            this.groupBoxBlackjack.Controls.Add(this.textBoxKartyak);
            this.groupBoxBlackjack.Controls.Add(this.buttonStand);
            this.groupBoxBlackjack.Controls.Add(this.buttonHit);
            this.groupBoxBlackjack.Location = new System.Drawing.Point(4, 12);
            this.groupBoxBlackjack.Name = "groupBoxBlackjack";
            this.groupBoxBlackjack.Size = new System.Drawing.Size(665, 275);
            this.groupBoxBlackjack.TabIndex = 10;
            this.groupBoxBlackjack.TabStop = false;
            this.groupBoxBlackjack.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Döntetlen: tét visszajár";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blackjack: 2.5x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Normál nyereség: 2x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kifizetések";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(250, 293);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(122, 43);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Játék indítása";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxTetOpciok
            // 
            this.groupBoxTetOpciok.Controls.Add(this.buttonNagyTet);
            this.groupBoxTetOpciok.Controls.Add(this.buttonAlapTet);
            this.groupBoxTetOpciok.Controls.Add(this.buttonMinTet);
            this.groupBoxTetOpciok.Location = new System.Drawing.Point(413, 320);
            this.groupBoxTetOpciok.Name = "groupBoxTetOpciok";
            this.groupBoxTetOpciok.Size = new System.Drawing.Size(256, 112);
            this.groupBoxTetOpciok.TabIndex = 13;
            this.groupBoxTetOpciok.TabStop = false;
            // 
            // buttonNagyTet
            // 
            this.buttonNagyTet.Location = new System.Drawing.Point(70, 68);
            this.buttonNagyTet.Name = "buttonNagyTet";
            this.buttonNagyTet.Size = new System.Drawing.Size(102, 41);
            this.buttonNagyTet.TabIndex = 2;
            this.buttonNagyTet.Text = "Nagy tét (10000Ft)";
            this.buttonNagyTet.UseVisualStyleBackColor = true;
            this.buttonNagyTet.Click += new System.EventHandler(this.buttonNagyTet_Click);
            // 
            // buttonAlapTet
            // 
            this.buttonAlapTet.Location = new System.Drawing.Point(128, 19);
            this.buttonAlapTet.Name = "buttonAlapTet";
            this.buttonAlapTet.Size = new System.Drawing.Size(102, 43);
            this.buttonAlapTet.TabIndex = 1;
            this.buttonAlapTet.Text = "Alap tét (5000 Ft)";
            this.buttonAlapTet.UseVisualStyleBackColor = true;
            this.buttonAlapTet.Click += new System.EventHandler(this.buttonAlapTet_Click);
            // 
            // buttonMinTet
            // 
            this.buttonMinTet.Location = new System.Drawing.Point(20, 19);
            this.buttonMinTet.Name = "buttonMinTet";
            this.buttonMinTet.Size = new System.Drawing.Size(102, 43);
            this.buttonMinTet.TabIndex = 0;
            this.buttonMinTet.Text = "Minimum tét(2500Ft)";
            this.buttonMinTet.UseVisualStyleBackColor = true;
            this.buttonMinTet.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.groupBoxTetOpciok);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxBlackjack);
            this.Controls.Add(this.textBoxPenzFeltolt);
            this.Controls.Add(this.buttonPenzFeltolt);
            this.Controls.Add(this.textBoxEgyenleg);
            this.Controls.Add(this.labelEgyenleg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxBlackjack.ResumeLayout(false);
            this.groupBoxBlackjack.PerformLayout();
            this.groupBoxTetOpciok.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Label labelEgyenleg;
        private System.Windows.Forms.TextBox textBoxEgyenleg;
        private System.Windows.Forms.TextBox textBoxKartyak;
        private System.Windows.Forms.Button buttonPenzFeltolt;
        private System.Windows.Forms.TextBox textBoxPenzFeltolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxBlackjack;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxTetOpciok;
        private System.Windows.Forms.Button buttonNagyTet;
        private System.Windows.Forms.Button buttonAlapTet;
        private System.Windows.Forms.Button buttonMinTet;
    }
}

