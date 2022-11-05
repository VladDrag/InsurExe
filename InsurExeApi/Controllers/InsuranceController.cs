using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InsurExeApi.Models.DatabaseModels;

namespace InsurExeApi.Controllers
{
    [Route("/api")]
    [ApiController]
    public class InsuranceController : Controller
    {
        private readonly InsuranceMovieContext _context;

        public InsuranceController(InsuranceMovieContext context)
        {
            _context = context;
        }

        // GET: Insurance
        [HttpGet]
        public async Task<IActionResult> Index()
        {
              return _context.InsuranceDb != null ?
                          Ok(await _context.InsuranceDb.ToListAsync()) :
                          Problem("Entity set 'InsuranceMovieContext.InsuranceDb'  is null.");
        }

        // GET: Insurance/Details/5
//        public async Task<IActionResult> Details(string id)
//        {
//            if (id == null || _context.InsuranceDb == null)
//            {
//                return NotFound();
//            }
//
//            var insuranceDb = await _context.InsuranceDb
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (insuranceDb == null)
//            {
//                return NotFound();
//            }
//
//            return View(insuranceDb);
//        }

        // GET: Insurance/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

        // POST: Insurance/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Description,Type,MonthlyPayment,AmountInsured,InsuranceTime")] InsuranceDb insuranceDb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insuranceDb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Ok(insuranceDb);
        }

        // GET: Insurance/Edit/5
//        public async Task<IActionResult> Edit(string id)
//        {
//            if (id == null || _context.InsuranceDb == null)
//            {
//                return NotFound();
//            }
//
//            var insuranceDb = await _context.InsuranceDb.FindAsync(id);
//            if (insuranceDb == null)
//            {
//                return NotFound();
//            }
//            return View(insuranceDb);
//        }

        // POST: Insurance/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(string id, [Bind("Id,Description,Type,MonthlyPayment,AmountInsured,InsuranceTime")] InsuranceDb insuranceDb)
//        {
//            if (id != insuranceDb.Id)
//            {
//                return NotFound();
//            }
//
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(insuranceDb);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!InsuranceDbExists(insuranceDb.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(insuranceDb);
//        }
//
//        // GET: Insurance/Delete/5
//        public async Task<IActionResult> Delete(string id)
//        {
//            if (id == null || _context.InsuranceDb == null)
//            {
//                return NotFound();
//            }
//
//            var insuranceDb = await _context.InsuranceDb
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (insuranceDb == null)
//            {
//                return NotFound();
//            }
//
//            return View(insuranceDb);
//        }
//
//        // POST: Insurance/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(string id)
//        {
//            if (_context.InsuranceDb == null)
//            {
//                return Problem("Entity set 'InsuranceMovieContext.InsuranceDb'  is null.");
//            }
//            var insuranceDb = await _context.InsuranceDb.FindAsync(id);
//            if (insuranceDb != null)
//            {
//                _context.InsuranceDb.Remove(insuranceDb);
//            }
//
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }
//
//        private bool InsuranceDbExists(string id)
//        {
//          return (_context.InsuranceDb?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
    }
}
