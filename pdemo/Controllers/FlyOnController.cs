using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pdemo;
using pdemo.Models;

namespace pdemo.Controllers
{
    public class FlyOnController : Controller
    {
        private readonly DBContext _context;

        public FlyOnController(DBContext context)
        {
            _context = context;
        }

        // GET: FlyOn
        public async Task<IActionResult> Index()
        {
            return View(await _context.WebLogging.ToListAsync());
        }

        // GET: FlyOn/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flyOn = await _context.WebLogging
                .FirstOrDefaultAsync(m => m.MemberID == id);
            if (flyOn == null)
            {
                return NotFound();
            }

            return View(flyOn);
        }

        // GET: FlyOn/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlyOn/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberID,MemberName,Gender,Address,Email,Phone,Birthday,Password,TotalPoint")] FlyOn flyOn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flyOn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flyOn);
        }

 // GET: FlyOn/Gift/5
        public async Task<IActionResult> Gift(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flyOn = await _context.WebLogging.FindAsync(id);
            if (flyOn == null)
            {
                return NotFound();
            }
            return PartialView(flyOn);
        }

        // POST: FlyOn/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Gift(int id, [Bind("MemberID,MemberName,Gender,Address,Email,Phone,Birthday,Password,TotalPoint")] FlyOn flyOn)
        {
            if (id != flyOn.MemberID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flyOn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlyOnExists(flyOn.MemberID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Gift));
            }
            return View(flyOn);
        }

        // GET: FlyOn/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flyOn = await _context.WebLogging.FindAsync(id);
            if (flyOn == null)
            {
                return NotFound();
            }
            return View(flyOn);
        }

       

        // POST: FlyOn/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemberID,MemberName,Gender,Address,Email,Phone,Birthday,Password,TotalPoint")] FlyOn flyOn)
        {
            if (id != flyOn.MemberID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flyOn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlyOnExists(flyOn.MemberID))
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
            return View(flyOn);
        }

        // GET: FlyOn/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flyOn = await _context.WebLogging
                .FirstOrDefaultAsync(m => m.MemberID == id);
            if (flyOn == null)
            {
                return NotFound();
            }

            return View(flyOn);
        }

        // POST: FlyOn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flyOn = await _context.WebLogging.FindAsync(id);
            _context.WebLogging.Remove(flyOn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlyOnExists(int id)
        {
            return _context.WebLogging.Any(e => e.MemberID == id);
        }
    }
}
