using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public string Email { get; set; }


    }
}
