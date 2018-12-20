using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace WebAPI.DataAccess.Ef.Repositories
{
    public class UserRepository
    {
        private Entities db1 = new Entities();


        public User GetUser(int id)
        {
            return db1.AllUser.Where(x => x.ID == id).FirstOrDefault();
        }


        public List<User> GetUsers()
        {
            return db1.AllUser.ToList();
        }

        public void AddUser(User user)
        {
            try
            {
                db1.AllUser.Add(user);
                db1.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(int p, User user)
        {
            try
            {
                db1.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db1.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var userDelete = db1.AllUser.Where(x => x.ID == id).SingleOrDefault();
                db1.Entry(userDelete).State = System.Data.Entity.EntityState.Deleted;
                db1.SaveChanges();
               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}