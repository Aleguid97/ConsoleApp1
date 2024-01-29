using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autovetture auto1 = new Autovetture();
            auto1.Marca = "Ferrari";

            Autovetture auto2 = new Autovetture();
            auto2.Marca = "Renault";

            Console.WriteLine("Auto1:" + auto1.Marca);
            Console.WriteLine("\n");

            Console.WriteLine("Auto2:" + auto2.Marca);
            Console.WriteLine("\n");

            auto1.Marca = "BMW";
            Console.WriteLine("Auto1 Aggiornata:" + auto1.Marca);

            string Messaggio = auto1.KmTagliando(500);
            Console.WriteLine(Messaggio);
            Console.WriteLine("\n");

            string altroMessaggio = auto2.KmTagliando(15000);
            Console.WriteLine(altroMessaggio);

            Console.WriteLine("\n");

            Dipendenti dip1 = new Dipendenti();
            dip1.Ruolo = "WebDev";

            Dipendenti dip2 = new Dipendenti();
            dip2.Ruolo = "WebDes";

            Console.WriteLine("dip1:" + dip1.Ruolo);
            Console.WriteLine("\n");

            Console.WriteLine("dip2:" + dip2.Ruolo);
            Console.WriteLine("\n");

            string Avviso = dip1.Rendimento(50);
            Console.WriteLine(Avviso);
            Console.WriteLine("\n");

            string altroAvviso = dip2.Rendimento(150);
            Console.WriteLine(altroAvviso);

            Console.WriteLine("\n");

            Animali cane1 = new Animali();
            cane1.Razza = "Chihuahua";

            Animali cane2 = new Animali();
            cane2.Razza = "Patore del Caucaso";

          Console.WriteLine("cane1:"+ cane1.Razza);
            Console.WriteLine("\n");
            Console.WriteLine("cane2:" + cane2.Razza);

            string Notizia = cane1.Salute("schifo");
            Console.WriteLine(Notizia);
            string Notizia2 = cane2.Salute("sano");
            Console.WriteLine(Notizia2);

            Console.WriteLine("\n");

            Atleti atl1 = new Atleti();
            atl1.Disciplina = "maratona";

            Atleti atl2 = new Atleti();
            atl2.Disciplina = "boxe";

            Console.WriteLine("atl1:" + atl1.Disciplina);
            Console.WriteLine("\n");
            Console.WriteLine("atl2" +  atl2.Disciplina);

            string diagnosi = atl1.Infortunio(true);
            Console.WriteLine(diagnosi);
            string diagnosi2= atl2.Infortunio(false);
            Console.WriteLine(diagnosi2);




            Console.ReadLine();


        }
    }
}
