using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_СreateReceipt.ObjectsForCheck
{
    [Serializable]
    public class СheckTape      //Чековая лента
    {
        public List<Check> Checks { get; set; }
        public int CountChecks { get; set; }
        public double SumAllChecks { get; set; }
    }
}