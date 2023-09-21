using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b=new Book();
            b.title = "Harry potter";
            b.author = "Rowling";
            b.pages = 400;
            Console.Write(b.title+" "+b.author+" "+b.pages);
            Console.ReadLine();
        }
    }
}
