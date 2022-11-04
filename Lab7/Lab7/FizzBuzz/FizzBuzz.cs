using System;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            coutl("---------FizzBuzz Program---------");
            cout("Please enter any number you like: ");
            double fbs = Convert.ToDouble(cin());
            coutl(FB(fbs).ToString());
            cout("----------------------------------");
        }

        static double FB(double fbs)
        {
            while (fbs > 0)
            {

                if (fbs % 3 == 0)
                {
                    coutl("fizz");
                }
                else if (fbs % 5 == 0)
                {
                    coutl("buzz");
                }
                else
                {
                    coutl(Convert.ToString(fbs));
                }

                fbs--;

            }
            return fbs;
        }
        static void coutl(string stuff)
        {
            Console.WriteLine(stuff);
        }
        static void cout(string stuff)
        {
            Console.Write(stuff);
        }
        static string cin()
        {
           return Console.ReadLine();
        }
    }
}
