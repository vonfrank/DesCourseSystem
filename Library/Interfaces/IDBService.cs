﻿using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IDBService
    {
        void SetConnection(string url, int port, string db, string username, string password);
        void CloseConnection();
        void CreateUser(User user);
        List<User> GetAllUser();
        List<User> GetUserType(UserType usertype);
        User GetUser(string user);
        List<Course> GetUserCourse(User user);
        List<Course> GetAllCourse();
        void SetUser(User user);
        void SignUpForCourse(User user, Course course);
        void RemoveFromCourse(User user, Course course);
    }
}
