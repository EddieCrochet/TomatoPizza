using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TomatoPizzaCafe.Data;
using TomatoPizzaCafe.Models;

namespace TomatoPizzaCafe.Controllers
{
    public class PizzasController : Controller
    {
        private readonly ApplicationContext _context;
        private UserManager<IdentityUser> _userManager;

        public PizzasController(ApplicationContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Pizzzas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pizzas.ToListAsync());
        }

        // GET: Pizzas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.PizzaID == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // GET: Pizzas/Create
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

        // POST: Pizzas/Create
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

        // GET: Pizzas/Order/5
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

        // POST: Pizzas/Order/5
        [HttpPost]
        public IActionResult Order(int id)
        {
            Order order = new Order();
            var user = _userManager.GetUserAsync(User);
            var pizza = _context.Pizzas.FirstOrDefault(p => p.PizzaID == id);
            order.CustomerID = user.Id;
            order.Pizzas = new List<Pizza>
            {
                pizza
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            return View(nameof(Thanks));
        }

        public IActionResult Thanks()
        {
            return View();
        }

            // GET: Pizzas/Edit/5
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



        // POST: Pizzas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PizzaId,Type,Size,Description,EightInchPrice, TenInchPrice, TwelveInchPrice, FourteenInchPrice, EighteenInchPrice")] Pizza pizza)
        {
            if (id != pizza.PizzaID)
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
                    if (!PizzaExists(pizza.PizzaID))
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

        // GET: Pizzas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.PizzaID == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // POST: Pizzas/Delete/5
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
            return _context.Pizzas.Any(e => e.PizzaID == id);
        }
    }
}
