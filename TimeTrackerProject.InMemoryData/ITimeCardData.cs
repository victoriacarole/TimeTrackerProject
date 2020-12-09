using System;
using System.Collections.Generic;
using System.Text;
using TimeTrackerProject.Models;
using System.Linq;

namespace TimeTrackerProject.InMemoryData
{
    public interface ITimeCardData
    {
        IEnumerable<UserTime> GetAll();
        IEnumerable<UserTime> GetAllByUserId(int id);
        public IEnumerable<UserTime> GetAllByGroupId(int GroupId);

        public UserTime GetById(int Id);
        UserTime Add(UserTime NewGroup);
        int Commit();
    }

    public class InMemoryTimeCardData : ITimeCardData
    {
        readonly List<UserTime> UserTimes;
        private readonly IGroupData groupData;
        private readonly IUserData userData;
        public Group Group { get; set; }
        public User User { get; set; }

        public InMemoryTimeCardData(IGroupData groupData, IUserData userData)
        {
            this.userData = userData;
            this.groupData = groupData;

            UserTimes = new List<UserTime>()
            {
                new UserTime {Id = 1, Group = groupData.GetById(1), User = userData.GetById(1),StartTime = DateTime.Parse("11:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "1", WorkComments = "Worked on CSS.",  },
                new UserTime {Id = 2, Group = groupData.GetById(1), User = userData.GetById(2),StartTime = DateTime.Parse("10:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "2", WorkComments = "Worked on C# backend",  },
                new UserTime {Id = 3, Group = groupData.GetById(1), User = userData.GetById(3),StartTime = DateTime.Parse("9:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "3", WorkComments = "This is cumbersome?",  },
                new UserTime {Id = 4, Group = groupData.GetById(1), User = userData.GetById(4),StartTime = DateTime.Parse("8:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "4", WorkComments = "Designed database.",  },
                new UserTime {Id = 5, Group = groupData.GetById(1), User = userData.GetById(1),StartTime = DateTime.Parse("7:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "5", WorkComments = "This is Boring?",  },
                new UserTime {Id = 6, Group = groupData.GetById(1), User = userData.GetById(2),StartTime = DateTime.Parse("6:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "6", WorkComments = "Implemented class models.",  },
                new UserTime {Id = 7, Group = groupData.GetById(1), User = userData.GetById(3),StartTime = DateTime.Parse("5:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "7", WorkComments = "This is my last Final for the semester.",  },
                new UserTime {Id = 8, Group = groupData.GetById(1), User = userData.GetById(4),StartTime = DateTime.Parse("4:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "8", WorkComments = "This is cumbersome??",  },
                new UserTime {Id = 9, Group = groupData.GetById(1), User = userData.GetById(1),StartTime = DateTime.Parse("3:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "9", WorkComments = "Can i get the page to display correctly?",  },
                new UserTime {Id = 10, Group = groupData.GetById(1), User = userData.GetById(1),StartTime = DateTime.Parse("2:30 PM"), StopTime = DateTime.Parse("12:30 PM"),TotalHours = "10", WorkComments = "This is cumbersome???",  }

            };
        }

        public UserTime Add(UserTime NewUserTime)
        {
            UserTimes.Add(NewUserTime);
            NewUserTime.Id = UserTimes.Max(ut => ut.Id) + 1;
            return NewUserTime;
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<UserTime> GetAll()
        {
            return from ut in UserTimes orderby ut.Group.Id select ut;
        }

        public IEnumerable<UserTime> GetAllByUserId(int UserId)
        {
            return from ut in UserTimes where ut.User.Id == UserId select ut;
            //return UserTimes.FirstOrDefault(ut => ut.User.Id == UserId);
        }

        public IEnumerable<UserTime> GetAllByGroupId(int GroupId)
        {
            return from ut in UserTimes orderby ut.User.Id where ut.Group.Id == GroupId select ut;
            //return UserTimes.FirstOrDefault(ut => ut.User.Id == UserId);
        }
        public UserTime GetById(int Id)
        {
            return UserTimes.FirstOrDefault(ut => ut.Id == Id);
        }
    }

}
