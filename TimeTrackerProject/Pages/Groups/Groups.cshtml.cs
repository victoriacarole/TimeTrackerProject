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

        SQLManager sql = new SQLManager();

        [TempData]
        public string Message { get; set; }
        public List<clsGroup> Groups = new List<clsGroup>();

        public void OnGet()
        {
            Groups = sql.GetGroups();
        }
    }
}
