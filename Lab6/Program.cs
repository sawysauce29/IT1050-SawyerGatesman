using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        //1.)A one-dimensional array p contains four elements.  
        //The array access expressions to access each of the elements in p are __{0}_____, ___{1}____,___{2}____ and __{3}____.
        static void Main(string[] args)
        {
            //2.)
            string[] months = { "1st January", "2nd February", "3rd March", "4th April", "5th May", "6th June", "7th July", "8th August", "9th September", "10th October", "11th November", "12th December" };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(months[i]);
            }
            //3.)
            string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
            Console.WriteLine("The Four Seasons");
            foreach (string season in seasons)
            {
                Console.WriteLine(season);


            }
            //4.)
            int[] randomNumber = new int[1000];
            Random random = new Random();


            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 100); // place this line in the loop
            }


            foreach (int i in randomNumber)
            {
                Console.WriteLine(i.ToString());

            }
            //5./6./7.)
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int j = 0;
            foreach (string name in names)
            {
                Console.WriteLine("{0,2}. {1}", j, names[j]);
                j++;
            }



        }
    }
}
