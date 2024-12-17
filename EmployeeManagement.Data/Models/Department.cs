namespace EmployeeManagement.Data.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public decimal Budget { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}