using System;

namespace Fahrenheit_to_centigrate
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, centigrate;
            Console.WriteLine("Enter temperture with fahrenheit : ");
            fahrenheit = double.Parse(Console.ReadLine());
            centigrate = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Tempreture with centigrate : " + centigrate);
        }
    }
}
