using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoWeb.Data;
using DemoWeb.Models;

namespace DemoWeb.Pages.Messages
{
    public class DetailsModel : PageModel
    {
        private readonly DemoWeb.Data.DemoWebContext _context;

        public DetailsModel(DemoWeb.Data.DemoWebContext context)
        {
            _context = context;
        }

        public DemoWeb.Models.Messages Messages { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Messages = await _context.Messages.FirstOrDefaultAsync(m => m.ID == id);

            if (Messages == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
