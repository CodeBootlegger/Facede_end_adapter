using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Source;

namespace ConsoleApp1.Adapte
{
   public class RoundHole 
    {
        int radius = 0;

        public RoundHole(int radius)
        {
            this.radius = radius;
        }
        public int GetRadius()
        {
            return radius;
        }
        public bool Fits(IRoundPeg roundPeg)
        {
            if (radius > roundPeg.GetRadius())
            {
                return true;
            }
            else
                return false;
        }

    }
}
