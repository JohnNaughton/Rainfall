using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall
{
    class Program
    {
        private static double totalmonths = 0;
        private static double totalinches = 0;
        private static double overallinches = 0;

        private static double years = 0;
        private static double inches = 0;
        private static double month = 0;
        private static double count = 0;
        private static double count2 = 1;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Over how many years would you like to calculate the average rainfall: ");
            years = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n*******************************************\n");

            loop();

            totalaverage();

        }   // end main method


        private static void loop()
        {
            for (count = 1; count <= years; count++)
            {

                for (month = 1; month <= 12; month++)
                {
                    Console.Write("Enter inches of rainfall for year {0} month {1}: ", count, count2);
                    inches = double.Parse(Console.ReadLine());
                    totalinches += inches;
                    count2++;
                }   // end inner for loop

                overallinches += totalinches;
                count2 = 1;
                totalmonths += 12;
                average();
                Console.Write("\n*******************************************\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n*******************************************\n");


            } // end outer for loop
        } // end loop


        private static void average()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n*******************************************\n");
            Console.Write("\nTotal inches of rainfall this year: " + totalinches);
            Console.Write("\nAverage rainfall per month: {0:0.0}", (totalinches / (1 * 12)));
            totalinches = 0;
        }   // end average


        private static void totalaverage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nNumber of months: " + (totalmonths));
            Console.Write("\nTotal inches of rainfall overall: " + overallinches);
            Console.Write("\nAverage rainfall per month: {0:0.0}", (overallinches / (years * 12)));

            Console.ReadLine();
        }   // end totalaverage


        }   // end class
}
