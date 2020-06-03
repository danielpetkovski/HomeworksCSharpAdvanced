using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Quizz.Data.Models
{
   public class User : BaseEntity
    {
        public bool IsDone { get; set; }

        public User(string fullName, string userName, string password, bool isTeacher)
            : base (fullName, userName, password, isTeacher)
        {
            IsDone = false;
        }


    }

    

}
