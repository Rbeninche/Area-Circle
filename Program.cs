using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the radius: ");



            double radius;

            radius = Convert.ToDouble(Console.ReadLine());



            while(radius < 0)
            {
                Console.Write("Please enter a positive number: ");

                radius = Convert.ToDouble(Console.ReadLine());


            }

            double pivalue = Math.PI;

            double area;

            area = Math.Round(pivalue * radius * radius, 2);

            Console.WriteLine($"The area of a circle with radius {radius} is: {area}");

            Console.ReadLine();








        }
    }
}
