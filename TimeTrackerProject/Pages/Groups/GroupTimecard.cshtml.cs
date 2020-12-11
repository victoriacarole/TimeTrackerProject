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
        public List<clsGroup> Groups { get; set; }
        //public List<> Users { get; set; }
        public string GroupName { get; set; }
       

        public List<clsUserTime> UserTimes { get; set; }
        SQLManager sql = new SQLManager();


        public IActionResult OnGet(int groupId)
        {
            Groups = sql.GetGroups();
            foreach (var group in Groups)
            {
                if (group.GroupID == groupId)
                {
                    GroupName = group.GroupName;
                }
            }


            UserTimes = sql.GetAllTimes(groupId);
            
            return Page();
        }
    }
}