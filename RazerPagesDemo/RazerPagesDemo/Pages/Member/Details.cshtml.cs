using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazerPagesDemo.Data;
using RazerPagesDemo.Model;

namespace RazerPagesDemo
{
    public class DetailsModel : PageModel
    {
        private readonly RazerPagesDemo.Data.RazerPagesDemoContext _context;

        public DetailsModel(RazerPagesDemo.Data.RazerPagesDemoContext context)
        {
            _context = context;
        }

        public Member Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);

            if (Member == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
