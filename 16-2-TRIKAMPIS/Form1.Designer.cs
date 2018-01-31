namespace _16_2_TRIKAMPIS
{
    partial class FormTrikampioPlotas
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
            this.textBoxReiksme1 = new System.Windows.Forms.TextBox();
            this.textBoxReiksme2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1krastine = new System.Windows.Forms.Label();
            this.label2krastine = new System.Windows.Forms.Label();
            this.labelTrikPlotas = new System.Windows.Forms.Label();
            this.buttonSkaiciuotiPlota = new System.Windows.Forms.Button();
            this.labelTrikDuomenys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxReiksme1
            // 
            this.textBoxReiksme1.Location = new System.Drawing.Point(116, 49);
            this.textBoxReiksme1.Name = "textBoxReiksme1";
            this.textBoxReiksme1.Size = new System.Drawing.Size(141, 20);
            this.textBoxReiksme1.TabIndex = 0;
            this.textBoxReiksme1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxReiksme2
            // 
            this.textBoxReiksme2.Location = new System.Drawing.Point(116, 82);
            this.textBoxReiksme2.Name = "textBoxReiksme2";
            this.textBoxReiksme2.Size = new System.Drawing.Size(141, 20);
            this.textBoxReiksme2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label1krastine
            // 
            this.label1krastine.AutoSize = true;
            this.label1krastine.Location = new System.Drawing.Point(13, 52);
            this.label1krastine.Name = "label1krastine";
            this.label1krastine.Size = new System.Drawing.Size(73, 13);
            this.label1krastine.TabIndex = 4;
            this.label1krastine.Text = "Pirma kraštinė";
            // 
            // label2krastine
            // 
            this.label2krastine.AutoSize = true;
            this.label2krastine.Location = new System.Drawing.Point(9, 85);
            this.label2krastine.Name = "label2krastine";
            this.label2krastine.Size = new System.Drawing.Size(72, 13);
            this.label2krastine.TabIndex = 5;
            this.label2krastine.Text = "Antra kraštinė";
            // 
            // labelTrikPlotas
            // 
            this.labelTrikPlotas.AutoSize = true;
            this.labelTrikPlotas.Location = new System.Drawing.Point(12, 218);
            this.labelTrikPlotas.Name = "labelTrikPlotas";
            this.labelTrikPlotas.Size = new System.Drawing.Size(84, 13);
            this.labelTrikPlotas.TabIndex = 7;
            this.labelTrikPlotas.Text = "Trikampio plotas";
            // 
            // buttonSkaiciuotiPlota
            // 
            this.buttonSkaiciuotiPlota.Location = new System.Drawing.Point(116, 162);
            this.buttonSkaiciuotiPlota.Name = "buttonSkaiciuotiPlota";
            this.buttonSkaiciuotiPlota.Size = new System.Drawing.Size(141, 23);
            this.buttonSkaiciuotiPlota.TabIndex = 8;
            this.buttonSkaiciuotiPlota.Text = "Skaičiuoti plotą";
            this.buttonSkaiciuotiPlota.UseVisualStyleBackColor = true;
            // 
            // labelTrikDuomenys
            // 
            this.labelTrikDuomenys.AutoSize = true;
            this.labelTrikDuomenys.Location = new System.Drawing.Point(45, 13);
            this.labelTrikDuomenys.Name = "labelTrikDuomenys";
            this.labelTrikDuomenys.Size = new System.Drawing.Size(150, 13);
            this.labelTrikDuomenys.TabIndex = 9;
            this.labelTrikDuomenys.Text = "Suveskite trikampio duomenis:\r\n";
            // 
            // FormTrikampioPlotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelTrikDuomenys);
            this.Controls.Add(this.buttonSkaiciuotiPlota);
            this.Controls.Add(this.labelTrikPlotas);
            this.Controls.Add(this.label2krastine);
            this.Controls.Add(this.label1krastine);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxReiksme2);
            this.Controls.Add(this.textBoxReiksme1);
            this.Name = "FormTrikampioPlotas";
            this.Text = "Stataus trikampio plotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReiksme1;
        private System.Windows.Forms.TextBox textBoxReiksme2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1krastine;
        private System.Windows.Forms.Label label2krastine;
        private System.Windows.Forms.Label labelTrikPlotas;
        private System.Windows.Forms.Button buttonSkaiciuotiPlota;
        private System.Windows.Forms.Label labelTrikDuomenys;
    }
}

