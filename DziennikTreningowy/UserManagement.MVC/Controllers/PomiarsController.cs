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
    public class PomiarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PomiarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pomiars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pomiar.ToListAsync());
        }

        // GET: Pomiars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pomiar = await _context.Pomiar
                .FirstOrDefaultAsync(m => m.PomiarID == id);
            if (pomiar == null)
            {
                return NotFound();
            }

            return View(pomiar);
        }

        // GET: Pomiars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pomiars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PomiarID,WzrostID,WagaID,RamieID,KlatkaID,TaliaID,UdaID,LydkaID")] Pomiar pomiar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pomiar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pomiar);
        }

        // GET: Pomiars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pomiar = await _context.Pomiar.FindAsync(id);
            if (pomiar == null)
            {
                return NotFound();
            }
            return View(pomiar);
        }

        // POST: Pomiars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PomiarID,WzrostID,WagaID,RamieID,KlatkaID,TaliaID,UdaID,LydkaID")] Pomiar pomiar)
        {
            if (id != pomiar.PomiarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pomiar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PomiarExists(pomiar.PomiarID))
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
            return View(pomiar);
        }

        // GET: Pomiars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pomiar = await _context.Pomiar
                .FirstOrDefaultAsync(m => m.PomiarID == id);
            if (pomiar == null)
            {
                return NotFound();
            }

            return View(pomiar);
        }

        // POST: Pomiars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pomiar = await _context.Pomiar.FindAsync(id);
            _context.Pomiar.Remove(pomiar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PomiarExists(int id)
        {
            return _context.Pomiar.Any(e => e.PomiarID == id);
        }
    }
}
