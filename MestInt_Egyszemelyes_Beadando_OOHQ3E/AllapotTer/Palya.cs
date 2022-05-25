using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestInt_Egyszemelyes_Beadando_OOHQ3E.AllapotTer
{
    public class Palya
    {
        public static Blokk[,] palya = new Blokk[8,8];

        public static void Palyageneralas()
        {
            palya[0, 0] = Blokk.L();
            palya[0, 1] = Blokk.JL();
            palya[0, 2] = Blokk.JB();
            palya[0, 3] = Blokk.BL();
            palya[0, 4] = Blokk.JL();
            palya[0, 5] = Blokk.JB();
            palya[0, 6] = Blokk.BL();
            palya[0, 7] = Blokk.L();

            palya[1, 0] = Blokk.FLJ();
            palya[1, 1] = Blokk.BF();
            palya[1, 2] = Blokk.L();
            palya[1, 3] = Blokk.FLJ();
            palya[1, 4] = Blokk.BF();
            palya[1, 5] = Blokk.JL();
            palya[1, 6] = Blokk.FLB();
            palya[1, 7] = Blokk.FL();

            palya[2, 0] = Blokk.JF();
            palya[2, 1] = Blokk.BL();
            palya[2, 2] = Blokk.FL();
            palya[2, 3] = Blokk.FL();
            palya[2, 4] = Blokk.JL();
            palya[2, 5] = Blokk.BF();
            palya[2, 6] = Blokk.FLJ();
            palya[2, 7] = Blokk.BF();

            palya[3, 0] = Blokk.L();
            palya[3, 1] = Blokk.JF();
            palya[3, 2] = Blokk.FLB();
            palya[3, 3] = Blokk.FL();
            palya[3, 4] = Blokk.JF();
            palya[3, 5] = Blokk.BL();
            palya[3, 6] = Blokk.JF();
            palya[3, 7] = Blokk.BL();

            palya[4, 0] = Blokk.FLJ();
            palya[4, 1] = Blokk.B();
            palya[4, 2] = Blokk.FL();
            palya[4, 3] = Blokk.FLJ();
            palya[4, 4] = Blokk.B();
            palya[4, 5] = Blokk.JF();
            palya[4, 6] = Blokk.JB();
            palya[4, 7] = Blokk.FLB();

            palya[5, 0] = Blokk.FL();
            palya[5, 1] = Blokk.JL();
            palya[5, 2] = Blokk.BF();
            palya[5, 3] = Blokk.JF();
            palya[5, 4] = Blokk.JB();
            palya[5, 5] = Blokk.JBL();
            palya[5, 6] = Blokk.BL();
            palya[5, 7] = Blokk.FL();

            palya[6, 0] = Blokk.FL();
            palya[6, 1] = Blokk.JF();
            palya[6, 2] = Blokk.BL();
            palya[6, 3] = Blokk.JL();
            palya[6, 4] = Blokk.BL();
            palya[6, 5] = Blokk.FL();
            palya[6, 6] = Blokk.F();
            palya[6, 7] = Blokk.FL();

            palya[7, 0] = Blokk.JF();
            palya[7, 1] = Blokk.JB();
            palya[7, 2] = Blokk.JBF();
            palya[7, 3] = Blokk.BF();
            palya[7, 4] = Blokk.F();
            palya[7, 5] = Blokk.JF();
            palya[7, 6] = Blokk.JB();
            palya[7, 7] = Blokk.BF();
        }

    }
}
