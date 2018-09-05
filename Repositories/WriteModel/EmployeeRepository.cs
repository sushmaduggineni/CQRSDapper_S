using CQRSWithDapper.Entities;
using CQRSWithDapper.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Repositories.WriteModel
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private string createEmployeeSql = "INSERT INTO Employee Values (@Employess);";

        public void AddEmployee(Employee employee)
        {
            this.Execute(createEmployeeSql, employee);
        }

    }
}
