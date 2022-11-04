/* 
 * By Cian Hanifan
 * Date: 10/20/2022
 * La5: Checkout
 */
using System;

namespace Lab6
{
    internal class Lab6
    {
        static void Main(string[] args)
        {

            //Show Character Program
            char Display;
            Console.WriteLine("--Show Character Program--");
            Display = ShowCharacter("New York", 2);
            Console.WriteLine(Display);
            Console.WriteLine("\n");

            //Retail Price Program
            double t;
            double whole, markup;
            Console.WriteLine("--Retail Price Program--");
            Console.Write("Please Enter the WholeSale Cost (00.00): ");
            whole = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter the Markup Precentage (00.00): ");
            markup = Convert.ToDouble(Console.ReadLine()); 
            t = CalculateRetail(whole, markup);  
            Console.WriteLine("Total: " + String.Format("{0:0.00}", t));
            Console.WriteLine("\n");

            //Temperature Table Program
            double F, C;
            Console.WriteLine("--Temperature Table Program--");
            Console.Write("Please enter the Fahrenheit temperature: ");
            F = Convert.ToDouble(Console.ReadLine());
            C = Celsius(F);   
            Console.WriteLine("Celsius: " + String.Format("{0:0.00}", C));
            Console.WriteLine("\n");

            //Prime Numbers Program
            int N;
            bool tt;
            Console.WriteLine("--Prime Numbers Program--");
            Console.Write("Please enter any number: ");
            N = Convert.ToInt32(Console.ReadLine());
            tt = IsPrime(N);
            Console.WriteLine("Is it a Prime: " + String.Format("{0:0.00}", tt));
            Console.WriteLine("\n");

        }
        static char ShowCharacter(string text, int position)
        {
            //Show Character Program
            char c;
            c = text[position - 1];
            return c;
        }

        static double CalculateRetail(double whole, double markup)
        {
            //Retail Price Program
            double t;
            t = whole + whole * markup;
            return t;
        }

        static double Celsius(double F)
        {
            //Temperrate Table Program
            double Ce;
            Ce = 5.00 / 9.00 * (F - 32);
            return Ce;
        }

        static bool IsPrime(int P)
        {
            // Prime Numbers Program
            if (P < 2) return false;
            if (P % 2 == 0) return (P == 2);
            int root = (int)Math.Sqrt((double)P);
            for (int i = 3; i <= root; i += 2)
            {
                if (P % i == 0) return false;
            }
            return true;
        }

    }
}
