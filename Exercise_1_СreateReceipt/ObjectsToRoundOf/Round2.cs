using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1_СreateReceipt.ObjectsToRoundOf
{
    internal class Round2 : Rounds
    {
        public Round2()
        {
            type = "type2";
            tostring = "F2";
        }

        public override double DoRound(double number)
        {
            number = Math.Round(number, 2);

            number *= 100;

            if (Math.Round(number % 10) == 5)
            {
                number /= 100;
            }
            else
            {
                number /= 10;
                number = Math.Round(number);
                number /= 10;
            }

            return number;
        }
    }
}