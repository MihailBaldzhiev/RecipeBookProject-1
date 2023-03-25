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

        public static int AddUser(string username, string password, string confirmPassword)
        {
            List<UserModel> users = new List<UserModel>();
            users = GetAll();

            UserModel user = new UserModel();
            user.Username = username;
            user.Password = password;

            if (username == "" || password == "" || confirmPassword == "")
            {
                return 1;
            }
            else if (password != confirmPassword)
            {
                return 2;
            }

            else if (users.Any(a => a.Username == username))
            {
                return 3;
            }

            else
            {
                Session.userRepo.AddUser(user);
                return 0;
            }
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

