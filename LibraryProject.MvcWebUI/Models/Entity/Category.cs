using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryProject.MvcWebUI.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Book> Books { get; set; }
    }
}