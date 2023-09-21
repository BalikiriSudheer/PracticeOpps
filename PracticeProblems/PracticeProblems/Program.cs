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
           //MethodOverLoading mo=new MethodOverLoading();
            //Console.WriteLine(mo.Sum(1, 2));
           // Console.WriteLine(mo.Sum(1, 2,3));
            //Console.WriteLine(mo.Sum(1, 2,3,4));
            //Console.ReadLine();

           // MethodOverRiding mr=new MethodOverRiding();
            //Circle c=new Circle();
            //Rectangle r=new Rectangle();
            //mr.Draw();
            //c.Draw();
            //r.Draw();
            //Encapsulation e=new Encapsulation();
            //e.setValue(4567);
           // Console.WriteLine("ATM PIN "+e.getReturn());

          //  Student a=new Student();
          //  a.Farmer();
           // a.Work();

           // square s= new square();
           // s.SetHeight(7);
           // s.SetWidth(8);
           //
           //Console.WriteLine("Total area:{0}", s.GetArea());
            //Demo d=new Demo();
            //d.Print();
            //d.PrintHello();

            Calculation c=new Calculation();
            c.add(2, 34);
            c.sub(87 ,54);
            Console.WriteLine("addition is : "+ c.res1);
            Console.WriteLine("substracion is : " +c.res2);
            Console.ReadLine();

        }
    }
}
