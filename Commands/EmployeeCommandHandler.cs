using AutoMapper;
using CQRSWithDapper.Commands.Contracts;
using CQRSWithDapper.Entities;
using CQRSWithDapper.Repositories.WriteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Commands
{
    public class EmployeeCommandHandler : ICommandHandler<CreateEmployeeCommand>
    {
        private EmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeCommandHandler(IMapper mapper, EmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public async Task Handle(CreateEmployeeCommand command)
        {
            Employee employee = _mapper.Map<Employee>(command);
            await Task.Run(() => _employeeRepository.AddEmployee(employee));
        }
    }
}
