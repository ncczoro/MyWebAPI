using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.DataAccess.Ef.Repositories;
using System.Data.Entity;
using WebAPI.DataAccess.Ef;

namespace WebAPI.UnitOfWork
{
    public class UnitOfWork
    {
        private UserRepository _userRepository;

        private Entities _db;


        public UnitOfWork (Entities db)
        {
            _db = db;
        }

        public UserRepository UserReposi 
        {
            get
            {
                if(_userRepository == null)
                {
                    _userRepository = new UserRepository(_db);
                }
                return _userRepository;
            }
        }

    }
}