using APL_ServerDef.Classi;
using APL_ServerDef.Socket_Connection;
using APL_ServerDef.MetodiComuni;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using APL_ServerDef.JewelryBookSection;

namespace APL_ServerDef
{
    public partial class Login : Form
    {
        public string remoteHost = "127.0.0.1";
        public int remotePort = 45678;
        public ClientSocket clientSocket;
        public Metodi metodiComuni = new Metodi();

        public Login()
        {
            InitializeComponent();
            clientSocket = new ClientSocket(remoteHost, remotePort);
            clientSocket.Connect();
        }

        private void executeQuery(int tipologia, Accesso accesso) {
            string tipo = (tipologia == 1) ? "cliente" : "gioielleria";
            string bytesRead = "";
            string query = "select * from " + tipo + " where Email = '" + accesso.Username + "' and Password = '" + accesso.Password + "'";

            List<string[]> arr = metodiComuni.definisciLista(query, clientSocket, bytesRead);

            if (tipologia == 1) {
                Access home = new Access();
                Hide();
                home.Pass_Value(arr[0], clientSocket, bytesRead);
                home.ShowDialog();
                home.Show();
            }
            else
            {
                AccessGioielleria home = new AccessGioielleria();
                Hide();
                home.Pass_Value(arr[0], clientSocket, bytesRead);
                home.ShowDialog();
                home.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrazione Registrazione = new Registrazione();
            Hide();
            Registrazione.Pass_Value(clientSocket);
            Registrazione.ShowDialog();
            Show();
        }

        private void Accedi_Click(object sender, EventArgs e)
        {
            var accesso = new Accesso();
            accesso.Id = Guid.NewGuid();
            accesso.Username = username.Text;
            accesso.Password = password.Text;

            string firstQuery = "select count(1) from cliente where Email = '" + accesso.Username + "' and Password = '" + accesso.Password + "'";
            clientSocket.SendData(firstQuery);
            string res1 = clientSocket.ReceiveData();

            string secondQuery = "select count(1) from gioielleria where Email = '" + accesso.Username + "' and Password = '" + accesso.Password + "'";
            clientSocket.SendData(secondQuery);
            string res2 = clientSocket.ReceiveData();

            int valueRes;
            if (res1.Substring(0, 1) != "0" || res2.Substring(0, 1) != "0") 
            {
                valueRes = res1.Substring(0, 1) != "0" ? 1 : 2;
                this.executeQuery(valueRes, accesso);
            }
            if (res1.Substring(0, 1) == "0" && res2.Substring(0, 1) == "0")
            {
                this.label4.Text = "Attenzione: Inserito account inesistente!";
            }            
        }
    }
}
