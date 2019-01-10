using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TomatoPizzaCafe.Data;
using TomatoPizzaCafe.Models;

namespace TomatoPizzaCafe.Controllers
{
    [Authorize]
    public class MakeYourOwnsController : Controller
    {
        private readonly ApplicationContext _context;
        private UserManager<IdentityUser> _userManager;

        public MakeYourOwnsController(ApplicationContext context, 
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: MakeYourOwns
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            var makeYourOwns = await _context.MakeYourOwns
                .Where(m => m.CustomerName == user.UserName)
                .ToListAsync();

            return View(makeYourOwns);
        }

        // GET: MakeYourOwns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeYourOwn = await _context.MakeYourOwns
                .FirstOrDefaultAsync(m => m.MakeYourOwnID == id);
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
            ViewBag.sauce = new List<string> { "Classic Marinara", "Creamy Garlic Parmesan", "Barbeque", "Buffalo" };
            ViewBag.crust = new List<string> { "Original Pan Pizza", "Hand Tossed Pizza", "Thin `N Crispy", "Original Stuffed Crust" };
            return View();
        }

        // POST: MakeYourOwns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MakeYourOwn makeYourOwn)
        {
            var user = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                makeYourOwn.CustomerName = user.UserName;
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
            ViewBag.sauce = new List<string> { "Classic Marinara", "Creamy Garlic Parmesan", "Barbeque", "Buffalo" };
            ViewBag.crust = new List<string> { "Original Pan Pizza", "Hand Tossed Pizza", "Thin `N Crispy", "Original Stuffed Crust" };
            return View(makeYourOwn);
        }

        // POST: MakeYourOwns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MakeYourOwnID,Topping1,Topping2,Topping3,Topping4,Topping5,Topping6,Sauce,Crust,CustomerName")] MakeYourOwn makeYourOwn)
        {
            if (id != makeYourOwn.MakeYourOwnID)
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
                    if (!MakeYourOwnExists(makeYourOwn.MakeYourOwnID))
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

        }// GET: MakeYourOwns/Order/5
        public async Task<IActionResult> Order(int? id)
        {
            Order order;
            var user = await _userManager.GetUserAsync(User);
            try
            {
                order = _context.Orders.First(o => o.CustomerName == user.UserName);
            }
            catch
            {
                order = new Order();
                order.CustomerName = user.UserName;
                order.OrderItems = new List<OrderItem>();
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            if (order.OrderItems == null)
            {
                order.OrderItems = new List<OrderItem>();
            }

            OrderItem orderItem = new OrderItem
            {
                OrderID = order.OrderID
            };
            
            order.OrderItems.Add(orderItem);
            if (id == null)
            {
                return NotFound();
            }
            var makeYourOwn = await _context.MakeYourOwns.FindAsync(id);
            if (makeYourOwn == null)
            {
                return NotFound();
            }
            orderItem.MakeYourOwn = makeYourOwn;
            orderItem.MakeYourOwnID = makeYourOwn.MakeYourOwnID;
            if (_context.Orders.Contains(order))
            {
                _context.Orders.Update(order);
            }
            else
            {
                _context.Orders.Add(order); 
            }
            return View(orderItem);
        }
        

        // POST: MakeYourOwns/Order/5
        [HttpPost]
        public async Task<IActionResult> Order([Bind("OrderItemID, OrderID, MakeYourOwn, MakeYourOwnID, Size, Number, Price")] OrderItem orderItem)
        {
            var user = await _userManager.GetUserAsync(User);
           _context.OrderItems.Update(orderItem);
            _context.SaveChanges();
            return View(nameof(Thanks));
        }
       
        public IActionResult Thanks()
        {
            return View();
        }

        // GET: MakeYourOwns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeYourOwn = await _context.MakeYourOwns
                .FirstOrDefaultAsync(m => m.MakeYourOwnID == id);
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
            return _context.MakeYourOwns.Any(e => e.MakeYourOwnID == id);
        }
    }
}
