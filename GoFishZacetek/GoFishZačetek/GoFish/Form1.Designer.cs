namespace GoFish
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIgra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKompleti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstVRokah = new System.Windows.Forms.ListBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tvoje ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(19, 33);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(178, 20);
            this.txtIme.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(211, 31);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Začni";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Igra";
            // 
            // txtIgra
            // 
            this.txtIgra.Location = new System.Drawing.Point(19, 92);
            this.txtIgra.Multiline = true;
            this.txtIgra.Name = "txtIgra";
            this.txtIgra.Size = new System.Drawing.Size(267, 272);
            this.txtIgra.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kompleti";
            // 
            // txtKompleti
            // 
            this.txtKompleti.Location = new System.Drawing.Point(22, 387);
            this.txtKompleti.Multiline = true;
            this.txtKompleti.Name = "txtKompleti";
            this.txtKompleti.Size = new System.Drawing.Size(264, 124);
            this.txtKompleti.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tvoj karte";
            // 
            // lstVRokah
            // 
            this.lstVRokah.FormattingEnabled = true;
            this.lstVRokah.Location = new System.Drawing.Point(306, 62);
            this.lstVRokah.Name = "lstVRokah";
            this.lstVRokah.Size = new System.Drawing.Size(150, 420);
            this.lstVRokah.TabIndex = 8;
            // 
            // buttonAsk
            // 
            this.buttonAsk.Location = new System.Drawing.Point(306, 487);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(150, 23);
            this.buttonAsk.TabIndex = 9;
            this.buttonAsk.Text = "Vprašaj za karto!";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 534);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.lstVRokah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKompleti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIgra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Go fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIgra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKompleti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstVRokah;
        private System.Windows.Forms.Button buttonAsk;
    }
}

