using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViragokEsRovarok
{
    internal class Virag
    {
        Random random;
        string nev;
        int beporzasokSzama = 0;
        int nektar; //ml

        public int Nektar
        {
            get { return nektar; }
            set 
            { 
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException($"A megadott érték: {value} nem megfelelő!");
                }
                nektar = value;
            }
        }
        public int BeporzasokSzama
        {
            get { return beporzasokSzama; }
        }

        public string Nev
        {
            get { return nev; }
            set {
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

        public int NektartAd()
        {
            int adottNektar = 0;
            if(nektar >= 5)
            {
                adottNektar = random.Next(5)+1;
            }
            else
            {
                adottNektar = random.Next(nektar) + 1;
            }
            nektar -= adottNektar;
            return adottNektar;
        }

        public void Beporoztak()
        {
            beporzasokSzama++;
        }

        public Virag (Random random, string nev, int nektar)
        {
            this.random = random;
            Nev = nev;
            Nektar = nektar;
        }
    } 
}
