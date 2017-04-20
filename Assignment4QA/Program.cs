using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4QA
{
   public  class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Choose one of following options");
                Console.WriteLine("1\tEnter triangle dimensions");
                Console.WriteLine("2\tExit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        FirstOption();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (choice != "2");
        }

        static void FirstOption()
        {
            Console.WriteLine("First Number : ");
            int sideA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second Number : ");
            int sideB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Third Number : ");
            int sideC = Int32.Parse(Console.ReadLine());


            string triangleType = TriangleSolver.Analyze(sideA, sideB, sideC);
            Console.WriteLine("Your Triangle is " + triangleType);
        }

    }
}
