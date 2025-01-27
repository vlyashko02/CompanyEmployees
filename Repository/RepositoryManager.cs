﻿using Contracts;
using Entities;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryDbContext context;
        private ICompanyRepository companyRepository;
        private IEmployeeRepository employeeRepository;

        public RepositoryManager(RepositoryDbContext context)
        {
            this.context = context;
        }

        public ICompanyRepository Company
        {
            get
            {
                if (companyRepository == null)
                    companyRepository = new CompanyRepository(context);
                return companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository(context);
                return employeeRepository;
            }
        }

        public async Task SaveAsync() => await context.SaveChangesAsync();
    }
}
