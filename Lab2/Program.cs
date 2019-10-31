using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int product;
            Console.WriteLine("Enter first integer");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            number2 = int.Parse(Console.ReadLine());

            product = number1 * number2;
            Console.WriteLine($"Product is {product}");

            Console.WriteLine("Hello world! \nFrom sawyer Gatesman");
            Console.WriteLine("Hello World!     From Sawyer Gatesman");
            Console.ReadLine();
        }
    }
}
//A The program exucutes when you hit the green arrow that says start.
//B The diffence between a double and float is the way they store  the values a float holds 32 bit a doulbe holds 64 bits
//C A meatod shown in the book is entering a name then showing a name 
//D parameter accessor
//E A class is a user defined data type and a object is an instence of a class. 
//You can have as many instences youwant as long as you have the over head nessary.
