using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Config
{
    class DescendingCompare : IComparer<String>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y) * -1;
        }
    }
}
