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
    public class TreningsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TreningsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Trenings
        public async Task<IActionResult> Index(string sordOrder)
        {
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sordOrder) ? "nameDesc" : "";
            ViewData["DateSortParam"] = sordOrder == "date" ? "dateDesc" : "date";

            var applicationDbContext = from t in _context.Trening.Include(t => t.Cwiczenies).Include(t => t.Cwiczenies.Kategorias) select t;
            //var applicationDbContext = _context.Trening.Include(t => t.Cwiczenies).Include(t => t.Cwiczenies.Kategorias);
            applicationDbContext = applicationDbContext.OrderBy(t => t.DOB);

            return View(await applicationDbContext.AsNoTracking().ToListAsync());
        }

        // GET: Trenings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trening = await _context.Trening
                .Include(t => t.Cwiczenies)
                .FirstOrDefaultAsync(m => m.TreningID == id);
            if (trening == null)
            {
                return NotFound();
            }

            return View(trening);
        }

        // GET: Trenings/Create
        public IActionResult Create()
        {
            ViewBag.Cwiczenie = _context.Cwiczenie.ToDictionary(u => u.CwiczenieID, u => u.NazwaCwiczenia);
            ViewBag.Kategoria = _context.Kategoria.ToDictionary(u => u.KategoriaID, u => u.NazwaKategorii);
            return View();
        }

        // POST: Trenings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TreningID,KategoriaID,NazwaKategorii,CwiczenieID,NazwaCwiczenia,DOB,isActive")] Trening trening)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trening);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CwiczenieID"] = new SelectList(_context.Cwiczenie, "CwiczenieID", "CwiczenieID", trening.CwiczenieID);
            ViewData["KategoriaID"] = new SelectList(_context.Kategoria, "KategoriaID", "KategoriaID", trening.KategoriaID);
            return View(trening);
        }

        // GET: Trenings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trening = await _context.Trening.FindAsync(id);
            if (trening == null)
            {
                return NotFound();
            }
            ViewBag.Cwiczenie = _context.Cwiczenie.ToDictionary(u => u.CwiczenieID, u => u.NazwaCwiczenia);
            ViewBag.Kategoria = _context.Kategoria.ToDictionary(u => u.KategoriaID, u => u.NazwaKategorii);
            return View(trening);
        }

        // POST: Trenings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TreningID,KategoriaID,NazwaKategorii,CwiczenieID,NazwaCwiczenia,DOB,isActive")] Trening trening)
        {
            if (id != trening.TreningID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trening);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TreningExists(trening.TreningID))
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
            ViewData["CwiczenieID"] = new SelectList(_context.Cwiczenie, "CwiczenieID", "CwiczenieID", trening.CwiczenieID);
            ViewData["KategoriaID"] = new SelectList(_context.Kategoria, "KategoriaID", "KategoriaID", trening.KategoriaID);
            return View(trening);
        }

        // GET: Trenings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trening = await _context.Trening
                .Include(t => t.Cwiczenies)
                .FirstOrDefaultAsync(m => m.TreningID == id);
            if (trening == null)
            {
                return NotFound();
            }

            return View(trening);
        }

        // POST: Trenings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trening = await _context.Trening.FindAsync(id);
            _context.Trening.Remove(trening);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TreningExists(int id)
        {
            return _context.Trening.Any(e => e.TreningID == id);
        }
    }
}
