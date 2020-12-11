using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackerProject
{
    public class clsGroup
    {
        private int groupID;
        private string groupName;
        private int groupTotalHours;

        public int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public int GroupHours
        {
            get { return groupTotalHours; }
            set { groupTotalHours = value; }
        }
    }
}
