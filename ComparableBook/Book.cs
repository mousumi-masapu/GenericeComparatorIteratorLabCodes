using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparableBook
{
    class Book : IComparable<Book>
    {

        private List<string> authors;

        public Book(string title,int year,params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.authors = new List<string>(authors);
        }

        public string Title { get; set; }
        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }


        public int CompareTo(Book other)
        {
            Console.WriteLine("Other value is" + other);
            int result = this.Year.CompareTo(other.Year);
            Console.WriteLine("Compare Result is"+ result);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
                Console.WriteLine("Compare Result is 0" + result);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{ this.Title} - {this.Year}";
        }
    }
}
