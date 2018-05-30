using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Adapter;
using ConsoleApp1.Adapte;
using ConsoleApp1.Source;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RoundHole hole = new RoundHole(10);
            RoundPeg round = new RoundPeg(9);
            SquarePeg square = new SquarePeg(8);
            SquarePegAdapter Adapte = new SquarePegAdapter(square);

          
            if (hole.Fits(round)==true)
            {
                Console.WriteLine("Круглый влез");
            }
            else
            {
                Console.WriteLine("Круглый не влез");
            }
            Console.WriteLine("==================");

            if(hole.Fits(Adapte) == true)
            {
                Console.WriteLine("Обрезали квадрат и он влез!");
            }
            else
            {
                Console.WriteLine("Обрезание не помогло");
            }
        }
    }
}
