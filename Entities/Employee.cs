﻿using CQRSWithDapper.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Entities
{
    public class Employee : AggregateRoot
    {
        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _jobTitle;

        private Employee() { }

        public Employee(Guid id, int employeeID, string firstName, string lastName, DateTime dateOfBirth, string jobTitle)
        {
            Id = id;
            _employeeID = employeeID;
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _jobTitle = jobTitle;

            //TODO: Apply Events
            //ApplyChange(new EmployeeCreatedEvent(id, employeeID, firstName, lastName, dateOfBirth, jobTitle));
        }
    }
}
