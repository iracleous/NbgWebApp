#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NbgWebApp.Model;

namespace NbgWebApp.Pages
{
    public class CustomerIndexModel : PageModel
    {
        private readonly NbgWebApp.Model.NbgDbContext _context;

        public CustomerIndexModel(NbgWebApp.Model.NbgDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
