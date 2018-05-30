using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Adapte;

namespace ConsoleApp1.Source
{
    public class RoundPeg:IRoundPeg
    {
        int radius = 0;
        public RoundPeg(int radius)
        {
            this.radius = radius;
        }
        public void Radius(int radius)
        {
            this.radius = radius;
           
        }
        public int GetRadius()
        {
            return radius;
        }
    }
}
