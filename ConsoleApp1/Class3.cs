using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animali
    {
        private string _razza;
        public string Razza { get; internal set; }

        public string Salute(string statoSalute)
        {
            if (statoSalute == "sano")
            {
                return "Vive";
            }
            else
            {
                return "Muore";
            }
        }
    }
}
