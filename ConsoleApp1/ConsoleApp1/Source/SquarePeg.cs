using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Adapter;

namespace ConsoleApp1.Source
{
   public class SquarePeg
    {
        int width = 15;
        public int GetWidht()
        {
            return width;
          
        }
        public SquarePeg(int width)
        {
            this.width = width;
        }
        
    }
}
