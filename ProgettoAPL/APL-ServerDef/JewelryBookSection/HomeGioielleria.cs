using APL_ServerDef.Socket_Connection;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class HomeGioielleria : Form
    {
        ClientSocket _clientSocket;
        string[] infoGroup;
        string _bytesRead;
        public HomeGioielleria()
        {
            InitializeComponent();
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            run_cmd();
            this.Nome_Gioielleria.Text = arr[2];
            infoGroup = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;
        }

        private void run_cmd()
        {
            string pythonFile = @"C:\APLProject\ProgettoAPL\APLStatistics\test.py";
            string executable = @"C:\APLProject\ProgettoAPL\APLStatistics\my_venv\Scripts\python.exe";
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(executable, pythonFile)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            if (File.Exists(@"C:\APLProject\ProgettoAPL\APL-ServerDef\Plot\Figure.png"))
            {
                this.pictureBox2.Image = Image.FromFile(@"C:\APLProject\ProgettoAPL\APL-ServerDef\Plot\Figure.png");
            } else
            {
                this.pictureBox2.Image = null;
            } 
        }

        private void inserimentoQuotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoQuotazione inserimentoQuotazione = new InserimentoQuotazione();
            inserimentoQuotazione.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(inserimentoQuotazione);
            inserimentoQuotazione.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            inserimentoQuotazione.BringToFront();
            inserimentoQuotazione.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            inserimentoQuotazione.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login Login = new Login();
            Hide();
            Login.ShowDialog();
            Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            run_cmd();
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = Image.FromFile(@"C:\APLProject\ProgettoAPL\APL-ServerDef\Plot\Figure.png");
        }

        private void modificaInformazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaInformazioniGioielleria modifica = new ModificaInformazioniGioielleria();
            modifica.TopLevel = false;
            if (panel1.Controls.Count > 0)
            panel1.Controls.Clear();
            panel1.Controls.Add(modifica);
            modifica.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            modifica.BringToFront();
            modifica.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            modifica.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeGioielleria home = new HomeGioielleria();
            Hide();
            home.TopLevel = false;
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }
            panel1.Controls.Add(home);
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.BringToFront();
            home.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            home.Show();
        }
    }

}
