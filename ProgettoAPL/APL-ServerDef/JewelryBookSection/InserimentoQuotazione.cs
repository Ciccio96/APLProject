using APL_ServerDef.Classi;
using APL_ServerDef.MetodiComuni;
using APL_ServerDef.Socket_Connection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APL_ServerDef.JewelryBookSection
{
    public partial class InserimentoQuotazione : Form
    {
        ClientSocket _clientSocket;
        Metodi metodiComuni = new Metodi();
        string[] infoGroup;
        List<string[]> infoGroups;
        string _bytesRead;
        public InserimentoQuotazione()
        {
            InitializeComponent();
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            infoGroup = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;

            string request = String.Empty;
            request = "select * from gioielleria where nome = '" + arr[2] + "'";

            var splittedVal = metodiComuni.definisciLista(request, _clientSocket, _bytesRead);

            this.listView1.Items.Clear();

            var buf = metodiComuni.informazioniGioielleria(splittedVal, _clientSocket);
            
            for (int i = 0; i < buf.Count; i++)
            {
                this.listView1.Items.Add(buf[i].ToString());
                listView1.EnsureVisible(listView1.Items.Count - 1);
            }
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            var gioielleria = new Gioielleria();

            gioielleria.Id = new Guid(infoGroup[0]);
            if(Int32.Parse(infoGroup[1]) == 1)
            {
                gioielleria.Username = infoGroup[3];
                gioielleria.Password = infoGroup[4];
                gioielleria.Nome = infoGroup[2];

                var indexSelectedQuotazione = this.inserimentoQuotazioneCheckBox.SelectedIndex + 1;
                var indexSelectedValutazione = this.inserimentoValutazioneCheckBox.SelectedIndex + 1;

                if (indexSelectedQuotazione == 1)
                {
                    gioielleria.QuotazioneOroNuovo = metodiComuni.modificaQuotazione(infoGroup[5]);
                    gioielleria.QuotazioneArgentoNuovo = metodiComuni.modificaQuotazione(this.quotazioneBox.Text);
                    gioielleria.ValutazioneOroVecchio = metodiComuni.modificaQuotazione(infoGroup[7]);
                    gioielleria.ValutazioneArgentoVecchio = metodiComuni.modificaQuotazione(infoGroup[8].Substring(0, 4));
                }

                if (indexSelectedQuotazione == 2)
                {
                    gioielleria.QuotazioneOroNuovo = metodiComuni.modificaQuotazione(this.quotazioneBox.Text);
                    gioielleria.QuotazioneArgentoNuovo = metodiComuni.modificaQuotazione(infoGroup[6]);
                    gioielleria.ValutazioneOroVecchio = metodiComuni.modificaQuotazione(infoGroup[7]);
                    gioielleria.ValutazioneArgentoVecchio = metodiComuni.modificaQuotazione(infoGroup[8].Substring(0, 4));
                }
                
                if (indexSelectedValutazione == 2)
                {
                    gioielleria.QuotazioneOroNuovo = metodiComuni.modificaQuotazione(infoGroup[5]);
                    gioielleria.QuotazioneArgentoNuovo = metodiComuni.modificaQuotazione(infoGroup[6]);
                    gioielleria.ValutazioneOroVecchio = metodiComuni.modificaQuotazione(this.quotazioneBox.Text);
                    gioielleria.ValutazioneArgentoVecchio = metodiComuni.modificaQuotazione(infoGroup[8].Substring(0, 4));
                }
                if (indexSelectedValutazione == 1)
                {
                    gioielleria.QuotazioneOroNuovo = metodiComuni.modificaQuotazione(infoGroup[5]);
                    gioielleria.QuotazioneArgentoNuovo = metodiComuni.modificaQuotazione(infoGroup[6]);
                    gioielleria.ValutazioneOroVecchio = metodiComuni.modificaQuotazione(infoGroup[7]);
                    gioielleria.ValutazioneArgentoVecchio = metodiComuni.modificaQuotazione(this.valutazioneBox.Text);
                }

                string oroNuovo = gioielleria.QuotazioneOroNuovo.ToString().Replace(',', '.');
                string oroVecchio = gioielleria.ValutazioneOroVecchio.ToString().Replace(',', '.');
                string argentoNuovo = gioielleria.QuotazioneArgentoNuovo.ToString().Replace(',', '.');
                string argentoVecchio = gioielleria.ValutazioneArgentoVecchio.ToString().Replace(',', '.');
                
                string query = "update gioielleria set QuotazioneOroNuovo = '" + oroNuovo + "', QuotazioneArgentoNuovo = '" + argentoNuovo + "', ValutazioneOroVecchio =  '" + oroVecchio + "', ValutazioneArgentoVecchio = '" + argentoVecchio + "' where Id = '" + infoGroup[0] + "' ";
                string esito = metodiComuni.executeQuery(query, _clientSocket);

                if(esito == "Ok")
                {
                    this.modificato.Text = "Modifica avvenuta";
                }

                string request = String.Empty;
                request = "select * from gioielleria where Id = '" + infoGroup[0] + "'";

                var splittedVal = metodiComuni.definisciLista(request, _clientSocket, _bytesRead);

                this.listView1.Items.Clear();

                var buf = metodiComuni.informazioniGioielleria(splittedVal, _clientSocket);

                for (int i = 0; i < buf.Count; i++)
                {
                    this.listView1.Items.Add(buf[i].ToString());
                    listView1.EnsureVisible(listView1.Items.Count - 1);
                }

            }

        }
    }
}
