using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas4_4
{
    internal class Kates 
    {

        public string KatesVardas { get; set; }
        public string KatesVeisle { get; set; }
        public string KatesLytis { get; set; }
        public int KatesAmzius { get; set; }
        public int KatesSvoris { get; set; }
        public Kates (string vardas, string veisle, string lytis, int amzius, int svoris)
        {
            KatesVardas = vardas;
            KatesVeisle = veisle;
            KatesLytis = lytis;
            KatesAmzius = amzius;
            KatesSvoris = svoris;
        }
        public override string ToString()
        {
            return string.Format($" {KatesVardas,7} {KatesVeisle,14} {KatesLytis,10} {KatesAmzius,4}  {KatesSvoris,6}");
        }
        
    }
}
