using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TomatoPizzaCafe.Data;
using TomatoPizzaCafe.Models;

namespace TomatoPizzaCafe.Controllers
{
    public class SpecialtyController : Controller
    {
        private readonly ApplicationContext _context;

        public SpecialtyController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Specialty
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pizzas.ToListAsync());
        }

        // GET: Specialty/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // GET: Specialty/Create
        public IActionResult Create()
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var pizza = await _context.Pizzas
            //    .FirstOrDefaultAsync(m => m.PizzaId == id);
            //if (pizza == null)
            //{
            //    return NotFound();
            //}
            //ViewBag.name = pizza.Type;
            return View();
        }

        // POST: Specialty/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PizzaId,Type,Description, EightInchPrice, TenInchPrice, TwelveInchPrice, FourteenInchPrice, EighteenInchPrice")] Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pizza);
        }

        // GET: Specialty/Order/5
        public async Task<IActionResult> Order(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }
            ViewBag.pizza = pizza;
            return View(pizza);
        }

        // POST: Specialty/Order/5
        [HttpPost]
        public IActionResult Order(int id)
        {
            return View(nameof(Thanks));
        }

        public IActionResult Thanks()
        {
            return View();
        }

            // GET: Specialty/Edit/5
            public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }
            return View(pizza);
        }



        // POST: Specialty/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PizzaId,Type,Size,Description,EightInchPrice, TenInchPrice, TwelveInchPrice, FourteenInchPrice, EighteenInchPrice")] Pizza pizza)
        {
            if (id != pizza.PizzaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaExists(pizza.PizzaId))
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
            return View(pizza);
        }

        // GET: Specialty/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // POST: Specialty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            _context.Pizzas.Remove(pizza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaExists(int id)
        {
            return _context.Pizzas.Any(e => e.PizzaId == id);
        }
    }
}
