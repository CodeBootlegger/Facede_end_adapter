using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Adapte;
using ConsoleApp1.Source;

namespace ConsoleApp1.Adapter
{
    public class SquarePegAdapter : IRoundPeg
    {
        SquarePeg peg = null;
        public int GetRadius()
        {
            int halfWidht = peg.GetWidht() / 2;
            return (int)Math.Sqrt(Math.Pow((halfWidht), 2) * 2);
        }
        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }
    }
}
