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
    public class GroupTimecardModel : PageModel
    {
        private readonly IGroupData groupData;
        public Group Group { get; set; }
        public GroupTimecardModel(IGroupData groupData)
        {
            this.groupData = groupData;
        }
        public IActionResult OnGet(int groupId)
        {
            Group = groupData.GetById(groupId);
            if(Group == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
