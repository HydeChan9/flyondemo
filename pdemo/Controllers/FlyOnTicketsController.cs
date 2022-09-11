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
    public class FlyOnTicketsController : Controller
    {
        private readonly TicketsContext _context;

        public FlyOnTicketsController(TicketsContext context)
        {
            _context = context;
        }

        // GET: FlyOnTickets
        public async Task<IActionResult> Index(string id)
        {
            var tickets = from t in _context.FlyOnTickets
                         select t;

                tickets = tickets.Where(s => s.PassportNumber.Contains(id));
            
            return View(await _context.FlyOnTickets.ToListAsync());
        }

        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }




        // GET: FlyOnTickets/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flyOnTickets = await _context.WebLoggingTicket
                .FirstOrDefaultAsync(m => m.BookingNumber == id);
            if (flyOnTickets == null)
            {
                return NotFound();
            }

            return View(flyOnTickets);
        }

        // GET: FlyOnTickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlyOnTickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingNumber,Point,TotalPrice,PassportNumber,MemberID,FlightID,TakeoffTime")] FlyOnTickets flyOnTickets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flyOnTickets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flyOnTickets);
        }

        // GET: FlyOnTickets/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flyOnTickets = await _context.WebLoggingTicket.FindAsync(id);
            if (flyOnTickets == null)
            {
                return NotFound();
            }
            return View(flyOnTickets);
        }

        // POST: FlyOnTickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BookingNumber,Point,TotalPrice,PassportNumber,MemberID,FlightID,TakeoffTime")] FlyOnTickets flyOnTickets)
        {
            if (id != flyOnTickets.BookingNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flyOnTickets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlyOnTicketsExists(flyOnTickets.BookingNumber))
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
            return View(flyOnTickets);
        }

        // GET: FlyOnTickets/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flyOnTickets = await _context.WebLoggingTicket
                .FirstOrDefaultAsync(m => m.BookingNumber == id);
            if (flyOnTickets == null)
            {
                return NotFound();
            }

            return View(flyOnTickets);
        }

        // POST: FlyOnTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var flyOnTickets = await _context.WebLoggingTicket.FindAsync(id);
            _context.WebLoggingTicket.Remove(flyOnTickets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlyOnTicketsExists(string id)
        {
            return _context.WebLoggingTicket.Any(e => e.BookingNumber == id);
        }
    }
}
