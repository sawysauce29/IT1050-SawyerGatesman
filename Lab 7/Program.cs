using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    

class Display

    {

        public String title;

        public String author;

        public String year;



        public Display(String Title, String Author, String Year)
        {

            this.title = Title;

            this.author = Author;

            this.year = Year;

        }

        public void bookDisplay()
        {

            Console.WriteLine("Title", this.title);



            Console.WriteLine("Author", this.author);

        }

    }

    class BookTest

    {

        static void Main(string[] args)

        {

            Display book = new Display("CS", "Gatesman", "2019");

            book.bookDisplay();

        }

    }

}
