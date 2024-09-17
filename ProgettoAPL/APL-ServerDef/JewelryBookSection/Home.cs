using APL_ServerDef.Socket_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class Home : Form
    {
        ClientSocket _clientSocket;
        string[] infoGroup;
        List<string[]> infoGroups;
        string _bytesRead;
        public Home()
        {
            InitializeComponent();
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            this.Nome_Pers.Text = arr[2];
            this.Cognome_Pers.Text = arr[3];
            infoGroup = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;

            string request = String.Empty;
            request = "select * from gioielleria order by nome";
            _clientSocket.SendData(request);
            var buffer = new Byte[request.Length * sizeof(Char)];
            _bytesRead = _clientSocket.ReceiveData();
            string val = _bytesRead.ToString();
            string[] arrs = val.Split('+');
            List<string[]> splittedVal = new List<string[]>();
            for (int i = 0; i < arrs.Length; i++)
            {
                splittedVal.Add(arrs[i].Split(','));
            }
            infoGroups = splittedVal;

            this.listView1.Items.Clear();

            List<string> buf = new List<string>();
            for (int i = 0; i < infoGroups.Count; i++)
            {
                if (infoGroups[i].Length == 9)
                {
                    buf.Add("");
                    buf.Add("  " + infoGroups[i][2] + "  ");
                    buf.Add("________________________________________________________________________________________________________________________________");
                    buf.Add("");
                    buf.Add(" Oro Nuovo : " + infoGroups[i][5] + " €/gr");
                    buf.Add(" Oro Usato : " + infoGroups[i][7] + " €/gr");
                    buf.Add(" Argento Nuovo : " + infoGroups[i][6] + " €/gr");
                    buf.Add(" Argento Usato : " + infoGroups[i][8] + " €/gr");
                    buf.Add("________________________________________________________________________________________________________________________________");
                }

            }

            for (int i = 0; i < buf.Count; i++)
            {
                this.listView1.Items.Add(buf[i].ToString());
                listView1.EnsureVisible(listView1.Items.Count - 1);
            }
        }

        private void oroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuotazioniOro quotazione = new QuotazioniOro();
            quotazione.TopLevel = false;
            if(panel1.Controls.Count > 0)
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
            Hide();
            home.ShowDialog();
            home.Pass_Value(infoGroup, _clientSocket, _bytesRead);
            home.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login Login = new Login();
            Hide();
            Login.ShowDialog();
            Show();
        }
    }
}
