using PiggyBankCore.Domain;
using PiggyBankCore.Repositories;
using PiggyBankMvcClient.ViewModels;
using System;
using System.Web.Mvc;

namespace PiggyBankMvcClient.Controllers
{
    public class OperationsController : Controller
    {
        private readonly IRepository<Operation> _operationsRepository;
        private readonly IRepository<Category> _categoriesRepository;
        private readonly IRepository<FamilyMember> _familyMemberRepository;
        public OperationsController()
        {
            _operationsRepository = new OperationRepository();
            _categoriesRepository = new CategoryRepository();
            _familyMemberRepository = new FamilyMemberRepository();
        }
        // GET: Operations
        public ActionResult Index()          
        {
            var operations = _operationsRepository.List;
            return View(operations);
        }

        // GET: Operations/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(_categoriesRepository.List, "Id", "Name");
            ViewBag.FamilyMemberId = new SelectList(_familyMemberRepository.List, "Id", "Name");

            return View();
        }

        // POST: Operations/Create
        [HttpPost]
        public ActionResult Create(Operation operation)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _operationsRepository.Add(operation);
                    return RedirectToAction("Index");
                }
                return View(operation);                
            }
            catch(Exception ex)
            {
                return View(operation);
            }
        }

        // GET: Operations/Edit/5
        public ActionResult Edit(int id)
        {
            var operation = _operationsRepository.FindById(id);

            ViewBag.CategoryId = new SelectList(_categoriesRepository.List, "Id", "Name");
            ViewBag.FamilyMemberId = new SelectList(_familyMemberRepository.List, "Id", "Name");

            return View(operation);
        }

        // POST: Operations/Edit/5
        [HttpPost]
        public ActionResult Edit(Operation operation)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _operationsRepository.Update(operation);
                    return RedirectToAction("Index");
                }

                return View(operation);                
            }
            catch (Exception ex)
            {
                return View(operation);
            }
        }

        // GET: Operations/Delete/5
        public ActionResult Delete(int id)
        {
            var operation = _operationsRepository.FindById(id);

            return View(operation);
        }

        // POST: Operations/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var operation = _operationsRepository.FindById(id);

            try
            {
                _operationsRepository.Delete(operation);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(operation);
            }

        }
    }
}