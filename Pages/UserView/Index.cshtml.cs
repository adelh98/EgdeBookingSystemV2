using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EgdeBookingSystemV2.Data;
using EgdeBookingSystemV2.Models;

namespace EgdeBookingSystemV2.Pages.UserView
{
    public class IndexModel : PageModel
    {
        private readonly EgdeBookingSystemV2.Data.EgdeBookingSystemConnection _context;

        public IndexModel(EgdeBookingSystemV2.Data.EgdeBookingSystemConnection context)
        {
            _context = context;
        }

        public IList<Equipment> Equipment { get;set; }

        public async Task OnGetAsync()
        {
            Equipment = await _context.Equipments
                .Include(e => e.Category)
                .Include(e => e.Location).ToListAsync();
        }
    }
}
