using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpoiTest
{
    public class JalleData
    {
        public int OneNumber { get; set; }
        public string LittTekst { get; set; }
        public double EtStortTall { get; set; }

        public override string ToString()
        {
            return $"{OneNumber} / {LittTekst} / {EtStortTall}"; 
        }
    }
}
