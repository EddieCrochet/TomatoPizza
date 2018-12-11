using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TomatoPizzaCafe.Data;
using TomatoPizzaCafe.Models;

namespace TomatoPizzaCafe.Controllers
{
    public class MakeYourOwnsController : Controller
    {
        private readonly ApplicationContext _context;

        public MakeYourOwnsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: MakeYourOwns
        public async Task<IActionResult> Index()
        {
            return View(await _context.MakeYourOwns.ToListAsync());
        }

        // GET: MakeYourOwns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeYourOwn = await _context.MakeYourOwns
                .FirstOrDefaultAsync(m => m.MakeYourOwnId == id);
            if (makeYourOwn == null)
            {
                return NotFound();
            }

            return View(makeYourOwn);
        }

        // GET: MakeYourOwns/Create
        public IActionResult Create()
        {
            ViewBag.toppings = _context.Toppings;
            ViewBag.sauce = new List<string> { "marinara", "pesto", "Alfredo" };
            ViewBag.crust = new List<string> { "hand-tossed", "deep dish", "New York style" };
            return View();
        }

        // POST: MakeYourOwns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MakeYourOwn makeYourOwn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(makeYourOwn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(makeYourOwn);
        }

        // GET: MakeYourOwns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeYourOwn = await _context.MakeYourOwns.FindAsync(id);
            if (makeYourOwn == null)
            {
                return NotFound();
            }
            ViewBag.toppings = _context.Toppings;
            ViewBag.sauce = new List<string> { "marinara", "pesto", "Alfredo" };
            ViewBag.crust = new List<string> { "hand-tossed", "deep dish", "New York style" };
            return View(makeYourOwn);
        }

        // POST: MakeYourOwns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MakeYourOwnId,Topping1,Topping2,Topping3,Topping4,Topping5,Topping6,Sauce,Crust")] MakeYourOwn makeYourOwn)
        {
            if (id != makeYourOwn.MakeYourOwnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(makeYourOwn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MakeYourOwnExists(makeYourOwn.MakeYourOwnId))
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
            return View(makeYourOwn);
        }

        // GET: MakeYourOwns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeYourOwn = await _context.MakeYourOwns
                .FirstOrDefaultAsync(m => m.MakeYourOwnId == id);
            if (makeYourOwn == null)
            {
                return NotFound();
            }

            return View(makeYourOwn);
        }

        // POST: MakeYourOwns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var makeYourOwn = await _context.MakeYourOwns.FindAsync(id);
            _context.MakeYourOwns.Remove(makeYourOwn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MakeYourOwnExists(int id)
        {
            return _context.MakeYourOwns.Any(e => e.MakeYourOwnId == id);
        }
    }
}
