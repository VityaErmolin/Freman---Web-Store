using Microsoft.AspNetCore.Mvc;
using PartyInvtes.Models;
using System;
using System.Linq;

namespace PartyInvtes.Controllers
{
    public class HomeController : Controller
    {
      
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            string str = "String model";
            return View("MyView", str);
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                //Ошибка обнаружена
                return View();
            }
        }

        public ViewResult ListResponse()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
