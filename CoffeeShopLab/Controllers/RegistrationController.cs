using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopLab.Controllers
{
    public class RegistrationController : Controller
    {
        
        public IActionResult RegistrationForm()
        {
            return View(new RegisterUser());
        }

        public IActionResult RegistrationResult(RegisterUser registerUser)
        {
            if (ModelState.IsValid)
            {
                return View(registerUser); /*returning registerUser*/
            }
            else
                return View("RegistrationForm", registerUser);
        }

       
    }
}