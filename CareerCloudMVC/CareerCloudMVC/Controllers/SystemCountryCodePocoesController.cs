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
    public class SystemCountryCodePocoesController : Controller
    {
        private readonly CareerCloudContext _context;

        public SystemCountryCodePocoesController(CareerCloudContext context)
        {
            _context = context;
        }

        // GET: SystemCountryCodePocoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SystemCountryCodes.ToListAsync());
        }

        // GET: SystemCountryCodePocoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCountryCodePoco = await _context.SystemCountryCodes
                .FirstOrDefaultAsync(m => m.Code == id);
            if (systemCountryCodePoco == null)
            {
                return NotFound();
            }

            return View(systemCountryCodePoco);
        }

        // GET: SystemCountryCodePocoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SystemCountryCodePocoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Name")] SystemCountryCodePoco systemCountryCodePoco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(systemCountryCodePoco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(systemCountryCodePoco);
        }

        // GET: SystemCountryCodePocoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCountryCodePoco = await _context.SystemCountryCodes.FindAsync(id);
            if (systemCountryCodePoco == null)
            {
                return NotFound();
            }
            return View(systemCountryCodePoco);
        }

        // POST: SystemCountryCodePocoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Code,Name")] SystemCountryCodePoco systemCountryCodePoco)
        {
            if (id != systemCountryCodePoco.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(systemCountryCodePoco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SystemCountryCodePocoExists(systemCountryCodePoco.Code))
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
            return View(systemCountryCodePoco);
        }

        // GET: SystemCountryCodePocoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systemCountryCodePoco = await _context.SystemCountryCodes
                .FirstOrDefaultAsync(m => m.Code == id);
            if (systemCountryCodePoco == null)
            {
                return NotFound();
            }

            return View(systemCountryCodePoco);
        }

        // POST: SystemCountryCodePocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var systemCountryCodePoco = await _context.SystemCountryCodes.FindAsync(id);
            _context.SystemCountryCodes.Remove(systemCountryCodePoco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SystemCountryCodePocoExists(string id)
        {
            return _context.SystemCountryCodes.Any(e => e.Code == id);
        }
    }
}