using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dipendenti
    {
        private string _ruolo;
        public string Ruolo { get; internal set; }

        public string Rendimento(int attuale)
        {
            if (attuale > 100)
            {
                return "Promosso";
            }
            else
            {
                return "Licenziato";
            }
        }
    }

}
    
