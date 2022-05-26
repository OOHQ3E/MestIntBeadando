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
            int melysegiKorlat = 15;
            Console.WriteLine($"Bagoly Gábor - OOHQ3E" +
                              $"\n2.11-es feladat körfigyeléses mélyégi korlátos backtrack-kel megoldva" +
                              $"\nMélységi korlát: {melysegiKorlat}" +
                              $"\neredmény:\n");
            Palya.Palyageneralas();
            BackTrack bt = new BackTrack(melysegiKorlat);
            bt.Keres();
            foreach (Allapot a in bt.ut)
            {
                Console.WriteLine($"({a.pozicioX},{a.pozicioY}) {Palya.palya[a.pozicioY,a.pozicioX]}");
            }

            if (bt.ut.Count == 0)
            {
                Console.WriteLine($"Nincs megoldás a megadott mélységi korláttal ({melysegiKorlat})");
            }

            Console.ReadLine();
        }
        
    }
}
