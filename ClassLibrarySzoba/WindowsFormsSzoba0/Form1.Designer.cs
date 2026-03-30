namespace WindowsFormsSzoba0
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
            this.buttonSzamitas = new System.Windows.Forms.Button();
            this.labelHosszusag = new System.Windows.Forms.Label();
            this.labelSzelesseg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHosszusag = new System.Windows.Forms.TextBox();
            this.textBoxSzelesseg = new System.Windows.Forms.TextBox();
            this.textBoxMagassag = new System.Windows.Forms.TextBox();
            this.textBoxAlapterulet = new System.Windows.Forms.TextBox();
            this.textBoxTerfogat = new System.Windows.Forms.TextBox();
            this.textBoxFalfelulet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSzamitas
            // 
            this.buttonSzamitas.Location = new System.Drawing.Point(108, 219);
            this.buttonSzamitas.Name = "buttonSzamitas";
            this.buttonSzamitas.Size = new System.Drawing.Size(75, 23);
            this.buttonSzamitas.TabIndex = 0;
            this.buttonSzamitas.Text = "Számítás";
            this.buttonSzamitas.UseVisualStyleBackColor = true;
            this.buttonSzamitas.Click += new System.EventHandler(this.buttonSzamitas_Click);
            // 
            // labelHosszusag
            // 
            this.labelHosszusag.AutoSize = true;
            this.labelHosszusag.Location = new System.Drawing.Point(12, 53);
            this.labelHosszusag.Name = "labelHosszusag";
            this.labelHosszusag.Size = new System.Drawing.Size(59, 13);
            this.labelHosszusag.TabIndex = 1;
            this.labelHosszusag.Text = "Hosszúság";
            // 
            // labelSzelesseg
            // 
            this.labelSzelesseg.AutoSize = true;
            this.labelSzelesseg.Location = new System.Drawing.Point(12, 76);
            this.labelSzelesseg.Name = "labelSzelesseg";
            this.labelSzelesseg.Size = new System.Drawing.Size(55, 13);
            this.labelSzelesseg.TabIndex = 2;
            this.labelSzelesseg.Text = "Szélesség";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Magasság";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alapterület";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Térfogat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Falfelület";
            // 
            // textBoxHosszusag
            // 
            this.textBoxHosszusag.Location = new System.Drawing.Point(67, 50);
            this.textBoxHosszusag.Name = "textBoxHosszusag";
            this.textBoxHosszusag.Size = new System.Drawing.Size(100, 20);
            this.textBoxHosszusag.TabIndex = 7;
            // 
            // textBoxSzelesseg
            // 
            this.textBoxSzelesseg.Location = new System.Drawing.Point(67, 76);
            this.textBoxSzelesseg.Name = "textBoxSzelesseg";
            this.textBoxSzelesseg.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzelesseg.TabIndex = 8;
            // 
            // textBoxMagassag
            // 
            this.textBoxMagassag.Location = new System.Drawing.Point(67, 102);
            this.textBoxMagassag.Name = "textBoxMagassag";
            this.textBoxMagassag.Size = new System.Drawing.Size(100, 20);
            this.textBoxMagassag.TabIndex = 9;
            // 
            // textBoxAlapterulet
            // 
            this.textBoxAlapterulet.Location = new System.Drawing.Point(67, 252);
            this.textBoxAlapterulet.Name = "textBoxAlapterulet";
            this.textBoxAlapterulet.ReadOnly = true;
            this.textBoxAlapterulet.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlapterulet.TabIndex = 10;
            // 
            // textBoxTerfogat
            // 
            this.textBoxTerfogat.Location = new System.Drawing.Point(67, 276);
            this.textBoxTerfogat.Name = "textBoxTerfogat";
            this.textBoxTerfogat.ReadOnly = true;
            this.textBoxTerfogat.Size = new System.Drawing.Size(100, 20);
            this.textBoxTerfogat.TabIndex = 11;
            // 
            // textBoxFalfelulet
            // 
            this.textBoxFalfelulet.Location = new System.Drawing.Point(67, 299);
            this.textBoxFalfelulet.Name = "textBoxFalfelulet";
            this.textBoxFalfelulet.ReadOnly = true;
            this.textBoxFalfelulet.Size = new System.Drawing.Size(100, 20);
            this.textBoxFalfelulet.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.textBoxFalfelulet);
            this.Controls.Add(this.textBoxTerfogat);
            this.Controls.Add(this.textBoxAlapterulet);
            this.Controls.Add(this.textBoxMagassag);
            this.Controls.Add(this.textBoxSzelesseg);
            this.Controls.Add(this.textBoxHosszusag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSzelesseg);
            this.Controls.Add(this.labelHosszusag);
            this.Controls.Add(this.buttonSzamitas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSzamitas;
        private System.Windows.Forms.Label labelHosszusag;
        private System.Windows.Forms.Label labelSzelesseg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHosszusag;
        private System.Windows.Forms.TextBox textBoxSzelesseg;
        private System.Windows.Forms.TextBox textBoxMagassag;
        private System.Windows.Forms.TextBox textBoxAlapterulet;
        private System.Windows.Forms.TextBox textBoxTerfogat;
        private System.Windows.Forms.TextBox textBoxFalfelulet;
    }
}

