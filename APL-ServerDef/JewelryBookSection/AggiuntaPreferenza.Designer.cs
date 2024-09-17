namespace APL_ServerDef.JewelryBookSection
{
    partial class AggiuntaPreferenza
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conferma_button = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.modificato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(246, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prodotto preferito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(422, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Materiale preferito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(251, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 31);
            this.label4.TabIndex = 41;
            this.label4.Text = "Inserimento preferenze";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(227, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 63);
            this.label1.TabIndex = 40;
            this.label1.Text = "JewelryBook";
            // 
            // conferma_button
            // 
            this.conferma_button.Location = new System.Drawing.Point(349, 336);
            this.conferma_button.Name = "conferma_button";
            this.conferma_button.Size = new System.Drawing.Size(116, 29);
            this.conferma_button.TabIndex = 39;
            this.conferma_button.Text = "Conferma";
            this.conferma_button.UseVisualStyleBackColor = true;
            this.conferma_button.Click += new System.EventHandler(this.Conferma_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Anelli",
            "Bracciali",
            "Collane",
            "Orecchini"});
            this.checkedListBox1.Location = new System.Drawing.Point(257, 225);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox1.Size = new System.Drawing.Size(97, 60);
            this.checkedListBox1.TabIndex = 42;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Argento",
            "Oro"});
            this.checkedListBox2.Location = new System.Drawing.Point(436, 225);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(97, 30);
            this.checkedListBox2.TabIndex = 43;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // modificato
            // 
            this.modificato.AutoSize = true;
            this.modificato.Location = new System.Drawing.Point(346, 305);
            this.modificato.Name = "modificato";
            this.modificato.Size = new System.Drawing.Size(0, 13);
            this.modificato.TabIndex = 44;
            this.modificato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AggiuntaPreferenza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modificato);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conferma_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AggiuntaPreferenza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AggiuntaPreferenza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button conferma_button;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label modificato;
    }
}