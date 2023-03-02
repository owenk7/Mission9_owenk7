using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_owenk7.Models
{
    // implementation of IBookstoreRepository
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext Context { get; set; }

        public EFBookstoreRepository(BookstoreContext context)
        {
            Context = context;
        }

        public IQueryable<Book> Books => Context.Books;
    }
}