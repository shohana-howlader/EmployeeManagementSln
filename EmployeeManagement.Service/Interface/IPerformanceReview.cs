namespace EmployeeManagement.Service.Interface
{
    public interface IPerformanceReview
    {
        int PerformanceReviewId { get; set; }
        int EmployeeId { get; set; }
        DateTime ReviewDate { get; set; }
        int ReviewScore { get; set; }
        string ReviewNotes { get; set; }
        IEmployee Employee { get; set; }
    }

}