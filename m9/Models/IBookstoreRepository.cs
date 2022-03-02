using System;
using System.Linq;

namespace m9.Models
{
    public interface IBookstoreRepository
    {
       IQueryable<Book> Books { get; }
    }
}
