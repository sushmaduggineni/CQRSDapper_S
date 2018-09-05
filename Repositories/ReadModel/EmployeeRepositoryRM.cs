using CQRSWithDapper.Entities;
using CQRSWithDapper.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Repositories.ReadModel
{
    public class EmployeeRepositoryRM : BaseRepository<Employee>, IEmployeeRepositoryRM
    {
        private string getAllEmployeeSql = "Slect * from Employee;";

        public IEnumerable<Employee> GetAll()
        {
           return this.Query<Employee>(getAllEmployeeSql);
        }
    }
}
