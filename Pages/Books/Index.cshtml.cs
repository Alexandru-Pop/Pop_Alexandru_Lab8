﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Alexandru_Lab8.Data;
using Pop_Alexandru_Lab8.Models;

namespace Pop_Alexandru_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Pop_Alexandru_Lab8.Data.Pop_Alexandru_Lab8Context _context;

        public IndexModel(Pop_Alexandru_Lab8.Data.Pop_Alexandru_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
