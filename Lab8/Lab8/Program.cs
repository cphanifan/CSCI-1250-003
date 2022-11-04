using System;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cInput = "";

            //while (cInput != "exit")
            //{
                Console.WriteLine("---Circle Program---");
                Console.Write("Please enter you radius: ");
                cInput = Console.ReadLine();

                double rad = 0;

                if (double.TryParse(cInput, out rad))
                {
                    DisplayCircleInformation(rad);
                }
                else
                {
                    Console.WriteLine("--This is an invalid value--");
                }
            //}
            string name = "";
            string address = "";
            int age;
            string phoneNumber;

            Console.WriteLine("\n---Personal Information Program---");

            Console.Write("Please enter your name: \t");
            name = Console.ReadLine();

            Console.Write("Please enter your address: \t");
            address = Console.ReadLine();

            Console.Write("Please enter your age: \t\t");
            age = Convert.ToInt32(Console.ReadLine());// convert to int

            Console.Write("Please enter your phoneNumber: \t");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("----------------------------------");

            PersonalInformation personal;

            personal = new PersonalInformation(name, address, age, phoneNumber);

            Console.WriteLine(personal.ToString());
            Console.WriteLine(personal.GetName());
            Console.WriteLine(personal.GetAddress());
            Console.WriteLine(personal.GetAge());
            Console.WriteLine(personal.GetPhoneNumber());

        }
        static void DisplayCircleInformation(double radius)
        {
            Circle circ;

            circ = new Circle(radius);

            Console.WriteLine(circ.ToString());
            Console.WriteLine("Radius\t\t" + circ.GetRadius());
            Console.WriteLine("Diameter:\t" + circ.GetDiameter());
            Console.WriteLine("Circumference:\t" + circ.GetCircumference());
            Console.WriteLine("Area:\t\t" + circ.GetArea());
            //Console.WriteLine(circ.GetHashCode());
        }
        static void DisplayPersonalInformation(string[] args)
        {
            
        }
    }
}
