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
    public class ApplicantEducationPocoesController : Controller
    {
        private readonly CareerCloudContext _context;

        public ApplicantEducationPocoesController(CareerCloudContext context)
        {
            _context = context;
        }

        // GET: ApplicantEducationPocoes
        public async Task<IActionResult> Index(Guid? Id)
        {
            var careerCloudContext = _context.ApplicantEducations.Where(a => a.Applicant==Id);
            return View(await careerCloudContext.ToListAsync());
        }

        // GET: ApplicantEducationPocoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantEducationPoco = await _context.ApplicantEducations
                .Include(a => a.ApplicantProfile)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicantEducationPoco == null)
            {
                return NotFound();
            }

            return View(applicantEducationPoco);
        }

        // GET: ApplicantEducationPocoes/Create
        public IActionResult Create()
        {
            ViewData["Applicant"] = new SelectList(_context.ApplicantProfiles, "Id", "Id");
            return View();
        }

        // POST: ApplicantEducationPocoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Applicant,Major,CertificateDiploma,StartDate,CompletionDate,CompletionPercent")] ApplicantEducationPoco applicantEducationPoco)
        {
            if (ModelState.IsValid)
            {
                applicantEducationPoco.Id = Guid.NewGuid();
                _context.Add(applicantEducationPoco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Applicant"] = new SelectList(_context.ApplicantProfiles, "Id", "Id", applicantEducationPoco.Applicant);
            return View(applicantEducationPoco);
        }

        // GET: ApplicantEducationPocoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantEducationPoco = await _context.ApplicantEducations.FindAsync(id);
            if (applicantEducationPoco == null)
            {
                return NotFound();
            }
            ViewData["Applicant"] = new SelectList(_context.ApplicantProfiles, "Id", "Id", applicantEducationPoco.Applicant);
            return View(applicantEducationPoco);
        }

        // POST: ApplicantEducationPocoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Applicant,Major,CertificateDiploma,StartDate,CompletionDate,CompletionPercent")] ApplicantEducationPoco applicantEducationPoco)
        {
            if (id != applicantEducationPoco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicantEducationPoco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicantEducationPocoExists(applicantEducationPoco.Id))
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
            ViewData["Applicant"] = new SelectList(_context.ApplicantProfiles, "Id", "Id", applicantEducationPoco.Applicant);
            return View(applicantEducationPoco);
        }

        // GET: ApplicantEducationPocoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantEducationPoco = await _context.ApplicantEducations
                .Include(a => a.ApplicantProfile)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicantEducationPoco == null)
            {
                return NotFound();
            }

            return View(applicantEducationPoco);
        }

        // POST: ApplicantEducationPocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var applicantEducationPoco = await _context.ApplicantEducations.FindAsync(id);
            _context.ApplicantEducations.Remove(applicantEducationPoco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicantEducationPocoExists(Guid id)
        {
            return _context.ApplicantEducations.Any(e => e.Id == id);
        }
    }
}
