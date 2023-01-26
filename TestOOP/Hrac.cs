using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class Hrac : HerniPostava
    {
        string oblicej;
        string vlasy;
        string barvavlasu;
        public int xp = 0;
        



        string specializace;
        string Specializace
        {
            get
            {
                return specializace;
            }
            set
            {
                Specializace = value;
            }
        }
        public Hrac(string specializace,string oblicej,string vlasy,string barvavlasu,int xp,string jmeno) : base(jmeno)
        {
            this.jmeno = jmeno;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvavlasu = barvavlasu;
            this.xp = xp;
            this.specializace = Specializace;

        }
       public string PridejXP(int addxp)
        {
            xp = xp + addxp;
            if(xp/(level * 100) >= 1)
            {
                level++;
                xp = 0;
            }
            return "Hodnota xp byla zvýšena o: " + addxp + " Nynější XP je: " + xp;
        }

        public override string ToString()
        {
            return base.ToString() + " s obličejem: " + oblicej + " s vlasy: " + vlasy + " s barvou vlasů: " + barvavlasu + " a s xp: " + xp;
        }
    }
}
