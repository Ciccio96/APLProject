using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_ServerDef.Classi
{
    class Cliente : Accesso
    {
        public string Cognome { get; set; }
        public int TipoPreferito { get; set; }
        public int MaterialePreferito { get; set; }

    }
}
