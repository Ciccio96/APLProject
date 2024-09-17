namespace APL_ServerDef.JewelryBookSection
{
    partial class ModificaInformazioniGioielleria
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
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aggiorna_button = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.modificato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(419, 234);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(184, 20);
            this.password_textbox.TabIndex = 46;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(310, 269);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(71, 13);
            this.nome_label.TabIndex = 44;
            this.nome_label.Text = "Nome attivita\'";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(201, 234);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(184, 20);
            this.username_textbox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(265, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 31);
            this.label4.TabIndex = 41;
            this.label4.Text = "Modifica informazioni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label3.Location = new System.Drawing.Point(230, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 63);
            this.label3.TabIndex = 40;
            this.label3.Text = "JewelryBook";
            // 
            // aggiorna_button
            // 
            this.aggiorna_button.Location = new System.Drawing.Point(341, 365);
            this.aggiorna_button.Name = "aggiorna_button";
            this.aggiorna_button.Size = new System.Drawing.Size(116, 35);
            this.aggiorna_button.TabIndex = 39;
            this.aggiorna_button.Text = "Aggiorna";
            this.aggiorna_button.UseVisualStyleBackColor = true;
            this.aggiorna_button.Click += new System.EventHandler(this.Aggiorna_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(417, 218);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 38;
            this.password_label.Text = "Password";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(198, 218);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(55, 13);
            this.username_label.TabIndex = 37;
            this.username_label.Text = "Username";
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(313, 285);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(184, 20);
            this.nome_textbox.TabIndex = 36;
            // 
            // modificato
            // 
            this.modificato.AutoSize = true;
            this.modificato.Location = new System.Drawing.Point(343, 332);
            this.modificato.Name = "modificato";
            this.modificato.Size = new System.Drawing.Size(0, 13);
            this.modificato.TabIndex = 47;
            // 
            // ModificaInformazioniGioielleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modificato);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aggiorna_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.nome_textbox);
            this.Name = "ModificaInformazioniGioielleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaInformazioniGioielleria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aggiorna_button;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.Label modificato;
    }
}