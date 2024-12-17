using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.DTOs.ViewModel
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public decimal Budget { get; set; }
        public List<string> EmployeeNames { get; set; } // To show the list of employees in the department
    }

}
