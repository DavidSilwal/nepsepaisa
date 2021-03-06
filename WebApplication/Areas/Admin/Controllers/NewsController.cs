﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication.Core.Domains;
using WebApplication.Infrastructure.Repository;

namespace WebApplication.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly INewsRepository _newsRepository;

        public NewsController(INewsRepository newsRepository) => _newsRepository = newsRepository;

        private readonly WebApplicationDbContext _context = new WebApplicationDbContext();

        public IActionResult Index()
        {
            
            //var item = await _newsRepository.FindAll();

            return View(_context.News);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(News model)
        {
            if (ModelState.IsValid)
            {
                News item = new News
                {                                      
                     Body = Request.Form["editor1"].ToString(),
                     addedBy = $"admin",
                     publishedDate = DateTime.Now

                };

                //_newsRepository.Save(item);

                _context.News.AddRange(item);
            }
            else
            {
                return View(model);
            };

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var queryresult = await _newsRepository.Get(id);
           // var queryresult = await _context.News.Find(id);


            if (queryresult == null)
            {
                return NotFound();
            }

            return View(queryresult);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var queryresult = await _newsRepository.Get(id);
            if (queryresult == null)
            {
                return NotFound();
            }

            return View(queryresult);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(News model)
        {

            if (ModelState.IsValid)
            {
                News item = new News
                {
                      Title = model.Title,
                      Body = Request.Form["editor1"].ToString(),

                };


                await _newsRepository.Update(item);

                return RedirectToAction("Index");
            }
            return View();
        }


        public async Task<IActionResult> Delete(string id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var queryresult = await _newsRepository.Get(id);

            if (queryresult == null)
            {
                return NotFound();
            }

            return View(queryresult);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var item = await _newsRepository.Get(id);
            await _newsRepository.Delete(item);

            return RedirectToAction("Index");
        }
   
    }
}
