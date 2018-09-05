using System.Collections.Generic;
using CQRSWithDapper.Entities;

namespace CQRSWithDapper.Repositories.Contracts
{
    public interface IEmployeeRepositoryRM
    {
        IEnumerable<Employee> GetAll();
    }
}