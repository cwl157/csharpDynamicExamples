using System;
using System.Collections.Generic;
using BooksManagerModels;

namespace BooksManagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** CSV EXAMPLE *****");
            ReadFromCsv();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("***** JSON EXAMPLE *****");
            ReadFromJson();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private static void ReadFromCsv()
        {
            List<Book> booksFromTyped = new List<Book>();
            List<Book> booksFromDynamic = new List<Book>();
            DataAccess da = new DataAccess();

            booksFromTyped = da.ReadCsvTyped(@".\data\books.csv");
            booksFromDynamic = da.ReadCsvDynamic(@".\data\books.csv");

            Console.WriteLine("Typed Book List");
            foreach (Book b in booksFromTyped)
            {
                Console.WriteLine(b.Title + " " + b.Author);
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Dynamic Book List");
            foreach (Book b in booksFromDynamic)
            {
                Console.WriteLine(b.Title + " " + b.Author);
            }
        }

        private static void ReadFromJson()
        {
            List<Book> booksFromTyped = new List<Book>();
            List<Book> booksFromDynamic = new List<Book>();
            DataAccess da = new DataAccess();

            booksFromTyped = da.ReadJsonTyped(@".\data\books.json");
            booksFromDynamic = da.ReadJsonDynamic(@".\data\books.json");

            Console.WriteLine("Typed Book List");
            foreach (Book b in booksFromTyped)
            {
                Console.WriteLine(b.Title + " " + b.Author);
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Dynamic Book List");
            foreach (Book b in booksFromDynamic)
            {
                Console.WriteLine(b.Title + " " + b.Author);
            }
        }
    }
}
