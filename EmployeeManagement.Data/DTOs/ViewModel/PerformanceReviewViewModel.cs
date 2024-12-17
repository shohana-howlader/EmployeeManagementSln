using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.DTOs.ViewModel
{
    public class PerformanceReviewViewModel
    {
        public int PerformanceReviewId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ReviewScore { get; set; }
        public string ReviewNotes { get; set; }
    }

}
