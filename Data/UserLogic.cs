using System;
using Recipe.Models;
using Recipe.Data;

namespace Recipe.Data
{
    public class UserLogic
    {
        private UserContext userContext;

        public UserLogic(UserContext userContext)
        {
            this.userContext = userContext;
        }

        private List<UserModel> GetAll()
        {
            return userContext.Users.ToList();
        }

        public bool CheckIfExists(string username, string password)
        {
            List<UserModel> users = new List<UserModel>();
            users = GetAll();
            bool result;
            if (users.Any(a => a.Username == username))
            {
                if (users.Any(a => a.Password == password))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }

            return result;

        }

        public void AddUser(UserModel user)
        {
            userContext.Users.Add(user);
            userContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var item = userContext.Users.Find(id);
            if (item != null)
            {
                userContext.Users.Remove(item);
                userContext.SaveChanges();
            }
        }
    }
}

