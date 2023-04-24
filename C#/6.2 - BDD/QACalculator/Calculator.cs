using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class Calculator
    {
        private int answer;

        public Calculator()
        {
            this.answer = 0;
        }

        public void AddTwoNumber(int x, int y)
        {
            this.answer = x + y;
        }

        public int GetResult()
        {
            return this.answer;
        }
    }
}
