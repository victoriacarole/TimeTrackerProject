using System;
using System.Collections.Generic;
using System.Text;
using TimeTrackerProject.Models;
using System.Linq;

namespace TimeTrackerProject.InMemoryData
{
    public interface IUserData
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Add(User NewGroup);
        int Commit();
    }

    public class InMemoryUserData : IUserData
    {
        readonly List<User> users;

        public InMemoryUserData()
        {
            users = new List<User>()
            {
                new User {Id = 1, Name = "Edmond Dantes", UsersType = UserType.Student},
                new User {Id = 2, Name = "Fitzwilliam Darcy", UsersType = UserType.Student},
                new User {Id = 3, Name = "Charles Darnay", UsersType = UserType.Student},
                new User {Id = 4, Name = "Stephen Dedalus", UsersType = UserType.Student}

            };
        }

        public User Add(User NewUser)
        {
            users.Add(NewUser);
            NewUser.Id = users.Max(u => u.Id) + 1;
            return NewUser;
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<User> GetAll()
        {
            return from u in users orderby u.Name select u;
        }

        public User GetById(int id)
        {
            return users.SingleOrDefault(u => u.Id == id);
        }
    }

}
