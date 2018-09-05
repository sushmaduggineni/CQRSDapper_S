using AutoMapper;
using CQRSWithDapper.Entities;
using CQRSWithDapper.Repositories.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Queries
{
    public class GetAllEmployeeQuery : IQuery<IEnumerable<Employee>>
    {
        private EmployeeRepositoryRM _employeeRepository;
        private readonly IMapper _mapper;

        public IEnumerable<Employee> Execute()
        {
            return _employeeRepository.GetAll();
        }
    }
}
