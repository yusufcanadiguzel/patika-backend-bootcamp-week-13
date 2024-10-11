using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjectionIntro
{
    interface ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        void GetInfo();
    }
}
