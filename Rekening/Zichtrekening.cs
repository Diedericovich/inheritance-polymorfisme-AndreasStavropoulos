using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekening
{
    public class Zichtrekening : Rekening
    {
        public Zichtrekening(string rekeningNr, double saldo)
            : base(rekeningNr, saldo)
        {
            Minimum = -100;
        }
    }
}
