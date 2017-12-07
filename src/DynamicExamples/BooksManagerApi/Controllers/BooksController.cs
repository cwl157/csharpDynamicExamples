using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BooksManagerModels;

namespace BooksManagerApi.Controllers
{
    public class BooksController : ApiController
    {
        public void Post([FromBody]dynamic requestObject)
        {
            Book b = new Book();
            b.Title = requestObject.title;
            b.Author = requestObject.author;
            Debug.WriteLine("Title = " + b.Title);
            Debug.WriteLine("Author = " + b.Author);
        }
    }
}
