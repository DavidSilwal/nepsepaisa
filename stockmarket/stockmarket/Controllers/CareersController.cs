using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using stockmarket.Models;

namespace stockmarket.Controllers
{
    public class CareersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CareersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Careers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Careers.ToListAsync());
        }

        // GET: Careers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var careers = await _context.Careers
                .SingleOrDefaultAsync(m => m.Id == id);
            if (careers == null)
            {
                return NotFound();
            }

            return View(careers);
        }

        // GET: Careers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Careers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Body,PublishDate,DeadLine,PublishedBy,IsExpired,Id")] Careers careers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(careers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(careers);
        }

        // GET: Careers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var careers = await _context.Careers.SingleOrDefaultAsync(m => m.Id == id);
            if (careers == null)
            {
                return NotFound();
            }
            return View(careers);
        }

        // POST: Careers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Body,PublishDate,DeadLine,PublishedBy,IsExpired,Id")] Careers careers)
        {
            if (id != careers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(careers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CareersExists(careers.Id))
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
            return View(careers);
        }

        // GET: Careers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var careers = await _context.Careers
                .SingleOrDefaultAsync(m => m.Id == id);
            if (careers == null)
            {
                return NotFound();
            }

            return View(careers);
        }

        // POST: Careers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var careers = await _context.Careers.SingleOrDefaultAsync(m => m.Id == id);
            _context.Careers.Remove(careers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CareersExists(string id)
        {
            return _context.Careers.Any(e => e.Id == id);
        }
    }
}
