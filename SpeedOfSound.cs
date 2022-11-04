/* 
 * By Cian Hanifan
 * Date: 9/22/2022
 * La4: The Speed of Sound
 */

using System;
using System.Collections.Specialized;

namespace Lab4
{
    internal class SpeedOfSound
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- This Program calculates how fast sound takes ");
            Console.WriteLine("- to travel through three different materials\n");

            // Ask the user for the medium
            Console.WriteLine("-------------------------");
            Console.WriteLine("--Air, Water, or Steel---");             
            Console.WriteLine("--Enter one from above:--");
            Console.WriteLine("-------------------------");      // cout << "Enter the medium: " << endl;
            // Get that medium from the user, and store it      
            string medium = Console.ReadLine();                 // cin >> Medium

            // Asks the user for the distance
            Console.WriteLine("------------------------");
            Console.WriteLine("--Enter the Distance:---");
            Console.WriteLine("------------------------");
            // Get the distance from the user, and store it
            double distance = Convert.ToDouble(Console.ReadLine());

            // Calculate the time needed to travel that distance in that medium
            double time = 0;

            if (medium == "air")
            {
                time = (distance / 1100);
            }
            else if (medium == "water")
            {
                time = (distance / 4900);
            }
            else if (medium == "steel")
            {
                time = (distance / 16400);
            }
            else
            {
                Console.WriteLine("*** This is a not a suitable entry ***");
            }

            // ******************************
            // **** DANGER WILL ROBINSON ****
            // *THERE BE DECISION STRUCTIRES*
            // ******************************

            // Display the time
            Console.WriteLine("----------------------------------");
            Console.WriteLine("--This is the time it will take: " + time);
            Console.WriteLine("----------------------------------");



        }
    }
}
