using System;
using System.Collections.Generic;
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
            sSQL = "INSERT INTO dbUser(username, userPassword, uniqueSalt, userType, userTotalHours)" +
                " VALUES ('" + username + "', '" + hashedPassword + "', '" + salt + "', '" + userType + "', 0)";
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
    }
}
