using SEDC.CSharpAdvanced.Quizz.Data.Database;
using SEDC.CSharpAdvanced.Quizz.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdvanced.Quizz.Data.Services
{
   public class UserServices : InMemoryDatabase
    {
        public User GetUserByUserName(string username)
        {
            return Users.FirstOrDefault(_user => _user.UserName == username);
        }

        public List<User> GetAllStudents()
        {
            return Users.Where(_user => _user.IsTeacher == false).ToList();
        }
    }
}
