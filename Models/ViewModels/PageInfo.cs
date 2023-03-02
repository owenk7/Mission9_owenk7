using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_owenk7.Models.ViewModels
{
    public class PageInfo
    {
        public int totalBooks { get; set; }
        public int booksPerPage { get; set; }
        public int currentPage { get; set; }

        //number of pages
        public int totalPages => (int)Math.Ceiling((double)totalBooks / booksPerPage);
    }
}