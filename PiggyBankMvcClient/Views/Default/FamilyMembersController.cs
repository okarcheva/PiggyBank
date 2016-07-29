using PiggyBankCore.Domain;
using PiggyBankCore.Repositories;
using System;
using System.Web.Mvc;

namespace PiggyBankMvcClient.Controllers
{
    public class FamilyMembersController : Controller
    {
        private readonly IRepository<FamilyMember> _repository;
        public FamilyMembersController()
        {
            _repository = new FamilyMemberRepository();
        }
        // GET: FamilyMembers
        public ActionResult Index()
        {
            var familyMembersList = _repository.List;
            return View(familyMembersList);
        }

        // GET: FamilyMembers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilyMembers/Create
        [HttpPost]
        public ActionResult Create(FamilyMember familyMember)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _repository.Add(familyMember);
                    return RedirectToAction("Index");
                }

                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: FamilyMembers/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _repository.FindById(id);

            return View(category);
        }

        // POST: FamilyMembers/Edit/5
        [HttpPost]
        public ActionResult Edit(FamilyMember familyMember)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.Update(familyMember);
                    return RedirectToAction("Index");
                }

                return View(familyMember);
            }
            catch (Exception ex)
            {
                return View(familyMember);
            }
        }
    }
}