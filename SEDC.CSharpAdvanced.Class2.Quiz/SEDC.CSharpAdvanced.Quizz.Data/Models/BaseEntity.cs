using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Quizz.Data.Models
{
   public class BaseEntity
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsTeacher { get; set; }

        public BaseEntity(string fullName, string userName, string password, bool isTeacher)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
            IsTeacher = isTeacher;
        }

    }
}
