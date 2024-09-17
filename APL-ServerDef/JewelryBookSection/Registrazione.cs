using APL_ServerDef.Classi;
using System;
using System.Windows.Forms;
using APL_ServerDef.Socket_Connection;
using APL_ServerDef.MetodiComuni;

namespace APL_ServerDef
{
    public partial class Registrazione : Form
    {

        ClientSocket _clientSocket;
        Metodi metodiComuni = new Metodi();
        public Registrazione()
        {
            InitializeComponent();
            radioCliente.Checked = true;
            radioGioielleria.Checked = false;
        }

        public void Pass_Value(ClientSocket clientSocket)
        {
            _clientSocket = clientSocket;
        }

        private void RadioCliente_Checked(object sender, EventArgs e)
        {
            cognome_textbox.Visible = radioCliente.Checked ? true : false;
            cognome_label.Visible = radioCliente.Checked ? true : false;
        }

        private void EffettuaLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login Login = new Login();
            Hide();
            Login.ShowDialog();
            Show();
        }

        public void Registrati_Click(object sender, EventArgs e)
        {
            if(radioCliente.Checked == true)
            {
                var cliente = new Cliente();
                cliente.Id = Guid.NewGuid();
                cliente.Nome = nome_textbox.Text;
                cliente.Cognome = cognome_textbox.Text;
                cliente.Username = username_textbox.Text;
                cliente.Password = password_textbox.Text;
                cliente.Tipologia = '2';
                cliente.TipoPreferito = 0;
                cliente.MaterialePreferito = 0;
                string query = "insert into cliente (Id, Tipologia, Nome, Cognome, Email, Password, TipoPreferito, MaterialePreferito) values (UUID(), '2', '" + cliente.Nome + "', '" + cliente.Cognome + "', '" + cliente.Username + "', '" + cliente.Password + "', '" + cliente.TipoPreferito + "', '" + cliente.MaterialePreferito + "')";
                string esito = metodiComuni.executeQuery(query, _clientSocket);

                if (esito == "Ok")
                {
                    this.modificato.Text = "Registrazione effettuata";
                }
            }
            else { 
                var gioielleria = new Gioielleria();
                gioielleria.Id = Guid.NewGuid();
                gioielleria.Nome = nome_textbox.Text;
                gioielleria.Username = username_textbox.Text;
                gioielleria.Password = password_textbox.Text;
                gioielleria.Tipologia = '1';
                gioielleria.QuotazioneOroNuovo = 0.0;
                gioielleria.ValutazioneOroVecchio = 0.0;
                gioielleria.QuotazioneArgentoNuovo = 0.0;
                gioielleria.ValutazioneArgentoVecchio = 0.0;
                string query = "insert into gioielleria (Id, Tipologia, Nome, Email, Password, QuotazioneOroNuovo, QuotazioneArgentoNuovo, ValutazioneOroVecchio, ValutazioneArgentoVecchio) values (UUID(), '1', '" + gioielleria.Nome + "', '" + gioielleria.Username + "', '" + gioielleria.Password + "', '" + gioielleria.QuotazioneOroNuovo + "', '" + gioielleria.ValutazioneOroVecchio + "', '" + gioielleria.QuotazioneArgentoNuovo + "', '" + gioielleria.ValutazioneArgentoVecchio + "')";
                string esito = metodiComuni.executeQuery(query, _clientSocket);

                if (esito == "Ok")
                {
                    this.modificato.Text = "Registrazione effettuata";
                }
            }
            Login Login = new Login();
            Hide();
            Login.ShowDialog();
            Show();
        }
    }
}
