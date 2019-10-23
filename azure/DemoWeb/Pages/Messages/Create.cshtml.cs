using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DemoWeb.Data;
using DemoWeb.Models;

namespace DemoWeb.Pages.Messages
{
    public class CreateModel : PageModel
    {
        private readonly DemoWeb.Data.DemoWebContext _context;

        public CreateModel(DemoWeb.Data.DemoWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DemoWeb.Models.Messages Messages { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Messages.Add(Messages);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
