using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // The "if" statment says if blank than do blank while the "While" statment thays if blank do blank but otherwise do blank.
    // both statements test for something but one thr while sttment allows more options
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            speedLimit = 35;
            int speed;
            speed = 42;
            if (speed > speedLimit) 
            {
                Console.WriteLine("SLOW NOW");
              
                
            }

            int num1;
            Console.WriteLine("enter a number");
            num1 = int.Parse(Console.ReadLine());
            if (num1 == 5)
            {
                Console.WriteLine("It is True!");
            }
            else 
            {
                Console.WriteLine("It is False!");
            }

           Console.WriteLine("Input temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double Celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Temperature in Celsius is {0}: ", Celsius);
            Console.ReadLine();
            if (fahrenheit >= 90) 
                Console.WriteLine("It is hot");
            if (fahrenheit <= 40)
                Console.WriteLine("IT is Cold");

            int i = 1;
            while (i < 11)
            {
                Console.Write("While Output: ");
                Console.WriteLine(i);
                i++;
            }
            int m = 60;
            int n = 5;
            while (m > 20) 
            { Console.Write("While Output: ");
                Console.WriteLine(m = m -n); 
            }
            int y = 10;
            int x = 2;
            while (y < 20)
            {
                Console.Write("While Output: ");
                Console.WriteLine(y = y + x);
            }



        }
    }
}
