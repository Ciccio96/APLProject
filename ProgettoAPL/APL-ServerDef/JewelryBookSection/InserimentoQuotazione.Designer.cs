namespace APL_ServerDef.JewelryBookSection
{
    partial class InserimentoQuotazione
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
            this.title = new System.Windows.Forms.Label();
            this.inserimentoQuotazioneCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.quotazioneBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salvaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valutazioneBox = new System.Windows.Forms.TextBox();
            this.inserimentoValutazioneCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modificato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title.Location = new System.Drawing.Point(28, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(452, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Inserimento Quotazione/Valutazione";
            // 
            // inserimentoQuotazioneCheckBox
            // 
            this.inserimentoQuotazioneCheckBox.BackColor = System.Drawing.SystemColors.Menu;
            this.inserimentoQuotazioneCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inserimentoQuotazioneCheckBox.FormattingEnabled = true;
            this.inserimentoQuotazioneCheckBox.Items.AddRange(new object[] {
            "Argento",
            "Oro"});
            this.inserimentoQuotazioneCheckBox.Location = new System.Drawing.Point(34, 326);
            this.inserimentoQuotazioneCheckBox.Name = "inserimentoQuotazioneCheckBox";
            this.inserimentoQuotazioneCheckBox.Size = new System.Drawing.Size(97, 30);
            this.inserimentoQuotazioneCheckBox.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(31, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Inserire quotazione";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(730, 158);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(42, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Quotazioni/Valutazioni esistenti";
            // 
            // quotazioneBox
            // 
            this.quotazioneBox.Location = new System.Drawing.Point(35, 370);
            this.quotazioneBox.Name = "quotazioneBox";
            this.quotazioneBox.Size = new System.Drawing.Size(100, 20);
            this.quotazioneBox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "*€/gr";
            // 
            // salvaButton
            // 
            this.salvaButton.Location = new System.Drawing.Point(689, 326);
            this.salvaButton.Name = "salvaButton";
            this.salvaButton.Size = new System.Drawing.Size(75, 30);
            this.salvaButton.TabIndex = 51;
            this.salvaButton.Text = "Salva";
            this.salvaButton.UseVisualStyleBackColor = true;
            this.salvaButton.Click += new System.EventHandler(this.salvaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "*€/gr";
            // 
            // valutazioneBox
            // 
            this.valutazioneBox.Location = new System.Drawing.Point(326, 370);
            this.valutazioneBox.Name = "valutazioneBox";
            this.valutazioneBox.Size = new System.Drawing.Size(100, 20);
            this.valutazioneBox.TabIndex = 54;
            // 
            // inserimentoValutazioneCheckBox
            // 
            this.inserimentoValutazioneCheckBox.BackColor = System.Drawing.SystemColors.Menu;
            this.inserimentoValutazioneCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inserimentoValutazioneCheckBox.FormattingEnabled = true;
            this.inserimentoValutazioneCheckBox.Items.AddRange(new object[] {
            "Argento",
            "Oro"});
            this.inserimentoValutazioneCheckBox.Location = new System.Drawing.Point(325, 326);
            this.inserimentoValutazioneCheckBox.Name = "inserimentoValutazioneCheckBox";
            this.inserimentoValutazioneCheckBox.Size = new System.Drawing.Size(97, 30);
            this.inserimentoValutazioneCheckBox.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(322, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Inserire valutazione";
            // 
            // modificato
            // 
            this.modificato.AutoSize = true;
            this.modificato.Location = new System.Drawing.Point(652, 375);
            this.modificato.Name = "modificato";
            this.modificato.Size = new System.Drawing.Size(0, 13);
            this.modificato.TabIndex = 56;
            // 
            // InserimentoQuotazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modificato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valutazioneBox);
            this.Controls.Add(this.inserimentoValutazioneCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salvaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quotazioneBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.inserimentoQuotazioneCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Name = "InserimentoQuotazione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InserimentoQuotazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckedListBox inserimentoQuotazioneCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quotazioneBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salvaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valutazioneBox;
        private System.Windows.Forms.CheckedListBox inserimentoValutazioneCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label modificato;
    }
}