namespace APL_ServerDef.JewelryBookSection
{
    partial class AccessGioielleria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserimentoQuotazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaInformazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 4;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // inserimentoQuotazioneToolStripMenuItem
            // 
            this.inserimentoQuotazioneToolStripMenuItem.Name = "inserimentoQuotazioneToolStripMenuItem";
            this.inserimentoQuotazioneToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.inserimentoQuotazioneToolStripMenuItem.Text = "Inserimento Quotazione";
            this.inserimentoQuotazioneToolStripMenuItem.Click += new System.EventHandler(this.inserimentoQuotazioneToolStripMenuItem_Click);
            // 
            // modificaInformazioniToolStripMenuItem
            // 
            this.modificaInformazioniToolStripMenuItem.Name = "modificaInformazioniToolStripMenuItem";
            this.modificaInformazioniToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.modificaInformazioniToolStripMenuItem.Text = "Modifica Informazioni";
            this.modificaInformazioniToolStripMenuItem.Click += new System.EventHandler(this.modificaInformazioniToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.inserimentoQuotazioneToolStripMenuItem,
            this.modificaInformazioniToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // AccessGioielleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AccessGioielleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessGioielleria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserimentoQuotazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaInformazioniToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}