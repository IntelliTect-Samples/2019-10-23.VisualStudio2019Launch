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
    public class IndexModel : PageModel
    {
        private readonly DemoWeb.Data.DemoWebContext _context;

        public IndexModel(DemoWeb.Data.DemoWebContext context)
        {
            _context = context;
        }

        public IList<DemoWeb.Models.Messages> Messages { get;set; }

        public async Task OnGetAsync()
        {
            Messages = await _context.Messages.ToListAsync();
        }
    }
}
