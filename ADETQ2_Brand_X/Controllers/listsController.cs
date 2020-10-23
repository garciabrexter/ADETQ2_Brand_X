using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ADETQ2_Brand_X.Data;
using ADETQ2_Brand_X.Models;

namespace ADETQ2_Brand_X.Controllers
{
    public class listsController : Controller
    {
        private readonly datalist _context;

        public listsController(datalist context)
        {
            _context = context;
        }

        // GET: lists
        public async Task<IActionResult> Index()
        {
            return View(await _context.list.ToListAsync());
        }

        // GET: lists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var list = await _context.list
                .FirstOrDefaultAsync(m => m.studentinfo == id);
            if (list == null)
            {
                return NotFound();
            }

            return View(list);
        }

        // GET: lists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("studentinfo,studentname,studentno,age,address")] list list)
        {
            if (ModelState.IsValid)
            {
                _context.Add(list);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(list);
        }

        // GET: lists/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var list = await _context.list.FindAsync(id);
            if (list == null)
            {
                return NotFound();
            }
            return View(list);
        }

        // POST: lists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("studentinfo,studentname,studentno,age,address")] list list)
        {
            if (id != list.studentinfo)
            {
                return NotFound();
            }

            var data = await _context.list
                .FirstOrDefaultAsync(m => m.studentinfo == id);
            if (data == null)
            {
                return NotFound(); 
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(list);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!listExists(list.studentinfo))
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
            return View(list);
        }

        // GET: lists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var list = await _context.list
                .FirstOrDefaultAsync(m => m.studentinfo == id);
            if (list == null)
            {
                return NotFound();
            }

            return View(list);
        }

        // POST: lists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var list = await _context.list.FindAsync(id);
            _context.list.Remove(list);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool listExists(string id)
        {
            return _context.list.Any(e => e.studentinfo == id);
        }
    }
}
