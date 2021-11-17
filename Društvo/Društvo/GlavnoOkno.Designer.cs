
namespace Društvo
{
    partial class GlavnoOkno
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaščitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapišiPodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obnoviPodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vnosToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.tiskanjeToolStripMenuItem,
            this.zaščitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vnosToolStripMenuItem
            // 
            this.vnosToolStripMenuItem.Name = "vnosToolStripMenuItem";
            this.vnosToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.vnosToolStripMenuItem.Text = "Vnos";
            this.vnosToolStripMenuItem.Click += new System.EventHandler(this.vnosToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // tiskanjeToolStripMenuItem
            // 
            this.tiskanjeToolStripMenuItem.Name = "tiskanjeToolStripMenuItem";
            this.tiskanjeToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.tiskanjeToolStripMenuItem.Text = "Tiskanje";
            // 
            // zaščitaToolStripMenuItem
            // 
            this.zaščitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapišiPodatkeToolStripMenuItem,
            this.obnoviPodatkeToolStripMenuItem});
            this.zaščitaToolStripMenuItem.Name = "zaščitaToolStripMenuItem";
            this.zaščitaToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.zaščitaToolStripMenuItem.Text = "Zaščita";
            // 
            // zapišiPodatkeToolStripMenuItem
            // 
            this.zapišiPodatkeToolStripMenuItem.Name = "zapišiPodatkeToolStripMenuItem";
            this.zapišiPodatkeToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.zapišiPodatkeToolStripMenuItem.Text = "Zapiši podatke";
            this.zapišiPodatkeToolStripMenuItem.Click += new System.EventHandler(this.zapišiPodatkeToolStripMenuItem_Click);
            // 
            // obnoviPodatkeToolStripMenuItem
            // 
            this.obnoviPodatkeToolStripMenuItem.Name = "obnoviPodatkeToolStripMenuItem";
            this.obnoviPodatkeToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.obnoviPodatkeToolStripMenuItem.Text = "Obnovi podatke";
            this.obnoviPodatkeToolStripMenuItem.Click += new System.EventHandler(this.obnoviPodatkeToolStripMenuItem_Click);
            // 
            // GlavnoOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GlavnoOkno";
            this.Text = "Društvo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaščitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapišiPodatkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obnoviPodatkeToolStripMenuItem;
    }
}