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
    public class IndexModel : PageModel
    {
        private readonly RazerPagesDemo.Data.RazerPagesDemoContext _context;

        public IndexModel(RazerPagesDemo.Data.RazerPagesDemoContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}
