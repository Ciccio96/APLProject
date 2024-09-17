using APL_ServerDef.Classi;
using APL_ServerDef.MetodiComuni;
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
    public partial class ModificaInformazioniGioielleria : Form
    {
        string[] listVal;
        ClientSocket _clientSocket;
        Metodi metodiComuni = new Metodi();
        string _bytesRead;
        public ModificaInformazioniGioielleria()
        {
            InitializeComponent();
        }

        public void Pass_Value(string[] arr, ClientSocket clientSocket, string bytesRead)
        {
            listVal = arr;
            _clientSocket = clientSocket;
            _bytesRead = bytesRead;
            this.username_textbox.Text = arr[3];
            this.password_textbox.Text = arr[4];
            this.nome_textbox.Text = arr[2];
        }

        private void Aggiorna_Click(object sender, EventArgs e)
        {
            var gioielleria = new Gioielleria();
            gioielleria.Id = new Guid(listVal[0]);
            if (Int32.Parse(listVal[1]) == 1)
            {
                gioielleria.Username = this.username_textbox.Text;
                gioielleria.Password = this.password_textbox.Text;
                gioielleria.Nome = this.nome_textbox.Text;
            }

            string query = "update gioielleria set Nome = '" + gioielleria.Nome + "', Email = '" + gioielleria.Username + "', Password =  '" + gioielleria.Password + "' where Id = '" + listVal[0] + "' ";
            string esito = metodiComuni.executeQuery(query, _clientSocket);

            if (esito == "Ok")
            {
                this.modificato.Text = "Modifica avvenuta";
            }

        }

    }
}
