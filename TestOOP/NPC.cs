using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class NPC : HerniPostava
    {

        public string prace;
        public int sila;
        bool boss;
        public NPC(bool boss,string prace,int sila,string jmeno) : base(jmeno)
        {
            this.jmeno = jmeno;
            this.prace = prace;
            this.sila = sila;   
        }
        
        public NPC(bool boss,string prace,string jmeno) : base(jmeno)
        {
            this.jmeno = jmeno;
            this.prace = prace;
            this.boss = boss;
        }

        public override string ToString()
        {
            if(boss)
            {
                return base.ToString() + " s prací:" + prace + " a sílou:" + sila;
            }
            else
            {
            return base.ToString()+" s prací:"+prace;
            }
            
        }
        
    }
}
