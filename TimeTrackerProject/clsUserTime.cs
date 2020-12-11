using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackerProject
{
    public class clsUserTime
    {
        private int userID;
        private int groupID;
        private DateTime startTime;
        private DateTime stopTime;
        private string userNote;
        private int totalHours;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public DateTime Start
        {
            get { return startTime; }
            set {startTime = value; }
        }

        public DateTime Stop
        {
            get { return stopTime; }
            set { stopTime = value; }
        }

        public string Note
        {
            get { return userNote; }
            set { userNote = value; }
        }

        public int Hours
        {
            get { return totalHours; }
            set { totalHours = value; }
        }

    }
}
