using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using WebAPI.DataAccess.Ef;
using WebAPI.DataAccess.Ef.Repositories;

namespace WebAPI.Services
{
    public class UserServices
    {
        private UserRepository UserRepo = new UserRepository();

        public User GetUser(int id)
        {
            var user = UserRepo.GetUser(id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            var user = UserRepo.GetUsers();
            if (user == null)
            {
                return null;//new IEnumerable<User>;
            }
            return user;
        }
      
        public bool SaveUser(User postUser)
        {
            try
            {
                UserRepo.AddUser(postUser);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateUser(int p, User user)
        {
            try
            {
                UserRepo.Update(p, user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeteleUser(int id)
        {
            try
            {
                UserRepo.Delete(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}