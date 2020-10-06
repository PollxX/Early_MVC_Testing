using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsEvents.Models;

namespace SportsEvents.Controllers
{
    public class PersonController : Controller
    {
        private IEventRepo repos;
        public PersonController(IEventRepo repo)
        {
            this.repos = repo;
        }
        public ViewResult List() => View(this.repos.Persons());

        [HttpPost]
        public ActionResult EventToPerson(Admin admin)
        {
            if (admin.Username == "admin" && admin.Password == "abc")
            {
                return View("List", this.repos.Persons());
            }
            return RedirectToAction("Login", "Event");
            
        }

        [HttpPost]
        public ActionResult RemovePerson(int id)
        {
            this.repos.RemovePerson(id);
            return View("List", this.repos.Persons());
        }

        [HttpPost]
        public ActionResult EditPerson(int id, string type, string value)
        {
            this.repos.EditPerson(id, type, value);
            return View("List", this.repos.Persons());
        }

        public ViewResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Thank(Person per)
        {
            this.repos.AddPerson(per);
            return View();
        }

        public ViewResult RSVPform()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RSVPresult(int eID, int pID, string name)
        {
            this.repos.RSVP(eID, pID, name);
            return RedirectToAction("List", "Event");
        }
    }
}
