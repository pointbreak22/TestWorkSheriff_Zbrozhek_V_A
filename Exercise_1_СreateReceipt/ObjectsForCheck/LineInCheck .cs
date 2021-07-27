using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_СreateReceipt.ObjectsForCheck
{
    [Serializable]
    public class LineInCheck   //строки в чеке
    {
        public int Number { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public double SumPrice { get; set; }
    }
}