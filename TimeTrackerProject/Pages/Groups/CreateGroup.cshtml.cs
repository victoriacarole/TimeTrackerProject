using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeTrackerProject.InMemoryData;
using TimeTrackerProject.Models;

namespace TimeTrackerProject.Pages
{
    public class CreateGroupModel : PageModel
    {
        //private readonly IGroupData groupData;
        //[BindProperty]
        public Group Group = new Group();

        SQLManager sql = new SQLManager();

        public IActionResult OnGet(int? groupId)
        {
            Group = new Group();
            
            if(Group == null)
            {
                return RedirectToPage(".NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                sql.NewGroup(Request.Form["GroupName"].ToString());
                TempData["Message"] = "Group Created!";
                return RedirectToPage("./Groups");
            }
            return Page();
        }
    }
}
