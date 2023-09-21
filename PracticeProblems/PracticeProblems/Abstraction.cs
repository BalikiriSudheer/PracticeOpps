using PracticeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal abstract class Abstraction
    {

        public void Farmer()
        {
            Console.WriteLine("It Works-----");
        }
        public abstract void Work();
    }
    }
    class Student : Abstraction
{
        public override void Work()
        {
            Console.WriteLine("It studies");
        }
    }

