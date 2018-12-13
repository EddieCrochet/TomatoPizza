using System;
using System.Collections.Generic;
using System.IO;
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
    public class MakeYourOwnsController : Controller
    {
        private readonly ApplicationContext _context;
        private UserManager<IdentityUser> _userManager;

        public MakeYourOwnsController(ApplicationContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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
        public async Task<IActionResult> Edit(int id, [Bind("MakeYourOwnID,Topping1,Topping2,Topping3,Topping4,Topping5,Topping6,Sauce,Crust")] MakeYourOwn makeYourOwn)
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
                if (order.OrderItems == null)
                    order.OrderItems = new List<OrderItem>();
            }
            catch
            {
                order = new Order();
                order.OrderItems = new List<OrderItem>();
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            //var orderId = order.OrderID;
            order.CustomerName = user.UserName;
            OrderItem orderItem = new OrderItem();
            orderItem.OrderID = order.OrderID;
            order.OrderItems.Add(orderItem);
            _context.OrderItem.Add(orderItem);
            _context.SaveChanges();
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
            if (_context.Orders.Contains(order))
            {
                _context.Orders.Update(order);
            }
            else
            {
                _context.Orders.Add(order);
            }
            _context.SaveChanges();
            return View(orderItem);
        }
        //    var order = new Order();
        //    var orderId = order.OrderID;
        //    order.OrderItems = new List<OrderItem>();
        //    order.CustomerName = _userManager.GetUserName(User);
        //    OrderItem orderItem = new OrderItem();
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    order.OrderItems.Add(orderItem);
        //    _context.OrderItem.Add(orderItem);
        //    _context.Orders.Add(order);
        //    _context.SaveChanges();
        //    var pizza = await _context.Pizzas.FindAsync(id);
        //    if (pizza == null)
        //    {
        //        return NotFound();
        //    }
        //    orderItem.Pizza = pizza;
        //    return View(orderItem);
        //}

        //// POST: Pizzas/Order/5
        //[HttpPost]
        //public async Task<IActionResult> Order(OrderItem orderItem)
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    var order = _context.Orders.FirstOrDefault(o => o.CustomerName == user.UserName);
        //    var pizza = _context.Pizzas.FirstOrDefault(p => p.PizzaID == orderItem.Pizza.PizzaID);
        //    orderItem.Pizza = pizza;
        //    orderItem.OrderID = order.OrderID;
        //    orderItem.Order = order;
        //    _context.OrderItem.Add(orderItem);
        //    _context.SaveChanges();
        //    return View(nameof(Thanks));
        //}
        //// GET: MakeYourOwns/Order/5
        //public async Task<IActionResult> Order(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var makeYourOwn = await _context.MakeYourOwns.FindAsync(id);
        //    if (makeYourOwn == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewBag.makeYourOwn = makeYourOwn;
        //    return View(makeYourOwn);
    //}

        // POST: MakeYourOwns/Order/5
        [HttpPost]
        public async Task<IActionResult> Order([Bind("OrderItemID, Size, Number")] OrderItem _orderItem)
        {
            var user = await _userManager.GetUserAsync(User);
            var order = _context.Orders.FirstOrDefault(o => o.CustomerName == user.UserName);
            var orderItem = _context.OrderItem.FirstOrDefault(oi => oi.OrderItemID == _orderItem.OrderItemID);
            orderItem.Size = _orderItem.Size;
            orderItem.Number = _orderItem.Number;
            _context.OrderItem.Update(orderItem);
            _context.SaveChanges();
            return View(nameof(Thanks));
        }
        //Order order = new Order();
        //var user = _userManager.GetUserAsync(User);
        //var makeYourOwn = _context.MakeYourOwns.FirstOrDefault(m => m.MakeYourOwnID == id);
        //order.CustomerName = user.ToString();
        //order.MakeYourOwns = new List<MakeYourOwn>
        //{
        //    makeYourOwn
        //};
        //_context.Orders.Add(order);
        //_context.SaveChanges();
        //return View(nameof(Thanks));
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
