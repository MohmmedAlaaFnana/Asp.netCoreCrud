using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Core_Crud.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public string Office { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

    }
}
