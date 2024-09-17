using APL_ServerDef.Socket_Connection;
using APL_ServerDef.MetodiComuni;
using System;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class ValutazioneOro : Form
    {
        ClientSocket _clientSocket;
        Metodi metodiComuni = new Metodi();
        string[] infoGroup;
        string _bytesRead;
        public ValutazioneOro()
        {
            InitializeComponent();
            this.valutazione.Text = "";
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            infoGroup = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;
        }

        private void valuta_Button_Click(object sender, EventArgs e)
        {
            string request = String.Empty;
            request = "select * from gioielleria order by nome";
            var splittedVal = metodiComuni.definisciLista(request, _clientSocket, _bytesRead);
            this.listView1.Items.Clear();

            var max = metodiComuni.effettuaValutazione(splittedVal, quantita_InputBox.Text, "Oro");

            this.valutazione.Text = max.Item1.ToString() + " €";

            for (int i = 0; i < max.Item2.Count; i++)
            {
                this.listView1.Items.Add(max.Item2[i].ToString());
                listView1.EnsureVisible(listView1.Items.Count - 1);
            }

        }
    }
}
