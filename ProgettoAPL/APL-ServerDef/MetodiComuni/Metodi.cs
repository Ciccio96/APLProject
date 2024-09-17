using APL_ServerDef.Socket_Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace APL_ServerDef.MetodiComuni
{
    public class Metodi
    {
        //Metodo generale per inviare query al server e ricevere l'esito in caso di operazione andata a buonfine (per create e update)
        public string executeQuery(string query, ClientSocket clientSocket)
        {
            clientSocket.SendData(query);
            var receiver = clientSocket.ReceiveData();
            string str = receiver.Substring(0, 2);
            return str;
        }

        //Metodo che restituisce una lista di stringhe (poco efficiente nel caso si debba restituire un solo elemento)
        public List<string[]> definisciLista(string query, ClientSocket clientSocket, string bytesRead)
        {
            clientSocket.SendData(query);
            bytesRead = clientSocket.ReceiveData();
            string val = bytesRead.ToString();
            string[] arrs = val.Split('+');
            List<string[]> splittedVal = new List<string[]>();
            List<string[]> valueToSend = new List<string[]>();
            List<string[]> valueToSendGioielleria = new List<string[]>();
            List<string[]> valueToSendCliente = new List<string[]>();
            for (int i = 0; i < arrs.Length; i++)
            {
                splittedVal.Add(arrs[i].Split(','));
            }

            for (int i = 0; i < splittedVal.Count; i++)
            {
                if (splittedVal[i].Length == 9)
                {
                    valueToSendGioielleria.Add(splittedVal[i]);
                }
                if (splittedVal[i].Length == 8)
                {
                    valueToSendCliente.Add(splittedVal[i]);
                }
            }

            valueToSend = (valueToSendCliente.Count > 0) ? valueToSendCliente : valueToSendGioielleria;

            return valueToSend;
        }

        public List<string[]> informazioniUtente(string query, ClientSocket clientSocket)
        {
            List<string[]> splittedVal = new List<string[]>();
            clientSocket.SendData(query);
            var bytes = clientSocket.ReceiveData();
            string val = bytes.ToString();
            string[] arrs = val.Split('+');

            for (int i = 0; i < arrs.Length; i++)
            {
                splittedVal.Add(arrs[i].Split(','));
            }

            return splittedVal;
        }

        //Metodo utilizzato piu volte (evita ridondanze di codice)
        public double effettuaCalcoloValutazione(string value, string input)
        {
            //Il CultureInfo nella chiamata a metodo ToDouble serve a normalizzare l'utilizzo di . o , nei decimali

            double calcolo = Convert.ToDouble(value, CultureInfo.InvariantCulture) * Convert.ToDouble(input, CultureInfo.InvariantCulture);

            return calcolo;

        }

        //Metodo che restituisce una tupla di elementi (uno di tipo double e una lista di stringhe)
        public (double, List<string>) effettuaValutazione(List<string[]> array, string input, string tipo)
        {
            List<string> buf = new List<string>();
            List<double> bestEvaluation = new List<double>();
            double opForNew;
            double opForOld;
            for (int i = 0; i < array.Count; i++)
            {
                if (tipo == "Oro")
                {
                    opForNew = effettuaCalcoloValutazione(array[i][5], input);
                    opForOld = effettuaCalcoloValutazione(array[i][7], input);
                }
                else
                {
                    opForNew = effettuaCalcoloValutazione(array[i][6], input);
                    opForOld = effettuaCalcoloValutazione(array[i][8], input);
                }

                buf.Add("");
                buf.Add("  " + array[i][2] + "  ");
                buf.Add("_______________________________________________________________________________________________________________________________");
                buf.Add("");
                buf.Add(" Da Nuovo : " + Math.Round(opForNew, 2) + " €");
                buf.Add(" Valutazione : " + Math.Round(opForOld, 2) + " €");
                buf.Add("_______________________________________________________________________________________________________________________________");
                bestEvaluation.Add(Math.Round(opForOld, 2));

            }
            double max = bestEvaluation.Max();

            return (max, buf);
        }

        //Metodo utilizzato piu volte (evita ridondanze di codice)
        public List<string> mostraQuotazioni(List<string[]> array, string tipo)
        {
            List<string> buf = new List<string>();
            for (int i = 0; i < array.Count; i++)
            {
                buf.Add("");
                buf.Add("  " + array[i][2] + "  ");
                buf.Add("_______________________________________________________________________________________________________________________________");
                buf.Add("");

                if (tipo == "Argento")
                {
                    buf.Add("Argento Nuovo : " + array[i][6] + " €/gr");
                    buf.Add("Argento Usato : " + array[i][8] + " €/gr");
                }
                else
                {
                    buf.Add(" Oro Nuovo : " + array[i][5] + " €/gr");
                    buf.Add(" Oro Usato : " + array[i][7] + " €/gr");
                }

                buf.Add("_______________________________________________________________________________________________________________________________");
            }
            return buf;
        }
        
        public List<string> informazioniGioielleria(List<string[]> array, ClientSocket clientsocket)
        {
            List<string> buf = new List<string>();
            buf.Add("");
            buf.Add("  " + array[0][2] + "  ");
            buf.Add("________________________________________________________________________________________________________________________________");
            buf.Add("");
            buf.Add(" Oro Nuovo : " + array[0][5] + " €/gr");
            buf.Add(" Oro Usato : " + array[0][7] + " €/gr");
            buf.Add(" Argento Nuovo : " + array[0][6] + " €/gr");
            buf.Add(" Argento Usato : " + array[0][8] + " €/gr");
            buf.Add("________________________________________________________________________________________________________________________________");

            return buf;

        }

        //Metodo utilizzato piu volte (evita ridondanze di codice)
        public double modificaQuotazione(string item)
        {
            var rounded = Math.Round(Convert.ToDouble(item, CultureInfo.InvariantCulture), 2);
            return rounded;
        }

    }
        
}
