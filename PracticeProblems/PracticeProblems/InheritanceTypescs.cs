using PracticeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class InheritanceTypescs
    {
        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h)
        {

            height = h;

        }
        protected int width;
        protected int height;
    }

    class square : InheritanceTypescs
    {
        public int GetArea()
        {
            return (width * height);
        }

    }
}

