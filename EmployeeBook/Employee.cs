using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBook
{
    class Employee
    {
        public string Name { get; set; }
        public String Title { get; set; }

        public static Employee GetEmployee()
        {
            var Employee = new Employee
            {
                Name = "John Doe",
                Title = "CEO"
            };
            return Employee;
        }
    }
}
