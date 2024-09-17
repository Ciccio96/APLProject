using APL_ServerDef.Classi;
using APL_ServerDef.MetodiComuni;
using APL_ServerDef.Socket_Connection;
using System;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class ModificaInformazioni : Form
    {
        string[] listVal;
        ClientSocket _clientSocket;
        Metodi metodiComuni = new Metodi();
        string _bytesRead;
        public ModificaInformazioni()
        {
            InitializeComponent();
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            listVal = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;
            this.username_textbox.Text = arr[4];
            this.password_textbox.Text = arr[5];
            this.nome_textbox.Text = arr[2];
            this.cognome_textbox.Text = arr[3];
        }

        private void Aggiorna_Click(object sender, EventArgs e)
        {
            var client = new Cliente();
            client.Id = new Guid(listVal[0]);
            if(Int32.Parse(listVal[1]) == 2)
            {
                client.Username = this.username_textbox.Text;
                client.Password = this.password_textbox.Text;
                client.Nome = this.nome_textbox.Text;
                client.Cognome = this.cognome_textbox.Text;
                client.TipoPreferito = Int32.Parse(listVal[6]);
                client.MaterialePreferito = 1;
            }

            string query = "update cliente set Tipologia = " + Int32.Parse(listVal[1]) + ", Nome = '" + client.Nome + "', Cognome = '" + client.Cognome + "', Email = '" + client.Username + "', Password = '" + client.Password + "', TipoPreferito = " + client.TipoPreferito + ", MaterialePreferito = " + client.MaterialePreferito + " where Id = '" + listVal[0] + "' ";
            string esito = metodiComuni.executeQuery(query, _clientSocket);

            if (esito == "Ok")
            {
                this.modificato.Text = "Modifica avvenuta";
            }

        }
    }
}
