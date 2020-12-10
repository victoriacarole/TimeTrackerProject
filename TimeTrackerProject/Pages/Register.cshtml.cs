using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeTrackerProject.Pages
{
    public class RegisterModel : PageModel
    {

        public static Models.User newUser = new Models.User();

        public string Salt => (string)TempData[nameof(Salt)];
        public string Name => (string)TempData[nameof(Name)];

        public string Message => (string)TempData[nameof(Message)];

        public void OnGet()
        {
            if (Salt == null)
            {
                UserStatus.loggedIn = false;
                string salt = createSalt(16);
                TempData["Salt"] = salt;
                UserStatus.UserSalt = salt;
            }
        }

        /// <summary>
        /// Form will not post unless username and 2 passwords are filled out
        /// Username is taken from client side to verify that it is unique
        /// </summary>
        public IActionResult OnPostSalt()
        {
            //Set UserNames
            newUser.Name = Request.Form["UserName"].ToString();
            UserStatus.currentUser = Request.Form["UserName"].ToString();
            TempData["Name"] = Request.Form["UserName"].ToString();

            //Call function to see if username is taken, return message verifying status of username
            //checkUsername();

            return RedirectToPage("/Register");
        }

        /// <summary>
        /// Posts username, hashed password, and unique user salt and updates the database
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPostTwo()
        {
            newUser.Password = Request.Form["hashed"].ToString();
            newUser.Name = Request.Form["uName"].ToString();
            newUser.UniqueSalt = Request.Form["uSalt"].ToString();
            Models.UserType type = new Models.UserType();
            var Utype = Request.Form["uType"].ToString();
            Utype = gson.toJson(type);

            //Call function to input hashed password, username, and user salt into database
            //insertUser();

            UserStatus.registered = true;
            UserStatus.loggedIn = true;

            return RedirectToPage("/Game");
        }

        /// <summary>
        /// Create salt by generating random char and appending to string
        /// </summary>
        /// <returns>16 character random string</returns>
        private static Random random = new Random();
        public string createSalt(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}