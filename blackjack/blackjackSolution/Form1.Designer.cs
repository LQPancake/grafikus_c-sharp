namespace blackjackSolution
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonKisTet = new System.Windows.Forms.Button();
            this.buttonAlapTet = new System.Windows.Forms.Button();
            this.buttonNagyTet = new System.Windows.Forms.Button();
            this.buttonFeltoltes = new System.Windows.Forms.Button();
            this.textBoxKartyak = new System.Windows.Forms.TextBox();
            this.textBoxEgyenleg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTet = new System.Windows.Forms.Label();
            this.textBoxFeltoltes = new System.Windows.Forms.TextBox();
            this.groupBoxBlackjack = new System.Windows.Forms.GroupBox();
            this.labelStatusz = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDealerKartyak = new System.Windows.Forms.TextBox();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonHit = new System.Windows.Forms.Button();
            this.groupBoxTetek = new System.Windows.Forms.GroupBox();
            this.groupBoxBlackjack.SuspendLayout();
            this.groupBoxTetek.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(328, 265);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 45);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Játék indítása";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonKisTet
            // 
            this.buttonKisTet.Location = new System.Drawing.Point(19, 15);
            this.buttonKisTet.Name = "buttonKisTet";
            this.buttonKisTet.Size = new System.Drawing.Size(102, 34);
            this.buttonKisTet.TabIndex = 1;
            this.buttonKisTet.Text = "Kis tét (2500Ft)";
            this.buttonKisTet.UseVisualStyleBackColor = true;
            this.buttonKisTet.Click += new System.EventHandler(this.buttonKisTet_Click);
            // 
            // buttonAlapTet
            // 
            this.buttonAlapTet.Location = new System.Drawing.Point(127, 15);
            this.buttonAlapTet.Name = "buttonAlapTet";
            this.buttonAlapTet.Size = new System.Drawing.Size(102, 34);
            this.buttonAlapTet.TabIndex = 2;
            this.buttonAlapTet.Text = "Alap tét (5000Ft)";
            this.buttonAlapTet.UseVisualStyleBackColor = true;
            this.buttonAlapTet.Click += new System.EventHandler(this.buttonAlapTet_Click);
            // 
            // buttonNagyTet
            // 
            this.buttonNagyTet.Location = new System.Drawing.Point(79, 55);
            this.buttonNagyTet.Name = "buttonNagyTet";
            this.buttonNagyTet.Size = new System.Drawing.Size(102, 34);
            this.buttonNagyTet.TabIndex = 3;
            this.buttonNagyTet.Text = "Nagy Tét (10000Ft)";
            this.buttonNagyTet.UseVisualStyleBackColor = true;
            this.buttonNagyTet.Click += new System.EventHandler(this.buttonNagyTet_Click);
            // 
            // buttonFeltoltes
            // 
            this.buttonFeltoltes.Location = new System.Drawing.Point(349, 382);
            this.buttonFeltoltes.Name = "buttonFeltoltes";
            this.buttonFeltoltes.Size = new System.Drawing.Size(89, 25);
            this.buttonFeltoltes.TabIndex = 4;
            this.buttonFeltoltes.Text = "Feltöltés";
            this.buttonFeltoltes.UseVisualStyleBackColor = true;
            this.buttonFeltoltes.Visible = false;
            // 
            // textBoxKartyak
            // 
            this.textBoxKartyak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKartyak.Location = new System.Drawing.Point(315, 153);
            this.textBoxKartyak.Name = "textBoxKartyak";
            this.textBoxKartyak.Size = new System.Drawing.Size(143, 31);
            this.textBoxKartyak.TabIndex = 5;
            this.textBoxKartyak.TextChanged += new System.EventHandler(this.textBoxDealerKartyak_TextChanged);
            // 
            // textBoxEgyenleg
            // 
            this.textBoxEgyenleg.Location = new System.Drawing.Point(338, 330);
            this.textBoxEgyenleg.Name = "textBoxEgyenleg";
            this.textBoxEgyenleg.ReadOnly = true;
            this.textBoxEgyenleg.Size = new System.Drawing.Size(100, 20);
            this.textBoxEgyenleg.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Értékek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "K,Q,J = 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "A = 1/11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nyerő szorzók:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nyerés: 2x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blackjack: 2.5x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Döntetlen: Tét visszajár";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(278, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Egyenleg:";
            // 
            // labelTet
            // 
            this.labelTet.AutoSize = true;
            this.labelTet.ForeColor = System.Drawing.Color.White;
            this.labelTet.Location = new System.Drawing.Point(366, 312);
            this.labelTet.Name = "labelTet";
            this.labelTet.Size = new System.Drawing.Size(0, 13);
            this.labelTet.TabIndex = 15;
            // 
            // textBoxFeltoltes
            // 
            this.textBoxFeltoltes.Location = new System.Drawing.Point(352, 413);
            this.textBoxFeltoltes.Name = "textBoxFeltoltes";
            this.textBoxFeltoltes.Size = new System.Drawing.Size(84, 20);
            this.textBoxFeltoltes.TabIndex = 16;
            this.textBoxFeltoltes.Visible = false;
            // 
            // groupBoxBlackjack
            // 
            this.groupBoxBlackjack.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBlackjack.Controls.Add(this.labelStatusz);
            this.groupBoxBlackjack.Controls.Add(this.label10);
            this.groupBoxBlackjack.Controls.Add(this.label9);
            this.groupBoxBlackjack.Controls.Add(this.textBoxDealerKartyak);
            this.groupBoxBlackjack.Controls.Add(this.buttonStand);
            this.groupBoxBlackjack.Controls.Add(this.buttonHit);
            this.groupBoxBlackjack.Controls.Add(this.label7);
            this.groupBoxBlackjack.Controls.Add(this.label6);
            this.groupBoxBlackjack.Controls.Add(this.label5);
            this.groupBoxBlackjack.Controls.Add(this.label4);
            this.groupBoxBlackjack.Controls.Add(this.label3);
            this.groupBoxBlackjack.Controls.Add(this.label2);
            this.groupBoxBlackjack.Controls.Add(this.label1);
            this.groupBoxBlackjack.Controls.Add(this.textBoxKartyak);
            this.groupBoxBlackjack.Location = new System.Drawing.Point(3, 6);
            this.groupBoxBlackjack.Name = "groupBoxBlackjack";
            this.groupBoxBlackjack.Size = new System.Drawing.Size(794, 259);
            this.groupBoxBlackjack.TabIndex = 17;
            this.groupBoxBlackjack.TabStop = false;
            this.groupBoxBlackjack.Visible = false;
            // 
            // labelStatusz
            // 
            this.labelStatusz.AutoSize = true;
            this.labelStatusz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatusz.ForeColor = System.Drawing.Color.White;
            this.labelStatusz.Location = new System.Drawing.Point(510, 116);
            this.labelStatusz.Name = "labelStatusz";
            this.labelStatusz.Size = new System.Drawing.Size(259, 31);
            this.labelStatusz.TabIndex = 18;
            this.labelStatusz.Text = "Játék folyamatban...";
            this.labelStatusz.Click += new System.EventHandler(this.labelStatusz_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(366, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Kártyák";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(343, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dealer Kártyák";
            // 
            // textBoxDealerKartyak
            // 
            this.textBoxDealerKartyak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDealerKartyak.Location = new System.Drawing.Point(315, 87);
            this.textBoxDealerKartyak.Name = "textBoxDealerKartyak";
            this.textBoxDealerKartyak.Size = new System.Drawing.Size(143, 31);
            this.textBoxDealerKartyak.TabIndex = 15;
            this.textBoxDealerKartyak.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonStand
            // 
            this.buttonStand.Location = new System.Drawing.Point(392, 202);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(101, 39);
            this.buttonStand.TabIndex = 14;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = true;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(285, 202);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(101, 39);
            this.buttonHit.TabIndex = 14;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // groupBoxTetek
            // 
            this.groupBoxTetek.Controls.Add(this.buttonNagyTet);
            this.groupBoxTetek.Controls.Add(this.buttonAlapTet);
            this.groupBoxTetek.Controls.Add(this.buttonKisTet);
            this.groupBoxTetek.Location = new System.Drawing.Point(507, 315);
            this.groupBoxTetek.Name = "groupBoxTetek";
            this.groupBoxTetek.Size = new System.Drawing.Size(265, 117);
            this.groupBoxTetek.TabIndex = 18;
            this.groupBoxTetek.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTetek);
            this.Controls.Add(this.groupBoxBlackjack);
            this.Controls.Add(this.textBoxFeltoltes);
            this.Controls.Add(this.labelTet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxEgyenleg);
            this.Controls.Add(this.buttonFeltoltes);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxBlackjack.ResumeLayout(false);
            this.groupBoxBlackjack.PerformLayout();
            this.groupBoxTetek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonKisTet;
        private System.Windows.Forms.Button buttonAlapTet;
        private System.Windows.Forms.Button buttonNagyTet;
        private System.Windows.Forms.Button buttonFeltoltes;
        private System.Windows.Forms.TextBox textBoxKartyak;
        private System.Windows.Forms.TextBox textBoxEgyenleg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTet;
        private System.Windows.Forms.TextBox textBoxFeltoltes;
        private System.Windows.Forms.GroupBox groupBoxBlackjack;
        private System.Windows.Forms.GroupBox groupBoxTetek;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.TextBox textBoxDealerKartyak;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelStatusz;
    }
}

