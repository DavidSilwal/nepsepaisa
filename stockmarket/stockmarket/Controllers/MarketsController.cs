using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using stockmarket.Models;

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
        public ActionResult Index()
        {
            var objs = (from c in _context.Company
                        orderby c.companyName
                        select c).GroupBy(g => g.companyName).Select(x => x.FirstOrDefault());


            return View(objs.ToList());
        }

        // GET: Markets/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

                return RedirectToAction(nameof(Index));
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

                return RedirectToAction(nameof(Index));
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

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}