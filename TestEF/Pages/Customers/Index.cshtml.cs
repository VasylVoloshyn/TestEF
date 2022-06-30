using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestEF.Data;
using TestEF.Model;

namespace TestEF.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly TestEF.Data.TestEFContext _context;

        public IndexModel(TestEF.Data.TestEFContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customer = await _context.Customers
                .Include(c => c.User).ToListAsync();
            }
        }
    }
}
