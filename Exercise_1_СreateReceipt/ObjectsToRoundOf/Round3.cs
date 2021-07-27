using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_СreateReceipt.ObjectsToRoundOf
{
    internal class Round3 : Rounds
    {
        public Round3()
        {
            type = "type3";
            tostring = "F1";
        }

        public override double DoRound(double number)
        {
            number = Math.Round(number, 1);
            return number;
        }
    }
}