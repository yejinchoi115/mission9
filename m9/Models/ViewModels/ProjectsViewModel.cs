using System;
using System.Linq;

namespace m9.Models.ViewModels
{
    public class ProjectsViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }
        
    }
}
