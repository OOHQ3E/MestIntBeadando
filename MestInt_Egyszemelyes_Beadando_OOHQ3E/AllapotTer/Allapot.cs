using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestInt_Egyszemelyes_Beadando_OOHQ3E.AllapotTer
{
    internal class Allapot
    {
        public int pozicioX;
        public int pozicioY;

        public Allapot()
        {
            pozicioX = 0;
            pozicioY = 0;
        }

        public bool CelallapotE()
        {
            if (pozicioX == 7 && pozicioY == 7)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            Allapot tmp = obj as Allapot;
            if (tmp == null) return false;
            if (tmp.pozicioX == pozicioX && tmp.pozicioY == pozicioY)
            {
                return true;
            }
            return false;
        }
    }
}
