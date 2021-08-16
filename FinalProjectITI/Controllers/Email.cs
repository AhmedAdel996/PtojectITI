using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Controllers
{
    public class Email : Controller
    {
        private UserManager<IdentityUser> userManager;
        public Email(UserManager<IdentityUser> usrMgr)
        {
            userManager = usrMgr;
        }

        public async Task<IActionResult> ConfirmEmail(string code, string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
                return View("Error");

            var result = await userManager.ConfirmEmailAsync(user, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }
    }
}
