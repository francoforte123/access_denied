using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_denied
{
    internal class ClassAccess{

        public int number1= 1;
        private int number2 = 2;
        protected int number3 = 3;
        internal int number4 = 4;

        public int getNumber2 { get => number2; }
        public int getNumber3 { get => number3; }
    }
}
