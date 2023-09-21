using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
     interface MultipleAddition
    {
        int add(int a, int b);
    }
    interface Substraction
    {
        int sub(int x, int y);
    }
    class Calculation : MultipleAddition, Substraction
    {
        public int  res1;
         public int  add(int a,int b)
    {
        return res1 = a + b;
    }
    public int res2;
    public int sub(int x, int y)
    {
        return res2=x-y;
    }
    }
}
