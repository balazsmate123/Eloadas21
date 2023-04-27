using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViragokEsRovarok
{
    internal class Meh : Rovar, IBeporzo
    {
        string nev;
        int gyujtottNektar_ml = 0;

        public void Beporoz(Virag virag)
        {
            virag.Beporoztak();
            virag.NektartAd();
        }

        public int GyujtottNektar()
        {
            return gyujtottNektar_ml;
        }

        public Meh(string meh)
        {
            base.Nev = nev;
        }

        public override string ToString()
        {
            return $"Méh neve:{base.Nev}\tGyűjtött nektár: {this.gyujtottNektar_ml}Ml";
        }

        public int GyujtottNektar_ml
        {
            get { return gyujtottNektar_ml; }
        }
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
