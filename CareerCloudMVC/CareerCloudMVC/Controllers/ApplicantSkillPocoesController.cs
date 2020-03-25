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
    public class ApplicantSkillPocoesController : Controller
    {
        private readonly CareerCloudContext _context;

        public ApplicantSkillPocoesController(CareerCloudContext context)
        {
            _context = context;
        }

        // GET: ApplicantSkillPocoes
        public async Task<IActionResult> Index(Guid? Id)
        {
            //var careerCloudContext = _context.ApplicantSkills.Include(a => a.ApplicantProfile);
            var careerCloudContext = _context.ApplicantSkills.Where(a => a.Applicant==Id);
            return View(await careerCloudContext.ToListAsync());
        }

        // GET: ApplicantSkillPocoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantSkillPoco = await _context.ApplicantSkills
                .Include(a => a.ApplicantProfile)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicantSkillPoco == null)
            {
                return NotFound();
            }

            return View(applicantSkillPoco);
        }

        // GET: ApplicantSkillPocoes/Create
        public IActionResult Create()
        {
            ViewData["Applicant"] = new SelectList(_context.ApplicantProfiles, "Id", "Id");
            return View();
        }

        // POST: ApplicantSkillPocoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Applicant,Skill,SkillLevel,StartMonth,StartYear,EndMonth,EndYear")] ApplicantSkillPoco applicantSkillPoco)
        {
            if (ModelState.IsValid)
            {
                applicantSkillPoco.Id = Guid.NewGuid();
                _context.Add(applicantSkillPoco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Applicant"] = new SelectList(_context.ApplicantProfiles, "Id", "Id", applicantSkillPoco.Applicant);
            return View(applicantSkillPoco);
        }

        // GET: ApplicantSkillPocoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantSkillPoco = await _context.ApplicantSkills.FindAsync(id);
            if (applicantSkillPoco == null)
            {
                return NotFound();
            }
            ViewData["Applicant"] = new SelectList(_context.ApplicantProfiles, "Id", "Id", applicantSkillPoco.Applicant);
            return View(applicantSkillPoco);
        }

        // POST: ApplicantSkillPocoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Applicant,Skill,SkillLevel,StartMonth,StartYear,EndMonth,EndYear")] ApplicantSkillPoco applicantSkillPoco)
        {
            if (id != applicantSkillPoco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicantSkillPoco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicantSkillPocoExists(applicantSkillPoco.Id))
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
            ViewData["Applicant"] = new SelectList(_context.ApplicantProfiles, "Id", "Id", applicantSkillPoco.Applicant);
            return View(applicantSkillPoco);
        }

        // GET: ApplicantSkillPocoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicantSkillPoco = await _context.ApplicantSkills
                .Include(a => a.ApplicantProfile)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicantSkillPoco == null)
            {
                return NotFound();
            }

            return View(applicantSkillPoco);
        }

        // POST: ApplicantSkillPocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var applicantSkillPoco = await _context.ApplicantSkills.FindAsync(id);
            _context.ApplicantSkills.Remove(applicantSkillPoco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicantSkillPocoExists(Guid id)
        {
            return _context.ApplicantSkills.Any(e => e.Id == id);
        }
    }
}
