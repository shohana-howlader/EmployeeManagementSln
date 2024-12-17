using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public DateTime JoinDate { get; set; }
        public int DepartmentId { get; set; }
        public bool IsDeleted { get; set; }
        public Department Department { get; set; }
        public ICollection<PerformanceReview> PerformanceReviews { get; set; }
    }
}
