using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestInt_Egyszemelyes_Beadando_OOHQ3E.AllapotTer
{
    class Operator
    {
        public Operator(Irany merre)
        {
            this.Merre = merre;
        }

        public Irany Merre;

        public bool AlkalmazhatoE(Allapot allapot)
        {
            if (Merre == Irany.BAL && Palya.palya[ allapot.pozicioY, allapot.pozicioX].MehetBalra)
            {
                return true;
            }
            if (Merre == Irany.JOBB && Palya.palya[allapot.pozicioY, allapot.pozicioX].MehetJobbra)
            {
                return true;
            }
            if (Merre == Irany.FEL && Palya.palya[allapot.pozicioY, allapot.pozicioX].MehetFel)
            {
                return true;
            }
            if (Merre == Irany.LE && Palya.palya[allapot.pozicioY, allapot.pozicioX].MehetLe)
            {
                return true;
            }
            return false;
        }

        public Allapot Lepes(Allapot allapot)
        {
            Allapot ujAllapot = new Allapot();
            ujAllapot.pozicioX = allapot.pozicioX;
            ujAllapot.pozicioY = allapot.pozicioY;
            if (Merre == Irany.BAL)
            {
                ujAllapot.pozicioX--;
            }
            if (Merre == Irany.JOBB)
            {
                ujAllapot.pozicioX++;
            }
            if (Merre == Irany.FEL)
            {
                ujAllapot.pozicioY--;
            }
            if (Merre == Irany.LE)
            {
                ujAllapot.pozicioY++;
            }
            return ujAllapot;
        }


    }
}
