using DbFirstDemo.Models;
using System;
using System.Linq;
using System.Text;

namespace DbFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            DeleteJudgeSystem(context);
            //AddNewProject(context);
            //UpdateProject(context);
        }
        public static void DeleteJudgeSystem(SoftUniContext context)
        {
            var project =
                context.Projects
                .OrderByDescending(x => x.Name == "Judge System").First();
            context.Projects.Remove(project);
            context.SaveChanges();
        }
        public static void DeleteEmployeeProject(SoftUniContext context)
        {
            var employeeProject =
                context.EmployeesProjects
                .OrderByDescending(x => x.EmployeeId == 14).First();
            context.EmployeesProjects.Remove(employeeProject);
            context.SaveChanges();
        }
        public static void UpdateProject(SoftUniContext context)
        {
            var project = context.Projects.FirstOrDefault(x => x.Name == "Road-150");
            project.Name = "Shkolo system";
            project.StartDate = new DateTime(2021, 12, 22);
            context.SaveChanges();
        }
        public static void AddNewProject(SoftUniContext context)
        {
            var project = new Project()
            {
                Name = "Judge System",
                StartDate = DateTime.Now
            };
            context.Projects.Add(project);
            context.SaveChanges();
        }  
        public static void AddNewTown(SoftUniContext context)
        {
            var town = new Town()
            {
                Name = "Plovdiv",
            };
            context.Towns.Add(town);
            context.SaveChanges();
        }
        public static void AddEmployeeWithProject(SoftUniContext context)
        {
            var employee = new Employee()
            {
                FirstName = "Ani",
                LastName = "Petrova",
                JobTitle = "Designer",
                HireDate = DateTime.UtcNow,
                Salary = 2000,
                DepartmentId = 2
            };
            context.Employees.Add(employee);
            employee.EmployeesProjects.Add(new EmployeesProject
            {
                Project = new Project
                {
                    Name = "TTT",
                    StartDate = DateTime.UtcNow
                }
            }
             );
            context.SaveChanges();
        }
        private static object GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context.Employees
                 .Where(x => x.Department.Name == "Research and Development")
                 .Select(x => new
                 {
                     x.FirstName,
                     x.LastName,
                     x.Salary,
                     DepartmentName = x.Department.Name,
                 })
                 .OrderBy(x => x.Salary)
                 .ThenByDescending(x => x.FirstName)
                 .ToList();
            var sb = new StringBuilder();
            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName}from{employee.DepartmentName} - ${employee.Salary:F2}");
            }
            var result = sb.ToString().TrimEnd();
            return result;
        }
        private static object EmployeeCount(SoftUniContext context)
        {
            var employeesCount = context.Employees.Count();
            return employeesCount;
        }
        private static object GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employees = context.Employees.Where(x => x.Salary > 50000).Select(x => new
            {
                x.FirstName,
                x.Salary
            })
                .OrderBy(x => x.FirstName).ToList();
            var sb = new StringBuilder();
            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName}-{employee.Salary}");

            }
            var result = sb.ToString().TrimEnd();
            return result;
        }
    }
}
