﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERPv1.Data;
using ERPv1.ERP.GeneralLedgerModule.AccountCharts.Model;

namespace ERPv1.Controllers
{
    public class AccountChartCountersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountChartCountersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AccountChartCounters
        public async Task<IActionResult> Index()
        {
            var x = await _context.AccountChart.Include(x => x.AccType).Where(x => x.AccNum == x.AccType.ParentAcNum).ToListAsync();
            return View(x);
        }

        // GET: AccountChartCounters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountChartCounter = await _context.AccountChartCounter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountChartCounter == null)
            {
                return NotFound();
            }

            return View(accountChartCounter);
        }

        // GET: AccountChartCounters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountChartCounters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountType,AccountTypeAr,AccountCategory,ParentAcNum,Count,BalanceSheet,IncomeStatement")] AccountChartCounter accountChartCounter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountChartCounter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountChartCounter);
        }

        // GET: AccountChartCounters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountChartCounter = await _context.AccountChartCounter.FindAsync(id);
            if (accountChartCounter == null)
            {
                return NotFound();
            }
            return View(accountChartCounter);
        }

        // POST: AccountChartCounters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountType,AccountTypeAr,AccountCategory,ParentAcNum,Count,BalanceSheet,IncomeStatement")] AccountChartCounter accountChartCounter)
        {
            if (id != accountChartCounter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountChartCounter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountChartCounterExists(accountChartCounter.Id))
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
            return View(accountChartCounter);
        }

        // GET: AccountChartCounters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountChartCounter = await _context.AccountChartCounter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountChartCounter == null)
            {
                return NotFound();
            }

            return View(accountChartCounter);
        }

        // POST: AccountChartCounters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountChartCounter = await _context.AccountChartCounter.FindAsync(id);
            _context.AccountChartCounter.Remove(accountChartCounter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountChartCounterExists(int id)
        {
            return _context.AccountChartCounter.Any(e => e.Id == id);
        }
    }
}
