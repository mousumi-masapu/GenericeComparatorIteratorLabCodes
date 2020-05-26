using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProgram
{
    class Book
    {
   public  Book(string title,int year,params string[] authors)
        {

            Console.WriteLine("Inside BookClass");
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);

        }

        public string Title { get;  set; }
        public int Year { get;set; }

        public IReadOnlyList<string> Authors { get; set; }


    }

}
