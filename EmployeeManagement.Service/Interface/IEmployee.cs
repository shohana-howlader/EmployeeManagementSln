using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service.Interface
{
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Position { get; set; }
        DateTime JoinDate { get; set; }
        int DepartmentId { get; set; }
        bool IsDeleted { get; set; }
        IDepartment Department { get; set; }
        ICollection<IPerformanceReview> PerformanceReviews { get; set; }
    }

}
