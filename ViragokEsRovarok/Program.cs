using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViragokEsRovarok
{
    internal class Program
    {
        public static Random random= new Random();
        static void Main(string[] args)
        {
            try
            {
                Virag kankalin = new Virag(random, "Kankalin", random.Next(10, 40));
                int nektar = kankalin.NektartAd();
                Console.WriteLine(nektar);
                Console.WriteLine(kankalin.Nektar);
                Darazs lodarazs = new Darazs("Lódarázs");
                Console.WriteLine(lodarazs);
                Console.WriteLine(kankalin.BeporzasokSzama);
                lodarazs.Beporoz(kankalin);
                Console.WriteLine(kankalin.BeporzasokSzama);
                Console.WriteLine(lodarazs.GyujtottNektar());
                Console.WriteLine(kankalin.Nektar);
                Meh haziMeh = new Meh("Háziméh");
                haziMeh.Beporoz(kankalin);
                Console.WriteLine(haziMeh.GyujtottNektar());
                Console.WriteLine(kankalin.Nektar);
                Console.WriteLine(haziMeh);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            List<Virag> viragok = new List<Virag>();
            List<Rovar> rovarok = new List<Rovar>();
            StreamReader reader = new StreamReader("adatok.txt");
            while (!reader.EndOfStream)
            {
                string[] mezok = reader.ReadLine().Split(',');
                if (mezok[0] == "V")
                {
                    Virag virag = new Virag(random, mezok[0], int.Parse(mezok[2]));
                    viragok.Add(virag);
                }
                else if (mezok[0] == "D")
                {
                    Meh meh = new Meh(mezok[1]);
                    rovarok.Add(meh);
                }
                else {
                    Console.WriteLine("Hibás adat!");
                }
            }
            reader.Close();
            Console.ReadKey();
        }
    }
}
