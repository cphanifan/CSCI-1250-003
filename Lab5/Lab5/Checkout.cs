/* 
 * By Cian Hanifan
 * Date: 9/29/2022
 * La5: Checkout
 */
using System;
using System.Xml.Schema;

namespace Lab5
{
    internal class Checkout
    {
        static void Main(string[] args)
        {
            // User input number of prices
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Please enter the amount of prices would want to enter: ");
            decimal am = Convert.ToDecimal(Console.ReadLine());
            decimal total = 0;

            // Loop that stores user input and calculates
            for (int i = 1; i <= am; i++)
            {
                Console.Write("\nEnter price: $");
                decimal input = Convert.ToDecimal(Console.Read());

                total += input;
            }
            /*if (am != "{0:0.00}")
            {
                Console.WriteLine("*** This is not a valid entry ***");
            }*/

            // Display
            Console.WriteLine("\nYour totals is: $" + String.Format("{0:0.00}", total));

            //Decimal.Round(total, 2)
            //(int i = 1; i <= am;  am++) -- (initialize, check the condition, repeat step 2)
        }
    }
}
