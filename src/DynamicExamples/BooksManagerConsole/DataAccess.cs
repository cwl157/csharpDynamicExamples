using System.Collections.Generic;
using BooksManagerConsole.DataTransferObjects;
using CsvHelper;
using System.IO;
using Newtonsoft.Json;
using BooksManagerModels;

namespace BooksManagerConsole
{
    public class DataAccess
    {
        public List<Book> ReadCsvTyped(string filePath)
        {
            List<Book> result = new List<Book>();

            using (StreamReader reader = File.OpenText(filePath))
            {
                CsvReader csv = new CsvReader(reader);
                IEnumerable<BookDto> records = csv.GetRecords<BookDto>();
                foreach (BookDto b in records)
                {
                    Book tmp = new Book();
                    tmp.Title = b.Title;
                    tmp.Author = b.Author;
                    result.Add(tmp);
                }
            }
            return result;
        }

        public List<Book> ReadCsvDynamic(string filePath)
        {
            List<Book> result = new List<Book>();
            using (StreamReader reader = File.OpenText(filePath))
            {
                CsvReader csv = new CsvReader(reader);
                IEnumerable<dynamic> records = csv.GetRecords<dynamic>();

                foreach (dynamic b in records)
                {
                    Book tmp = new Book();
                    tmp.Title = b.Title;
                    tmp.Author = b.Author;

                    result.Add(tmp);
                }   
            }
            
            return result;
        }

        public List<Book> ReadJsonTyped(string filePath)
        {
            List<Book> result = new List<Book>();

            string jsonData = File.ReadAllText(filePath);

            List<BookDto> records = JsonConvert.DeserializeObject<List<BookDto>>(jsonData);

            foreach (BookDto b in records)
            {
                Book tmp = new Book();
                tmp.Title = b.Title;
                tmp.Author = b.Author;

                result.Add(tmp);
            }

            return result;
        }

        public List<Book> ReadJsonDynamic(string filePath)
        {
            List<Book> result = new List<Book>();

            string jsonData = File.ReadAllText(filePath);

            List<dynamic> records = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);

            foreach (dynamic b in records)
            {
                Book tmp = new Book();
                tmp.Title = b.title;
                tmp.Author = b.author;

                result.Add(tmp);
            }

            return result;
        }
    }
}
