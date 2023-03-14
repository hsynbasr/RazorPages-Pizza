using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebRazorTest.Data;
using WebRazorTest.Model;

namespace WebRazorTest.Pages.Admin
{
    public class OrdersListModel : PageModel
    {
        private readonly PizzaDbContext _context;

        public OrdersListModel(PizzaDbContext context)
        {
            _context = context;
        }

        public IList<PizzaOrder> PizzaOrder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PizzaOrders != null)
            {
                PizzaOrder = await _context.PizzaOrders.ToListAsync();
            }
        }
    }
}
