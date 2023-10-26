using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DutchTreat.Controllers
{
    public class AppController: Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            //throw new InvalidProgramException("Bad things happen to good developers");
            return View();
        }

        [HttpGet("contact")]

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact";
            
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model) {
            if(ModelState.IsValid)
            {
                // Send the email
                _mailService.SendMessage("nata@outlook.com",model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMesage = "Mail Sent";
                ModelState.Clear();
            }
            else
            {
                // Show the errors
            }
            //ViewBag.Title = "Contact us";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
