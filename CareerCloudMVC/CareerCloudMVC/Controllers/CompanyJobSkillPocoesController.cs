﻿using System;
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
    public class CompanyJobSkillPocoesController : Controller
    {
        private readonly CareerCloudContext _context;

        public CompanyJobSkillPocoesController(CareerCloudContext context)
        {
            _context = context;
        }

        // GET: CompanyJobSkillPocoes
        public async Task<IActionResult> Index()
        {
            var careerCloudContext = _context.CompanyJobSkills.Include(c => c.CompanyJobs);
            return View(await careerCloudContext.ToListAsync());
        }

        // GET: CompanyJobSkillPocoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyJobSkillPoco = await _context.CompanyJobSkills
                .Include(c => c.CompanyJobs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyJobSkillPoco == null)
            {
                return NotFound();
            }

            return View(companyJobSkillPoco);
        }

        // GET: CompanyJobSkillPocoes/Create
        public IActionResult Create()
        {
            ViewData["Job"] = new SelectList(_context.CompanyJobs, "Id", "Id");
            return View();
        }

        // POST: CompanyJobSkillPocoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Job,Skill,SkillLevel,Importance")] CompanyJobSkillPoco companyJobSkillPoco)
        {
            if (ModelState.IsValid)
            {
                companyJobSkillPoco.Id = Guid.NewGuid();
                _context.Add(companyJobSkillPoco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Job"] = new SelectList(_context.CompanyJobs, "Id", "Id", companyJobSkillPoco.Job);
            return View(companyJobSkillPoco);
        }

        // GET: CompanyJobSkillPocoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyJobSkillPoco = await _context.CompanyJobSkills.FindAsync(id);
            if (companyJobSkillPoco == null)
            {
                return NotFound();
            }
            ViewData["Job"] = new SelectList(_context.CompanyJobs, "Id", "Id", companyJobSkillPoco.Job);
            return View(companyJobSkillPoco);
        }

        // POST: CompanyJobSkillPocoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Job,Skill,SkillLevel,Importance")] CompanyJobSkillPoco companyJobSkillPoco)
        {
            if (id != companyJobSkillPoco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyJobSkillPoco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyJobSkillPocoExists(companyJobSkillPoco.Id))
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
            ViewData["Job"] = new SelectList(_context.CompanyJobs, "Id", "Id", companyJobSkillPoco.Job);
            return View(companyJobSkillPoco);
        }

        // GET: CompanyJobSkillPocoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyJobSkillPoco = await _context.CompanyJobSkills
                .Include(c => c.CompanyJobs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (companyJobSkillPoco == null)
            {
                return NotFound();
            }

            return View(companyJobSkillPoco);
        }

        // POST: CompanyJobSkillPocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var companyJobSkillPoco = await _context.CompanyJobSkills.FindAsync(id);
            _context.CompanyJobSkills.Remove(companyJobSkillPoco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyJobSkillPocoExists(Guid id)
        {
            return _context.CompanyJobSkills.Any(e => e.Id == id);
        }
    }
}
