using System;
using System.Dynamic;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            coutl("----------X's and O's Program----------");
            cout("Please enter any amount of X's and O's: ");
            string xos = cin();
            coutl("Do the X's and O's match: " + XO(xos).ToString());
            coutl("---------------------------------------");
        }
        static bool XO(string xos)
        {
            int x = 0;
            int o = 0;
            xos = xos.ToLower();

            for (int i = 0; i < xos.Length; i++)
            {
                if (xos[i] == 'x')
                {
                    x++;
                }
                if (xos[i] == 'o')
                {
                    o++;
                }
            }

            if (x == o)
            {
                return true;
            }
            else if (x != o)
            {
                return false;
            }
            else if (o == 0 && x == 0)
            {
                return true;
            }

            return false || true;
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
