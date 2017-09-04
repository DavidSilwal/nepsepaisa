using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using stockmarket.Models;
using Microsoft.EntityFrameworkCore;

namespace stockmarket.Controllers
{
    public class MarketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarketsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Markets
        public async Task<ActionResult> IndexAsync(int? page)
        {
            var objs = (from c in _context.Company
                        orderby c.companyName
                        select c).GroupBy(g => g.companyName).Select(x => x.FirstOrDefault());


            int pageSize = 10;
            return View(await PaginatedList<Company>.CreateAsync(objs, page ?? 1, pageSize));


           // return View(objs.ToList());
        }

        // GET: Markets/Details/5
        public ActionResult Details(string id)
        {

            var objs = _context.Company.Find(id);
            return View(objs);
        }

        // GET: Markets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Markets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: Markets/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Markets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: Markets/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Markets/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}