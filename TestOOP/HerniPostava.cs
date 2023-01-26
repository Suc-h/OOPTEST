using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOOP
{
    class HerniPostava
    {
        protected string jmeno;
        protected int level = 1;
        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
        }

        string Jmeno
        {
            get
            {
                return jmeno;

            }
            set
            {
                if(value.Length>10)
                {
                    MessageBox.Show("Jmeno je příliš dlouhé!");
                    jmeno = "null";
                }
                else
                {
                    jmeno = value;
                }
            }
        }

        protected int x;
        protected int y;
        int X
        {
            get
            { 
                return x; 
            }
        }
    
        int Y
        {
        get
        {
            return y;
        }
        }
        public virtual void ZmenaPozice(int a,int b)
        {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return "Postava se jménem: " + Jmeno + " levelem: " + level + " na pozici X a Y: " + x+ "  "+ y;
        }
    }
}
