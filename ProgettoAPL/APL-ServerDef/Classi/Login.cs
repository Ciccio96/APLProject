using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APL_ServerDef.Classi
{
    class Accesso
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Tipologia { get; set; } = 2;
    }
}
