namespace APL_ServerDef.JewelryBookSection
{
    partial class ValutazioneOro
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantita_InputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valuta_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valutazione = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(29, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 250);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valutazioni Oro Gioiellerie";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(735, 225);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "°Esprimere valore in grammi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valutazione Oro";
            // 
            // quantita_InputBox
            // 
            this.quantita_InputBox.Location = new System.Drawing.Point(49, 46);
            this.quantita_InputBox.Name = "quantita_InputBox";
            this.quantita_InputBox.Size = new System.Drawing.Size(183, 20);
            this.quantita_InputBox.TabIndex = 0;
            this.quantita_InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantità materiale (Oro)";
            // 
            // valuta_Button
            // 
            this.valuta_Button.Location = new System.Drawing.Point(303, 43);
            this.valuta_Button.Name = "valuta_Button";
            this.valuta_Button.Size = new System.Drawing.Size(75, 23);
            this.valuta_Button.TabIndex = 2;
            this.valuta_Button.Text = "Valuta";
            this.valuta_Button.UseVisualStyleBackColor = true;
            this.valuta_Button.Click += new System.EventHandler(this.valuta_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "°grammi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valutazione);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.valuta_Button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.quantita_InputBox);
            this.groupBox1.Location = new System.Drawing.Point(302, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 123);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci informazioni relative al tuo usato";
            // 
            // valutazione
            // 
            this.valutazione.AutoSize = true;
            this.valutazione.Location = new System.Drawing.Point(171, 90);
            this.valutazione.Name = "valutazione";
            this.valutazione.Size = new System.Drawing.Size(61, 13);
            this.valutazione.TabIndex = 8;
            this.valutazione.Text = "valutazione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Migliore Valutazione:";
            // 
            // ValutazioneOro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ValutazioneOro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValutazioneOro";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox quantita_InputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button valuta_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label valutazione;
        private System.Windows.Forms.Label label5;
    }
}