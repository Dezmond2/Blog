﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities;

namespace Blog.Repository
{
     public interface IUserRepository
    {
        User GetUser(string login);
        List<User> GetUsers();
        void UpdateUser(int Id, bool? IsEnable, bool? IsAdmin);
        void CreateUser(User user);
    }
}
