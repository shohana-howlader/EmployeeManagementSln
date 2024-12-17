namespace EmployeeManagement.Data.Models
{
    public class PerformanceReview
    {
        public int PerformanceReviewId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ReviewScore { get; set; }
        public string ReviewNotes { get; set; }
        public Employee Employee { get; set; }
    }
}