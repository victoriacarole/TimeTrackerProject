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

        /// <summary>
        /// Take username, return unique salt and hashed password
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPostSalt()
        {
            //Set UserNames
            newUser.Name = Request.Form["UserName"].ToString();
            UserStatus.currentUser = Request.Form["UserName"].ToString();

            UserStatus.UserSalt = sql.Validate(newUser.Name);
            UserStatus.UserHashed = sql.getHashed(newUser.Name);

            return RedirectToPage("/Login");
        }

        public IActionResult OnPostTwo()
        {
            

            return RedirectToPage("/Groups/Groups");
        }
    }
}
