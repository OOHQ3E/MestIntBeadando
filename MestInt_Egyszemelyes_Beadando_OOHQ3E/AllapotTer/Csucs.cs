using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestInt_Egyszemelyes_Beadando_OOHQ3E.AllapotTer
{
    internal class Csucs
    {
        public Csucs(Allapot allapot, Csucs szulo)
        {
            Allapot = allapot;
            SzuloCsucs = szulo;
            if (szulo == null)
            {
                Melyseg = 0;
            }
            else
            {
                Melyseg = szulo.Melyseg + 1;
            }

            OperatorIndex = 0;
        }
        public bool vanEbenneKor()
        {
            Csucs c = this.SzuloCsucs;
            while (c != null)
            {
                if (c.Equals(this))
                {
                    return true;
                }
                c = c.SzuloCsucs;
            }

            return false;
        }

        public Allapot Allapot;
        public Csucs SzuloCsucs;
        public int Melyseg;
        public int OperatorIndex;

        public override bool Equals(object obj)
        {
            Csucs tmp = obj as Csucs;
            if (tmp == null) return false;
            return tmp.Allapot.Equals(this.Allapot);
        }

        
    }
}
