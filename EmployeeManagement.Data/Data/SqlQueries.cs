using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.Data
{
    public class SqlQueries
    {
        public const string GetAveragePerformanceScorePerDepartment = @"
            CREATE PROCEDURE GetAveragePerformanceScorePerDepartment
            AS
            BEGIN
                SELECT 
                    d.DepartmentId,
                    d.Name AS DepartmentName,
                    AVG(pr.ReviewScore) AS AveragePerformanceScore
                FROM 
                    Department d
                INNER JOIN 
                    Employee e ON d.DepartmentId = e.DepartmentId
                INNER JOIN 
                    PerformanceReview pr ON e.EmployeeId = pr.EmployeeId
                GROUP BY 
                    d.DepartmentId, d.Name
                ORDER BY 
                    d.DepartmentId;
            END;
        ";

        public const string AddEmployeeAndAssignDepartment = @"
          CREATE PROCEDURE AddEmployeeAndAssignDepartment
            @EmployeeId INT,
            @Name NVARCHAR(100),
            @Email NVARCHAR(100),
            @Phone NVARCHAR(20),
            @Position NVARCHAR(50),
            @JoinDate DATE,
            @DepartmentId INT
        AS
        BEGIN
            BEGIN TRY
                BEGIN TRANSACTION;

                -- Insert the new employee
                INSERT INTO Employee (EmployeeId, Name, Email, Phone, Position, JoinDate, DepartmentId, IsDeleted)
                VALUES (@EmployeeId, @Name, @Email, @Phone, @Position, @JoinDate, @DepartmentId, 0);

                -- Ensure the department exists
                IF NOT EXISTS (SELECT 1 FROM Department WHERE DepartmentId = @DepartmentId)
                BEGIN
                    RAISERROR('Department does not exist', 16, 1);
                END;

                -- Optionally, update employee count in the department (if tracked)
                -- UPDATE Department SET EmployeeCount = EmployeeCount + 1 WHERE DepartmentId = @DepartmentId;

                COMMIT TRANSACTION;
            END TRY
            BEGIN CATCH
                ROLLBACK TRANSACTION;
                -- Output error information
                PRINT ERROR_MESSAGE();
            END CATCH;
        END;
        ";
    }
}
