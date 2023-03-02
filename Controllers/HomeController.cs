using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission9_owenk7.Models;
using Mission9_owenk7.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_owenk7.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository Repository;

        public HomeController(IBookstoreRepository repository)
        {
            Repository = repository;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int numBooks = 10;

            var x = new BooksViewModel
            {
                Books = Repository.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * numBooks)
                .Take(numBooks),

                PageInfo = new PageInfo
                {
                    totalBooks = Repository.Books.Count(),
                    booksPerPage = numBooks,
                    currentPage = pageNum
                }
            };

            return View(x);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}