using System;
using Recipe.Models;
using Recipe.Data;
using Recipe.Utils;
using System.Linq;
using Recipe.Repositories;

namespace Recipe.Data
{
    public static class UserService
    {

        private static List<UserModel> GetAll()
        {
            return Session.userRepo.GetAll();
        }

        public static bool CheckIfExists(string username, string password)
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

        public static void AddUser(UserModel user)
        {
            Session.userRepo.AddUser(user);
        }

        public static void DeleteUser(int id)
        {
            var item = Session.userRepo.Find(id);
            if (item != null)
            {
                Session.userRepo.DeleteUser(item);
            }
        }
    }
}

