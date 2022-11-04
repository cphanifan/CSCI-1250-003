using System;

namespace BroccoliPizza_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            byte otherNumberOfCarrots = 255;
            int numberOfCarrots;
            numberOfCarrots = otherNumberOfCarrots; //1234565;

            Console.WriteLine(numberOfCarrots);
            Console.WriteLine(otherNumberOfCarrots);
            */
            //var MyNumberOfCarrots = 5008;

            uint numberOfPotatoes = 4294967295; //this bad boy looped back to one when it got overloaded
            numberOfPotatoes = numberOfPotatoes + 2;

            Console.WriteLine(numberOfPotatoes);
        }
    }
}
