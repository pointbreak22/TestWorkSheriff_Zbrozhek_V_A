using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_СreateReceipt.ObjectsForCheck
{
    [Serializable]
    public class Check       //Чеки
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double SumPriceLines { get; set; }
        public List<LineInCheck> LineInChecks { get; set; }
    }
}