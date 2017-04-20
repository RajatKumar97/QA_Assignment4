using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4QA
{
  public  static class  TriangleSolver
    {
        public static string Analyze(int x, int y, int z)
        {
            if (x < (y + z) && y < (x + y) && z < (x + y))
            {
                Console.WriteLine("Triangle Forms");
                if (x == y && y == z && x == z)
                {
                    return "Equilateral";
                }

                if (x == y || y == z || x == z)
                {
                    return "Isosceles";
                }
                else
                {
                    return "Scalene";
                }
            }
            else
            {
                Console.WriteLine("Triangle doesnt form");
                return "Invalid";
            }





        }
    }
}

