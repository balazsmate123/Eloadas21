using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViragokEsRovarok
{
    public abstract class Rovar
    {
        string nev;
        public string Nev
        {
            get { return nev; }
            set
            {
                if (value.Length >= 3)
                {
                    nev = value;
                }
                else
                {
                    throw new ArgumentException("A megadott név túl rövid!");
                }
            }
        }

    }
}
