using SEDC.CSharpAdvanced.Quizz.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Quizz.Data.Database
{
   public class InMemoryDatabase
    {
        public List<User> Users { get; set; }

        public InMemoryDatabase()
        {
            InitDatabase();
        }
        public void InitDatabase()
        {

          
            Users = new List<User>
            {
                new User("Daniel Petkovski","danielpetkovski","danielpetkovski",false),
                new User("Darko Fotinovski","darkofotinovski","darkofotinovski",false),
                new User("Strahil Veselovski","strahilveselovski","strahilveselovski",false),
                new User("Blazo Razbiras","blazorazbiras","blazorazbiras",false),
                new User("Kiro Kirov","kirokirov","kirokirov",false),
                new User("Petar Petrovski","petarpetrovski","petarpetrovski",true),
                new User("Zoran Zoranovski","zoranzoranovski","zoranzoranovski",true)

            };

        }



    }
}
