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
        private readonly IGroupData groupData;
        [BindProperty]
        public Group Group { get; set; }
        public CreateGroupModel(IGroupData groupData)
        {
            this.groupData = groupData;
        }
        public IActionResult OnGet(int? groupId)
        {
            if(groupId.HasValue)
            {
                Group = groupData.GetById(groupId.Value);
            }
            else
            {
                Group = new Group();
            }
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
                groupData.Add(Group);
                groupData.Commit();
                TempData["Message"] = "Group Created!";
                return RedirectToPage("./Groups");
            }
            return Page();
        }
    }
}
