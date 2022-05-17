using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNěmec
{
    internal class Kamion
    {
        public int maxcarry { get; }
        public int maxfuel { get; }
        public int consum { get; }
        public int distance { get; }
        public int currentcarry { get; set; }
        public int currentfuel { get; set; }

        public Kamion(int nosnost, int nadrz, int spotreba)
        {
            maxfuel = nadrz;
            consum = spotreba;
            maxcarry = nosnost;
            distance = 0;
            currentcarry = 0;
            currentfuel = 0;
        }
        public void Jet(int distance)
        {
            
        }
        
    }
}
