using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Schema;

namespace MethodCallMomo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = new double[10];
            double val;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter #{i + 1} value: ");
                string userinput = Console.ReadLine();

                if (double.TryParse(userinput, out val))
                {
                    myArray[i] = val;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Displaying the all the values of an array");
            GetAve(myArray);
            GetMax(myArray);
            GetMin(myArray);
            GetMed(myArray);
            Display(myArray);



        }
        static double GetMax(double[] maximum)
        {
            double max = maximum.Max();
            Console.WriteLine("The maximum value is: " + max);
            return 0;
        }
        static double GetMin(double[] minimum)
        {
            double min = minimum.Min();
            Console.WriteLine("The minimum value is: " + min);

            return 0;
        }
        static double GetAve(double[] average)
        {
            double avg = Queryable.Average(average.AsQueryable());
            Console.WriteLine("The average value is: " + avg);
            return 0;
        }
        static double GetMed(double[] median)
        {
            int med = median.Length;
            Array.Sort(median);

            if (med % 2 == 0)
            {
                double mid1 = (med / 2) - 1;
                double mid2 = med / 2;
                double middle = (median[(int)mid1] + median[(int)mid2]) / 2;
                Console.WriteLine("The median value is: " + middle);


            }
            else
            {
                double mid = med / 2;
                double middle = median[(int)mid];
                Console.WriteLine("The median value is: " + middle);
            }
            return 0;
        }
        static double Display(double[] display)
        {

            Console.Write("Displaying the inputted arrays: ");
            for (int i = 0; i < display.Length; i++)
            {
                Console.Write("    " + display[i]);

            }
            return 0;
        }
    }
}
