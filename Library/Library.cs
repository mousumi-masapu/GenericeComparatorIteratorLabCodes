using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryProgram
{
    class Library : IEnumerable<Book>
    {

        public List<Book> books;

        public Library(params Book[] books)
        {

            this.books = new List<Book>(books); 
            Console.WriteLine(this.books.Count);
   
        }
        public IEnumerator<Book> GetEnumerator()
        {

            foreach (var book in books)
            {
                Console.WriteLine("Book" + book);
                yield return book;

            }

          
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


    }
}
