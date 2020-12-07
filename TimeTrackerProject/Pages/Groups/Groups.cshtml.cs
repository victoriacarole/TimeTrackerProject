using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using TimeTrackerProject.InMemoryData;
using TimeTrackerProject.Models;

namespace TimeTrackerProject.Pages
{
    public class GroupsModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IGroupData groupData;
        [TempData]
        public string Message { get; set; }
        public IEnumerable<Group> Groups { get; set; }

        public GroupsModel(IConfiguration config, IGroupData groupData)
        {
            this.config = config;
            this.groupData = groupData;
        }
        public void OnGet()
        {
            Groups = groupData.GetAll();
        }
    }
}
