using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book aBook = new Book();
            aBook.isbnNumber = "1234";
            aBook.title = "Cook";
            Book anotherBook = new Book();
            anotherBook.isbnNumber = "456";
            anotherBook.title = "Drive";

        }
    }
}
