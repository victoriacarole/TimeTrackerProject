using System;
using System.Collections.Generic;
using System.Text;
using TimeTrackerProject.Models;
using System.Linq;

namespace TimeTrackerProject.InMemoryData
{
    public interface IGroupData
    {
        IEnumerable<Group> GetAll();
        Group GetById(int id);
    }

    public class InMemoryGroupData : IGroupData
    {
        readonly List<Group> groups;

        public InMemoryGroupData()
        {
            groups = new List<Group>()
            {
                new Group {Id = 1, Name = "Workoholics", TotalHours = "100" },
                new Group {Id = 2, Name = "Alpha Team", TotalHours = "70" },
                new Group {Id = 3, Name = "Entrepreneurs", TotalHours = "80" },
                new Group {Id = 4, Name = "Peacekeepers ", TotalHours = "50" }

            };
        }

        public IEnumerable<Group> GetAll()
        {
            return from g in groups orderby g.Name select g;
        }

        public Group GetById(int id)
        {
            return groups.SingleOrDefault(g => g.Id == id);
        }
    }

}
