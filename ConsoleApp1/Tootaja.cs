using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tootaja : Isik
    {
        public string asutus;
        public string amet;

        public Tootaja(string asutus, string amet, string tootasu, string nimi, int synniaasta, Sugu isikSugu, double maksuvaba, double palk) : base(nimi, synniaasta, isikSugu, maksuvaba, palk)
        {
            this.asutus = asutus;
            this.amet = amet;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }
        public int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - synniaasta;
            return vanus;
        }

        public override void print_Info()
        {
            Console.WriteLine($"Te asutus koht on {asutus}, te amet on {amet} ja te tootasu on {arvutaSissetulek(palk, maksuvaba, tulumaks)}, te nimi on {nimi} {isikSugu} ja {arvutaVanus()}");
        }
    }
}