using HR.LeaveManagment.Application.Persistence.Contracts;
using HR.LeaveManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Persistence.Repositories
{
    public class LeaveAllocayionRepositpry : GenericRepository<LeaveAllocayionRepositpry>, ILeaveAllocationRepository
    {
        public LeaveAllocayionRepositpry(LeaveManagmentDbContext dbContext) : base(dbContext)
        {
        }

        public Task<LeaveAllocationClass> Add(LeaveAllocationClass entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(LeaveAllocationClass entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocationClass> GetLeaveAllocationWithDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveAllocationClass>> GetLeaveAllocationWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task Update(LeaveAllocationClass entity)
        {
            throw new NotImplementedException();
        }

        Task<LeaveAllocationClass> IGenericRepository<LeaveAllocationClass>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<LeaveAllocationClass>> IGenericRepository<LeaveAllocationClass>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
