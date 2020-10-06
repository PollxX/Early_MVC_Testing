using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsEvents.Models;

namespace SportsEvents.Controllers
{
    public class EventController : Controller
    {
        private IEventRepo repos;
        public EventController(IEventRepo repo)
        {
            repos = repo;
        }
        public ViewResult List() => View(repos.Events());

        public ViewResult Login()
        {
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
