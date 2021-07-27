using Exercise_1_СreateReceipt.ObjectsForCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_СreateReceipt
{
    public class Generator
    {
        private Random random = new Random();
        public СheckTape tape { get; set; }
        private List<string> week = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public Generator()
        {
            tape = new СheckTape();
        }

        public double RandomNext(int min, int max)
        {
            return random.Next(min, max);
        }

        public void Gemerate()
        {
            tape.Checks = new List<Check>();
            double sumChecks = 0;
            for (int i = 0; i < 100; i++)
            {
                Check check = new Check();
                check.Number = i + 1;
                check.Date = DateTime.Now.AddDays(RandomNext(0, 7) - week.IndexOf(DateTime.Now.DayOfWeek.ToString()));
                check.LineInChecks = new List<LineInCheck>();
                double sumPriceLines = 0;
                for (int j = 0; j < 10; j++)
                {
                    LineInCheck lineInCheck = new LineInCheck();
                    lineInCheck.Number = j + 1;
                    lineInCheck.Count = RandomNext(1, 20);
                    lineInCheck.Price = RandomNext(105, 10000) / 100;
                    lineInCheck.SumPrice = lineInCheck.Count * lineInCheck.Price;
                    sumPriceLines += lineInCheck.SumPrice;
                    check.LineInChecks.Add(lineInCheck);
                }
                tape.Checks.Add(check);
                check.SumPriceLines = sumPriceLines;
                sumChecks = check.SumPriceLines;
            }
            tape.CountChecks = tape.Checks.Count();
            tape.SumAllChecks = sumChecks;
        }
    }
}