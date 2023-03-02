using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_owenk7.Models
{
    // interface = template for a class
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}