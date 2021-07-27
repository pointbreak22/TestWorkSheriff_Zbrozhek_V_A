using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_СreateReceipt.ObjectsToRoundOf
{
    public abstract class Rounds
    {
        public string type;
        public string tostring;

        public abstract double DoRound(double number);
    }
}