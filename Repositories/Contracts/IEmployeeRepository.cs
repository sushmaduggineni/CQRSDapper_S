using CQRSWithDapper.Entities;

namespace CQRSWithDapper.Repositories.Contracts
{
    public interface IEmployeeRepository 
    {
        void AddEmployee(Employee employee);
    }
}