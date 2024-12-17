namespace EmployeeManagement.Service.Interface
{
    public interface IDepartment
    {
        int DepartmentId { get; set; }
        string Name { get; set; }
        int ManagerId { get; set; }
        decimal Budget { get; set; }
        ICollection<IEmployee> Employees { get; set; }
    }

}