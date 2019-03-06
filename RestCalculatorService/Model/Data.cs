using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCalculatorService.Model
{
    public class Data
    {
        private int _a;
        private int _b;

        public Data(int a, int b)
        {
            _a = a;
            _b = b; 
        }

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

        public int B
        {
            get { return _b; }
            set { _b = value; }
        }
    }
}
