using System;

namespace Midterm
{
    //1.) Diffrent control structures we use are loops, switch statments and if statemnts
    // loops will repaeat a bit of code till the requirement is met
    //switch statments are used in place of if else statments
    //if statemnts use logic to excute code
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                //2.)
                int d = 14;
                Boolean keepLooping = true;
                while (keepLooping)
                {
                    if (d <= 13)

                        keepLooping = false;
                    d++;
                    Console.WriteLine(d);
                }
            }
            //3.)
            int j = 2;
            while (j <= 128)
            {
                {
                    if ((j % 2) == 0)
                    {
                        Console.WriteLine("[{0}]", j);
                    }
                    else if ((j % 2) != 0)
                    {
                        Console.Write("");
                    }
                    j *= 2;
                }
            }
            //4.)
            string k = ",";
            int l;
            for (l = 49; l >= 1; --l)
            {
                Console.Write(l);
                if (l >= 2)
                {
                    Console.Write(k);
                }
            }
            Console.WriteLine();
            //5.)
            int h = 1;
            while (h <= 21)
            {
                {
                    if ((h % 2) == 0)
                    {
                        Console.Write(" ");
                    }
                    else if ((h % 2) != 0)
                    {
                        Console.Write(h);
                    }
                    h++;
                }
            }
            Console.WriteLine();
            //6.)
            //  int n = 8;
            //  int i = 10; // initialize
            // do
            //{
            //   Console.Write("*");
            //  i++; // update!
            //} while (i < n); // test condition
            //the output for the code is "*"
            //you would get the same output of "*"
            int n = 8;
            int i = 10;
            while (i < n)
            {
                Console.Write("*");
                i++;
            }
            //7.) we combine multple boolean values by useing by using nested if or  if else statments
            // the main operators are ||, !, and &&.
            bool icyRain = false;
            bool tornadoWarning = false;

            if (!(icyRain) && !(tornadoWarning))
            {
                Console.WriteLine("Let's go outside!");
            }
        }
    }
}