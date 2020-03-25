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
    public class SecurityLoginsLogPocoesController : Controller
    {
        private readonly CareerCloudContext _context;

        public SecurityLoginsLogPocoesController(CareerCloudContext context)
        {
            _context = context;
        }

        // GET: SecurityLoginsLogPocoes
        public async Task<IActionResult> Index()
        {
            var careerCloudContext = _context.SecurityLoginsLogs.Include(s => s.SecurityLogins);
            return View(await careerCloudContext.ToListAsync());
        }

        // GET: SecurityLoginsLogPocoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityLoginsLogPoco = await _context.SecurityLoginsLogs
                .Include(s => s.SecurityLogins)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (securityLoginsLogPoco == null)
            {
                return NotFound();
            }

            return View(securityLoginsLogPoco);
        }

        // GET: SecurityLoginsLogPocoes/Create
        public IActionResult Create()
        {
            ViewData["Login"] = new SelectList(_context.SecurityLogins, "Id", "Id");
            return View();
        }

        // POST: SecurityLoginsLogPocoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Login,SourceIP,LogonDate,IsSuccesful")] SecurityLoginsLogPoco securityLoginsLogPoco)
        {
            if (ModelState.IsValid)
            {
                securityLoginsLogPoco.Id = Guid.NewGuid();
                _context.Add(securityLoginsLogPoco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Login"] = new SelectList(_context.SecurityLogins, "Id", "Id", securityLoginsLogPoco.Login);
            return View(securityLoginsLogPoco);
        }

        // GET: SecurityLoginsLogPocoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityLoginsLogPoco = await _context.SecurityLoginsLogs.FindAsync(id);
            if (securityLoginsLogPoco == null)
            {
                return NotFound();
            }
            ViewData["Login"] = new SelectList(_context.SecurityLogins, "Id", "Id", securityLoginsLogPoco.Login);
            return View(securityLoginsLogPoco);
        }

        // POST: SecurityLoginsLogPocoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Login,SourceIP,LogonDate,IsSuccesful")] SecurityLoginsLogPoco securityLoginsLogPoco)
        {
            if (id != securityLoginsLogPoco.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(securityLoginsLogPoco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecurityLoginsLogPocoExists(securityLoginsLogPoco.Id))
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
            ViewData["Login"] = new SelectList(_context.SecurityLogins, "Id", "Id", securityLoginsLogPoco.Login);
            return View(securityLoginsLogPoco);
        }

        // GET: SecurityLoginsLogPocoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var securityLoginsLogPoco = await _context.SecurityLoginsLogs
                .Include(s => s.SecurityLogins)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (securityLoginsLogPoco == null)
            {
                return NotFound();
            }

            return View(securityLoginsLogPoco);
        }

        // POST: SecurityLoginsLogPocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var securityLoginsLogPoco = await _context.SecurityLoginsLogs.FindAsync(id);
            _context.SecurityLoginsLogs.Remove(securityLoginsLogPoco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecurityLoginsLogPocoExists(Guid id)
        {
            return _context.SecurityLoginsLogs.Any(e => e.Id == id);
        }
    }
}
