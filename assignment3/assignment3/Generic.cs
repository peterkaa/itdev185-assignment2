using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Generic<T1, T2>
    {
        public T1 firstProperty { get; set; }
        public T2 secondProperty { get; set; }

        public override string ToString()
        {
            return "\n\t" + firstProperty + ", " + secondProperty; 
        }

    }
}
