using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //ChildClass cl= new ChildClass();
           // cl.Employee();
           // cl.Sal();
            //cl.Example();
            //Console.ReadLine();
           MethodOverLoading mo=new MethodOverLoading();
            Console.WriteLine(mo.Sum(1, 2));
            Console.WriteLine(mo.Sum(1, 2,3));
            Console.WriteLine(mo.Sum(1, 2,3,4));
            //Console.ReadLine();

            MethodOverRiding mr=new MethodOverRiding();
            Circle c=new Circle();
            Rectangle r=new Rectangle();
            mr.Draw();
            c.Draw();
            r.Draw();
            Console.ReadLine() ;

        }
    }
}
