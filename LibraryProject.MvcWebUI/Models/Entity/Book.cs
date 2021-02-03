using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryProject.MvcWebUI.Models.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public Category Category { get; set; }
    }
}