using APL_ServerDef.Socket_Connection;
using APL_ServerDef.MetodiComuni;
using System;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class QuotazioniArgento : Form
    {
        Metodi metodiComuni = new Metodi();
        public QuotazioniArgento()
        {
            InitializeComponent();
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            string request = String.Empty;

            request = "select * from gioielleria order by nome";

            var splittedVal = metodiComuni.definisciLista(request, clientSocket, bytesRead);

            this.listView1.Items.Clear();

            var buf = metodiComuni.mostraQuotazioni(splittedVal, "Argento");

            for (int i = 0; i < buf.Count; i++)
            {
                this.listView1.Items.Add(buf[i].ToString());
                listView1.EnsureVisible(listView1.Items.Count - 1);
            }
        }
    }
}
