using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjectionIntro
{
    internal class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
