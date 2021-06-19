using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DziennikTreningowy.Data;
using DziennikTreningowy.Models;

namespace DziennikTreningowy.Controllers
{
    public class CwiczeniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CwiczeniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cwiczenies
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cwiczenie.Include(c => c.Kategorias);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cwiczenies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cwiczenie = await _context.Cwiczenie
                .Include(c => c.Kategorias)
                .FirstOrDefaultAsync(m => m.CwiczenieID == id);
            if (cwiczenie == null)
            {
                return NotFound();
            }

            return View(cwiczenie);
        }

        // GET: Cwiczenies/Create
        public IActionResult Create()
        {
            ViewBag.Kategoria = _context.Kategoria.ToDictionary(u => u.KategoriaID, u => u.NazwaKategorii);
            return View();
        }

        // POST: Cwiczenies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CwiczenieID,NazwaCwiczenia,IloscPowtorzen,KategoriaID,NazwaKategorii")] Cwiczenie cwiczenie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cwiczenie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategoriaID"] = new SelectList(_context.Kategoria, "KategoriaID", "KategoriaID", cwiczenie.KategoriaID);
            return View(cwiczenie);
        }

        // GET: Cwiczenies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cwiczenie = await _context.Cwiczenie.FindAsync(id);
            if (cwiczenie == null)
            {
                return NotFound();
            }
            ViewBag.Kategoria = _context.Kategoria.ToDictionary(u => u.KategoriaID, u => u.NazwaKategorii);
            return View(cwiczenie);
        }

        // POST: Cwiczenies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CwiczenieID,NazwaCwiczenia,IloscPowtorzen,KategoriaID,NazwaKategorii")] Cwiczenie cwiczenie)
        {
            if (id != cwiczenie.CwiczenieID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cwiczenie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CwiczenieExists(cwiczenie.CwiczenieID))
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
            ViewData["KategoriaID"] = new SelectList(_context.Kategoria, "KategoriaID", "KategoriaID", cwiczenie.KategoriaID);
            return View(cwiczenie);
        }

        // GET: Cwiczenies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cwiczenie = await _context.Cwiczenie
                .Include(c => c.Kategorias)
                .FirstOrDefaultAsync(m => m.CwiczenieID == id);
            if (cwiczenie == null)
            {
                return NotFound();
            }

            return View(cwiczenie);
        }

        // POST: Cwiczenies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cwiczenie = await _context.Cwiczenie.FindAsync(id);
            _context.Cwiczenie.Remove(cwiczenie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CwiczenieExists(int id)
        {
            return _context.Cwiczenie.Any(e => e.CwiczenieID == id);
        }
    }
}
