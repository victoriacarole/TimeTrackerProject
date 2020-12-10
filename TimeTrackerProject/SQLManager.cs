using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackerProject
{
    public class SQLManager
    {
        private string sSQL;
        DataAccess data = new DataAccess();
        public int NewUser(string username, string hashedPassword, string salt, string userType)
        {
            sSQL = "INSERT INTO dbUser(username, userPassword, uniqueSalt, userType, userTotalHours, userGroup)" +
                " VALUES ('" + username + "', '" + hashedPassword + "', '" + salt + "', '" + userType + "', NULL, NULL)";
            return data.ExecuteNonQuery(sSQL);
        }

        public int NewGroup(string groupName)
        {
            sSQL = "INSERT INTO dbGroup(groupName, GroupTotalHours)" +
                " VALUES('" + groupName + "', 0)";
            return data.ExecuteNonQuery(sSQL);
        }

        public int NewUserTime(int userID, int groupID, DateTime start, DateTime end, string userNote, int userTotalHours)
        {
            sSQL = "INSERT INTO dbUserTime(userID, groupID, startTime, stopTime, userNote, userTotalHours)" +
                " VALUES(" + userID + ", " + groupID + ", " + start + ", " + end + ", '" + userNote + "', " + userTotalHours + ")";
            return data.ExecuteNonQuery(sSQL);
        }

        public List<clsUserTime> GetAllTimes()
        {
            DataSet AllUserTimes;
            List<clsUserTime> Times = new List<clsUserTime>();
            int iRetVal = 0;
            string sSQL = "SELECT * FROM dbUserTime ORDER BY userID";
            AllUserTimes = data.ExecuteSQLStatment(sSQL, ref iRetVal);
            for(int i = 0; i < iRetVal; i++)
            {
                clsUserTime time = new clsUserTime();
                time.UserID = (int)AllUserTimes.Tables[0].Rows[i][0];
                time.GroupID = (int)AllUserTimes.Tables[0].Rows[i][1];
                time.Start = (DateTime)AllUserTimes.Tables[0].Rows[i][2];
                time.Stop = (DateTime)AllUserTimes.Tables[0].Rows[i][3];
                time.Note = AllUserTimes.Tables[0].Rows[i][4].ToString();
                time.Hours = (int)AllUserTimes.Tables[0].Rows[i][5];
                Times.Add(time);
            }
            return Times;
        }

        public List<clsGroup> GetGroups()
        {
            DataSet AllGroups;
            List<clsGroup> Groups = new List<clsGroup>();
            int iRetVal = 0;
            string sSQL = "SELECT * FROM dbGroup";
            AllGroups = data.ExecuteSQLStatment(sSQL, ref iRetVal);
            for(int i = 0; i < iRetVal; i++)
            {
                clsGroup group = new clsGroup();
                group.GroupID = (int)AllGroups.Tables[0].Rows[i][0];
                group.GroupName = AllGroups.Tables[0].Rows[i][1].ToString();
                group.GroupHours = (int)AllGroups.Tables[0].Rows[i][2];
                Groups.Add(group);
            }
            return Groups;
        }

        public string Validate(string username)
       {
            sSQL = "SELECT uniqueSalt FROM dbUser WHERE username = '" + username + "'";
            return data.ExecuteScalarSQL(sSQL);
       }

        public string GetUserID(string username)
        {
            sSQL = "SELECT userID FROM dbUser WHERE username = '" + username + "'";
            return data.ExecuteScalarSQL(sSQL);
        }


    }
}
