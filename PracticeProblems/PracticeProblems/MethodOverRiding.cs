using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class MethodOverRiding
    {
        public virtual void Draw()
        {
            Console.WriteLine("Iam drawing a shape");
        }
    }
   class Circle : MethodOverRiding
    {
        public override void Draw()
        {
            Console.WriteLine(" i am drawing a Circle");
        }
    }
    class Rectangle : MethodOverRiding
    {
        public override void Draw()
        {
            Console.WriteLine("I am drawing a rectangle");
        }
    }
}
