using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloudMVC.Controllers
{
    public class CompanyProfilePocoesController : Controller
    {
        private readonly CareerCloudContext _context;

        public CompanyProfilePocoesController(CareerCloudContext context)
        {
            _context = context;
        }

        // GET: CompanyProfilePocoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyProfiles.ToListAsync());
        }

        // GET: CompanyProfilePocoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyProfilePoco = await _context.CompanyProfiles
                .Include(a=>a.CompanyJobs)
                .Include(a=>a.CompanyLocations)
                .Include(a=>a.CompanyDescriptions)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyProfilePoco == null)
            {
                return NotFound();
            }

            return View(companyProfilePoco);
        }

        // GET: CompanyProfilePocoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyProfilePocoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RegistrationDate,CompanyWebsite,ContactPhone,ContactName,CompanyLogo")] CompanyProfilePoco companyProfilePoco)
        {
            if (ModelState.IsValid)
            {
                companyProfilePoco.Id = Guid.NewGuid();
                _context.Add(companyProfilePoco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyProfilePoco);
        }

        // GET: CompanyProfilePocoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyProfilePoco = await _context.CompanyProfiles.FindAsync(id);
            if (companyProfilePoco == null)
            {
                return NotFound();
            }
            return View(companyProfilePoco);
        }

        // POST: CompanyProfilePocoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,RegistrationDate,CompanyWebsite,ContactPhone,ContactName,CompanyLogo")] CompanyProfilePoco companyProfilePoco)
        {
            if (id != companyProfilePoco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyProfilePoco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyProfilePocoExists(companyProfilePoco.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(companyProfilePoco);
        }

        // GET: CompanyProfilePocoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyProfilePoco = await _context.CompanyProfiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyProfilePoco == null)
            {
                return NotFound();
            }

            return View(companyProfilePoco);
        }

        // POST: CompanyProfilePocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var companyProfilePoco = await _context.CompanyProfiles.FindAsync(id);
            _context.CompanyProfiles.Remove(companyProfilePoco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyProfilePocoExists(Guid id)
        {
            return _context.CompanyProfiles.Any(e => e.Id == id);
        }
    }
}
