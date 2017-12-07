using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagerConsole.DataTransferObjects
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public BookDto(string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
    }
}
