using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Encapsulation
    {
        private int atmpin;
         public int getReturn()
        {
            return atmpin;
        }
        public void setValue(int pin)
        {
            atmpin= pin; 
        }
    }
}
