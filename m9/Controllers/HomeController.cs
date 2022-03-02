﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using m9.Models;
using m9.Models.ViewModels;

namespace m9.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController(IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string categoryType, int pageNum = 1)
        {
            int pageSize = 10;

            var x = new ProjectsViewModel
            {
                Books = repo.Books
                .Where(p => p.Category == categoryType || categoryType == null)
                .OrderBy(p => p.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumProjects = (categoryType == null
                        ? repo.Books.Count()
                        : repo.Books.Where(x => x.Category == categoryType).Count()),
                    ProjectsPerPage = pageSize,
                    Currentpage = pageNum
                }

            };
            return View(x);
        }
    }
}
