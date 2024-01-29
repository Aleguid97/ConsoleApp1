using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleti

    {
        private string _disciplina;
        public string Disciplina { get; internal set; }

        public string Infortunio(bool statoInfortunio)
        {
            if (statoInfortunio)
            {
                return "Infortunato";
            }
            else
            {
                return "Non infortunato";
            }
        }
    }
        }
   

