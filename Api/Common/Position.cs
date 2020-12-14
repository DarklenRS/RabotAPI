using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Common
{
    public class Position
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Position(int x, int y, int z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
