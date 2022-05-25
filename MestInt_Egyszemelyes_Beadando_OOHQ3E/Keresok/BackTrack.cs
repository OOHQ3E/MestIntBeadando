using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MestInt_Egyszemelyes_Beadando_OOHQ3E.AllapotTer;

namespace MestInt_Egyszemelyes_Beadando_OOHQ3E.Keresok
{
    internal class BackTrack
    {
        private int MelysegiKorlat;
        private List<Operator> operatorok = new List<Operator>();
        public List<Allapot> ut = new List<Allapot>();
        public BackTrack(int melysegiKorlat)
        {
            this.MelysegiKorlat = melysegiKorlat;
            operatorok.Add(new Operator(Irany.BAL));
            operatorok.Add(new Operator(Irany.JOBB));
            operatorok.Add(new Operator(Irany.FEL));
            operatorok.Add(new Operator(Irany.LE));
        }
        public void Keres()
        {
            Csucs csucs = new Csucs(new Allapot(), null);
            while (csucs != null && !csucs.Allapot.CelallapotE())
            {
                if (csucs.OperatorIndex < operatorok.Count && MelysegiKorlat >= csucs.Melyseg)
                {
                    Operator op = operatorok[csucs.OperatorIndex];
                    csucs.OperatorIndex++;

                    if (op.AlkalmazhatoE(csucs.Allapot))
                    {
                        Allapot ujAllapot = op.Lepes(csucs.Allapot);
                        Csucs ujCsucs = new Csucs(ujAllapot, csucs);
                        if (!ujCsucs.vanEbenneKor())
                        {
                            csucs = ujCsucs;
                        }
                    }
                }
                else
                {
                    csucs = csucs.SzuloCsucs;
                }
            }
            while (csucs != null)
            {
                ut.Add(csucs.Allapot);
                csucs = csucs.SzuloCsucs;
            }
            ut.Reverse();
        }
    }
}
