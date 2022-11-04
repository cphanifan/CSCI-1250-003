/* 
 * By Cian Hanifan
 * Date: 9/22/2022
 * La4: The Speed of Sound
 */

using System;
using System.Xml.Schema;

namespace Audiobook_Subscription_Service
{
    internal class Audiobooks
    {
        static void Main(string[] args)
        {
            // Display a selection of monthly plans
            Console.WriteLine("*******************************************************");
            Console.WriteLine("*Welcome to AudioMillion the only audiobook store with* ");
            Console.WriteLine("*exactly a million audiobooks no more no less.        *");
            Console.WriteLine("*******************************************************\n");
            Console.WriteLine("-----Plan Selection: ----------------------------------------------------------------------------");
            Console.WriteLine(" - Package A: ");
            Console.WriteLine("   For $9.95 per month, 10 audiobooks are provided. Additional books are $2.00 per book.\n");
            Console.WriteLine(" - Package B: ");
            Console.WriteLine("   For $13.95 per month, 20 audiobooks are provided. Additional books are $1.00 per book.\n");
            Console.WriteLine(" - Package C: ");
            Console.WriteLine("   For $19.95 per month, unlimited audiobook access is provided.\n");

            // Get input of package selection
            Console.WriteLine(" * Enter the Leter of the plan you want:");
            string plan = Console.ReadLine();
            plan = plan.ToUpper();
            Console.WriteLine(" ! Thank you for purchasing  !\n");

            // Get input of how many books the user is buy/using


            // Calculate the customer's monthly bill based on the spending
            double total = 0;

            if (plan == "A")
            {
                Console.WriteLine(" * Enter how many additional book you wish to purchase");
                double book = Convert.ToDouble(Console.ReadLine());
                total = 9.95 + (book * 2.00);
            }
            else if (plan == "B")
            {
                Console.WriteLine(" * Enter how many additional book you wish to purchase");
                double book = Convert.ToDouble(Console.ReadLine());
                total = 13.95 + (book * 1.00);
            }
            else if (plan == "C")
            {

                total = 19.95;
            }
            else
            {
                Console.WriteLine("*** This is a not a suitable entry ***");
            }

            // Display their total charges
            Console.WriteLine(" - Your total cost is: " + total);
        }
    }
}
