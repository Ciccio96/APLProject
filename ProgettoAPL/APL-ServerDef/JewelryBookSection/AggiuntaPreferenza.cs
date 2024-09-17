using APL_ServerDef.Classi;
using APL_ServerDef.Socket_Connection;
using APL_ServerDef.MetodiComuni;
using System;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class AggiuntaPreferenza : Form
    {
        string[] listVal;
        Metodi metodiComuni = new Metodi();
        ClientSocket _clientSocket;
        string _bytesRead;
        int tipoPreferito;
        int materialePreferito;

        public AggiuntaPreferenza()
        {
            InitializeComponent();
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            listVal = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;

            string initQuery = "select * from cliente where Id = '" + listVal[0] + "' ";

            var splittedVal = metodiComuni.definisciLista(initQuery, _clientSocket, _bytesRead);

            if (Int32.Parse(splittedVal[0][6]) != 0 || Int32.Parse(splittedVal[0][7]) != 0)
            {
                this.checkedListBox1.SelectedIndex = Int32.Parse(splittedVal[0][6]) - 1;
                this.checkedListBox1.SetItemChecked(Int32.Parse(splittedVal[0][6]) - 1, true);
                this.checkedListBox2.SelectedIndex = Int32.Parse(splittedVal[0][7]) - 1;
                this.checkedListBox2.SetItemChecked(Int32.Parse(splittedVal[0][7]) - 1, true);

            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPreferito = this.checkedListBox1.SelectedIndex + 1;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialePreferito = this.checkedListBox2.SelectedIndex + 1;
        }

        private void eventListener(object sender, EventArgs e)
        {
            
        }

        private void Conferma_Click(object sender, EventArgs e)
        {
            var client = new Cliente();
            client.Id = new Guid(listVal[0]);
            if (Int32.Parse(listVal[1]) == 2)
            {
                client.Username = listVal[4];
                client.Password = listVal[5];
                client.Nome = listVal[2];
                client.Cognome = listVal[3];
                client.TipoPreferito = this.checkedListBox1.SelectedIndex + 1; ;
                client.MaterialePreferito = this.checkedListBox2.SelectedIndex + 1;
            }

            string query = "";
            query = "update cliente set TipoPreferito = " + client.TipoPreferito + ", MaterialePreferito = " + client.MaterialePreferito + " where Id = '" + listVal[0] + "' ";
            string esito = metodiComuni.executeQuery(query, _clientSocket);

            if(esito == "Ok")
            {
                this.modificato.Text = "Modifica avvenuta";
            }

        }

    }
}
