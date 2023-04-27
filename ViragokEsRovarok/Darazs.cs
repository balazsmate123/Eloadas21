using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViragokEsRovarok
{
    internal class Darazs:Rovar, IBeporzo
    {
        public void Beporoz(Virag virag)
        {
            virag.Beporoztak();
            virag.NektartAd();
        }

        public int GyujtottNektar()
        {
            return 0;
        }

        public Darazs(string nev)
        {
            base.Nev = nev;
        }

        public override string ToString()
        {
            return $"Darázs neve: {base.Nev}"; 
        }
    }
}
