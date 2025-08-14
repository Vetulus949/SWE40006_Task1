using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private bool bTest = false;
        public void test_method()
        { }
        public int add(int val1, int val2)
        {
            return val1 + val2;
        }
        public bool extra
        {
            get
            {
                return bTest;
            }
            set
            {
                bTest = extra;
            }
        }
    }
}

