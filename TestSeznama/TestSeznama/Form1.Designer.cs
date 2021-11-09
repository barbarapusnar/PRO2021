
namespace TestSeznama
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzpis = new System.Windows.Forms.Button();
            this.txtKonzola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vnesi niz";
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(178, 13);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(191, 31);
            this.txtVnos.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(425, 13);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(148, 34);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzpis
            // 
            this.btnIzpis.Location = new System.Drawing.Point(425, 87);
            this.btnIzpis.Name = "btnIzpis";
            this.btnIzpis.Size = new System.Drawing.Size(148, 34);
            this.btnIzpis.TabIndex = 3;
            this.btnIzpis.Text = "Izpis";
            this.btnIzpis.UseVisualStyleBackColor = true;
            this.btnIzpis.Click += new System.EventHandler(this.btnIzpis_Click);
            // 
            // txtKonzola
            // 
            this.txtKonzola.Location = new System.Drawing.Point(13, 358);
            this.txtKonzola.Multiline = true;
            this.txtKonzola.Name = "txtKonzola";
            this.txtKonzola.ReadOnly = true;
            this.txtKonzola.Size = new System.Drawing.Size(560, 289);
            this.txtKonzola.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 659);
            this.Controls.Add(this.txtKonzola);
            this.Controls.Add(this.btnIzpis);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtVnos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzpis;
        private System.Windows.Forms.TextBox txtKonzola;
    }
}

