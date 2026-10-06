using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Maxnumber
    {
        public double maxnum(double[] numbers)
        {
            var result = 0;
            foreach (var elm in numbers)
            {
                if (elm > result)
                    result = (int)elm;
            }
            return result;
        }
    }
}