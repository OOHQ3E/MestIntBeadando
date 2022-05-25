using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MestInt_Egyszemelyes_Beadando_OOHQ3E.AllapotTer;

namespace MestInt_Egyszemelyes_Beadando_OOHQ3E
{
    public class Blokk
    {
        private List<Blokk> blokkok = new List<Blokk>();
        public Blokk(bool mehetJobbra,bool mehetBalra,bool mehetFel, bool mehetLe)
        {
            this.mehetJobbra = mehetJobbra;
            this.mehetBalra = mehetBalra;
            this.mehetFel = mehetFel;
            this.mehetLe = mehetLe;
        }

        //egyirány Jobb
        public static Blokk J()
        {
            return new Blokk(true, false, false, false);
        }
        //egyirány Bal
        public static Blokk B()
        {
            return new Blokk(false, true, false, false);
        }
        //egyirány Fel
        public static Blokk F()
        {
            return new Blokk(false, false, true, false);
        }
        //egyirány Le
        public static Blokk L()
        {
            return new Blokk(false, false, false, true);
        }
        //vízszintes Bal-Jobb
        public static Blokk JB()
        {
            return new Blokk(true, true, false, false);
        }
        //függőleges Fel-Le
        public static Blokk FL()
        {
            return new Blokk(false, false, true, true);
        }
        //háromirányú függéleges - Jobb
        public static Blokk FLJ()
        {
            return new Blokk(true, false, true, true);
        }
        //háromirányú függéleges - Bal
        public static Blokk FLB()
        {
            return new Blokk(false, true, false, true);
        }
        //háromirányú vízszintes - Fel
        public static Blokk JBF()
        {
            return new Blokk(true, true, true, false);
        }
        //háromirányú vízszintes - Le
        public static Blokk JBL()
        {
            return new Blokk(true, true, false, true);
        }

        public static Blokk BF()
        {
            return new Blokk(false, true, true, false);
        }
        public static Blokk JF()
        {
            return new Blokk(true, false, true, false);
        }
        public static Blokk BL()
        {
            return new Blokk(false, true, false, true);
        }
        public static Blokk JL()
        {
            return new Blokk(true, false, false, true);
        }


        private bool mehetJobbra;

        public bool MehetJobbra
        {
            get => mehetJobbra;
            set => mehetJobbra = value;
        }
        private bool mehetBalra;
        public bool MehetBalra
        {
            get => mehetBalra;
            set => mehetBalra = value;
        }

        private bool mehetFel;
        public bool MehetFel
        {
            get => mehetFel;
            set => mehetFel = value;
        }

        private bool mehetLe;
        public bool MehetLe
        {
            get => mehetLe;
            set => mehetLe = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("lehetséges irányok: ");
            sb.Append($"(");
            sb.Append(mehetJobbra ? "Jobbra " : "");
            sb.Append(mehetBalra ? " Balra" : "");
            sb.Append(mehetFel ? " Fel" : "");
            sb.Append(mehetLe ? " Le" : "");
            
           
            sb.Append(")");

            return sb.ToString();
        }
    }
}
