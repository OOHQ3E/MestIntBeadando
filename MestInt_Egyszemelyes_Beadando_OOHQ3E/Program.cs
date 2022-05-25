using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MestInt_Egyszemelyes_Beadando_OOHQ3E.AllapotTer;
using MestInt_Egyszemelyes_Beadando_OOHQ3E.Keresok;

namespace MestInt_Egyszemelyes_Beadando_OOHQ3E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palya.Palyageneralas();
            BackTrack bt = new BackTrack(16);
            bt.Keres();
            foreach (Allapot a in bt.ut)
            {
                Console.WriteLine($"({a.pozicioX},{a.pozicioY}) {Palya.palya[a.pozicioY,a.pozicioX]}");
            }

            Console.ReadLine();
        }
        
    }
}
