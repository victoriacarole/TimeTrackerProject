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
        private readonly ITimeCardData timeCardData;

        public Group Group { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<UserTime> UserTimes { get; set; }

        public GroupTimecardModel(IGroupData groupData, ITimeCardData timeCardData)
        {
            this.groupData = groupData;
            this.timeCardData = timeCardData;

        }
        public IActionResult OnGet(int groupId)
        {
            Group = groupData.GetById(groupId);
            UserTimes = timeCardData.GetAllByGroupId(groupId);

            if (Group == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
