using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class SingleInheritance

    {
        public void PrintHello()
        {
            Console.WriteLine("Hello How Are You");
        }
    }
    class Demo: SingleInheritance
    {
        public void Print()
        {
            Console.WriteLine("What are doing ");
        }
    }
}
