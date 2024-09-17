using APL_ServerDef.Socket_Connection;
using APL_ServerDef.MetodiComuni;
using System;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class Access : Form
    {
        ClientSocket _clientSocket;
        Metodi m = new Metodi();
        string[] infoGroup;
        string _bytesRead;
        public Access()
        {
            InitializeComponent();
        }
        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            infoGroup = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;

            Home home = new Home();
            home.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(home);
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.BringToFront();
            home.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            home.Show();

        }

        private void oroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuotazioniOro quotazione = new QuotazioniOro();
            quotazione.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(quotazione);
            quotazione.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            quotazione.BringToFront();
            quotazione.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            quotazione.Show();
        }
        private void argentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuotazioniArgento quotazione = new QuotazioniArgento();
            quotazione.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(quotazione);
            quotazione.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            quotazione.BringToFront();
            quotazione.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            quotazione.Show();
        }
        private void oroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ValutazioneOro valutazione = new ValutazioneOro();
            valutazione.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(valutazione);
            valutazione.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            valutazione.BringToFront();
            valutazione.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            valutazione.Show();
        }
        private void argentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ValutazioneArgento valutazione = new ValutazioneArgento();
            valutazione.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(valutazione);
            valutazione.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            valutazione.BringToFront();
            valutazione.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            valutazione.Show();
        }
        private void inserimentoPreferenzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggiuntaPreferenza preferenza = new AggiuntaPreferenza();
            preferenza.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(preferenza);
            preferenza.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            preferenza.BringToFront();
            preferenza.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            preferenza.Show();
        }
        private void modificaInformazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaInformazioni info = new ModificaInformazioni();
            info.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(info);
            info.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            info.BringToFront();
            info.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            info.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.TopLevel = false;
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
            panel1.Controls.Add(home);
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
