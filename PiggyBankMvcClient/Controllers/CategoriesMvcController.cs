using PiggyBankCore.Domain;
using PiggyBankCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiggyBankMvcClient.Controllers
{
    public class CategoriesMvcController : Controller
    {
        private readonly IRepository<Category> _repository;
        public CategoriesMvcController()
        {
            _repository = new CategoryRepository();
        }

        // GET: Categories
        public ActionResult Index()
        {
            var categories = _repository.List;
            return View(categories);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _repository.Add(category);
                    return RedirectToAction("Index");
                }

                return View();         
               
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _repository.FindById(id);

            return View(category);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Update(category);
                    return RedirectToAction("Index");
                }

                return View(category);
            }
            catch (Exception ex)
            {
                return View(category);
            }
        }
    }
}