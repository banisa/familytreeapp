using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FamilyTree.ApplicationCore.Entities;
using FamilyTree.ApplicationCore.Interfaces;
using FamilyTree.Web.Models;

namespace FamilyTree.Web.Controllers
{
    public class FamilyTreeController : Controller
    {
        private readonly IFamilyTreeRepository _db;

        public FamilyTreeController(IFamilyTreeRepository db)
        {
            _db = db;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            var children = _db.GetChildren();
            var persons = _db.GetAllPersons();

            var model = children.Select(child => persons.FirstOrDefault(x => x.Id == child.PersonId)).ToList();

            var personChildViewData = new PersonChildViewData()
            {
                Id = 1,
                Children = children,
                Persons = model
            };

            return View(personChildViewData);
        }
     
        [HttpGet]
        public ActionResult ParentDetails(int Id)
        {
            var child = _db.GetChildByPersonId(Id);
            var persons = new List<Person>();
            Person father = null;
            Person mother = null;
            
            if (child != null)
            {
                if(child.FatherId.HasValue)
                {
                     father = _db.GetPersonById(child.FatherId.Value);
                }

                if (child.MotherId.HasValue)
                {
                     mother = _db.GetPersonById(child.MotherId.Value);
                }

                if(father != null)
                    persons.Add(father);

                if(mother != null)
                    persons.Add(mother);

                return View(persons);
            }

            return View("PersonNotFound");
        }

        [HttpGet]
        public ActionResult ParentsTypeAndStatus(int id)
        {
            var model = _db.GetParentById(id);

            if (model != null)
            {
                return View(model);
            }

            return View("ParentNotFound");
        }
    }
}