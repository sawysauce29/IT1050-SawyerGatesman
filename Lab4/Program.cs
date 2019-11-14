using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 2). There are 4 elements in a counter control repetition the first one is a control variable and that’s the variable used in the statement.
// the second part is the initial value which is what the variable starts as
// then there’s the 3 part which is the increment which is how much the value changes in each tick of the loop
// finally, there’s the loop continuation condition which determines if the loop should continue going on
// 3). while and for repetition statements are very similar they both do the same operations, but the differences are
// a while statement would go “Do {} while ();”
// for (int I = 1; I <= 100; ++i)
// 4). It would be more appropriate  to do  a do while loop when you want something to happen unconditlnlly the first time
// then uses a condition th the second loop for example
//int sum = 0;
//int i = 0;
//do
//sum += ids[i];
//i++;
//while (i< 4);


namespace Lab4
{
    class Program


    {
        static void Main(string[] args)
        //5).
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    { Console.WriteLine("Number is even"); }
                    else if ((i % 2) != 0)
                    { Console.WriteLine("Number is odd"); }
                }
            }
            {
                //6).
                Console.Write("Please enter a temperature: ");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp >= 90) { Console.WriteLine("fish"); }
                else if(temp >= 80) { Console.WriteLine("Lion"); }
                else if(temp >= 70) { Console.WriteLine("Turle"); }
                else if(temp >= 60) { Console.WriteLine("Deer"); }
                else if(temp >= 50) { Console.WriteLine("Reindeer"); }
                else if(temp >= 40) { Console.WriteLine("Moose"); }
                else if(temp >= 20) { Console.WriteLine("Penguin"); }
                else if(temp >= 10) { Console.WriteLine("Polar Bear"); }
                else { Console.WriteLine("Bug"); }
            }
            {
                //7).
                int i = 10 ;
                while (i < 21)
                {
                    Console.WriteLine(i);i++ ;
                }

            }
            //8).
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }

            {
            }

        }
    }

}



