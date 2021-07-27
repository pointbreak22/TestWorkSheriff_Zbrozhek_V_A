using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_СreateReceipt.ObjectsToRoundOf
{
    public class Round1 : Rounds
    {
        public Round1()
        {
            type = "type1";
            tostring = "F2";
        }

        public override double DoRound(double number)
        {
            number = Math.Round(number, 2);
            return number;
        }
    }
}