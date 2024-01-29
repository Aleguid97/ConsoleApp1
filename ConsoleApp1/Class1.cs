using System;

namespace ConsoleApp1
{
    public class Autovetture
    {
        private string _marca;

        public string Marca { get; internal set; }

        public string KmTagliando(int attuale)
        {
            if (attuale > 10000)
            {
                return "Tagliando da effettuare";
            }
            else
            {
                return "Puoi risparmiare, per ora";
            }
        }
    }

}
