using APL_ServerDef.Socket_Connection;
using System;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class AccessGioielleria : Form
    {
        ClientSocket _clientSocket;
        string[] infoGroup;
        string _bytesRead;
        public AccessGioielleria()
        {
            InitializeComponent();
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            infoGroup = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;

            HomeGioielleria home = new HomeGioielleria();
            home.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(home);
            home.FormBorderStyle = FormBorderStyle.None;
            home.BringToFront();
            home.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            home.Show();
        }

        private void inserimentoQuotazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserimentoQuotazione inserimentoQuotazione = new InserimentoQuotazione();
            inserimentoQuotazione.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(inserimentoQuotazione);
            inserimentoQuotazione.FormBorderStyle = FormBorderStyle.None;
            inserimentoQuotazione.BringToFront();
            inserimentoQuotazione.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            inserimentoQuotazione.Show();
        }

        private void modificaInformazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaInformazioniGioielleria modifica = new ModificaInformazioniGioielleria();
            modifica.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(modifica);
            modifica.FormBorderStyle = FormBorderStyle.None;
            modifica.BringToFront();
            modifica.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            modifica.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeGioielleria home = new HomeGioielleria();
            home.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(home);
            home.FormBorderStyle = FormBorderStyle.None;
            home.BringToFront();
            home.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            home.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Hide();
            Login.ShowDialog();
            Login.Show();
        }
    }
}
