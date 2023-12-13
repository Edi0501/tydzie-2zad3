using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tydzień2zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            double szerokość = 5;
            double długość = 10;
            double diagonal;

            do
            {
                Console.WriteLine("Enter the desired width:");
                szerokość = Convert.ToDouble(Console.ReadLine());

                if (szerokość != 0)
                {
                    Console.Write("Enter the desired height: ");
                    długość = Convert.ToDouble(Console.ReadLine());

                    diagonal = Math.Sqrt((szerokość * szerokość) + (długość * długość));
                    Console.WriteLine("Diagonal:{0}", diagonal);
                }
            }
            while(szerokość != 0);
        }
    }
    
}
