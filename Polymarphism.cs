using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Polymarphism
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        //overloding
        public int sum(int x, int y)
        {
            return x+y;
        }
        public float sum(float x, float y)
        {
            return x + y;
        }

    }
}
