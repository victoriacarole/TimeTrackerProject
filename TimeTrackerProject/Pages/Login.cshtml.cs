using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeTrackerProject.Pages
{
    public class LoginModel : PageModel
    {

        private SQLManager sql = new SQLManager();

        public static Models.User newUser = new Models.User();

        public void OnGet()
        {
        }

        public IActionResult OnPostSalt()
        {
            //Set UserNames
            newUser.Name = Request.Form["UserName"].ToString();
            UserStatus.currentUser = Request.Form["UserName"].ToString();

            //Call function to see if username is taken, return message verifying status of username
            //checkUsername();

            return RedirectToPage("/Login");
        }
    }
}
